using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectToAccess();
            //InsertIntoDatabase("INSERT INTO Objects (ObjectName, ObjectDescription) VALUES ('I dont know what the fuck this is', 'Oh god, please help, it might be sentient');");
            var values = DBSelect("SELECT * FROM Objects");
            this.FormClosing += delegate { CloseConnection(); };
        }

        void CloseConnection() { conn.Close(); }

        static DataTable db;
        static OleDbConnection conn;
        void ConnectToAccess()
        {
            // This function connects to the .mdb file and initialises the static DataTable variable, against which we can run SQL queries to access data within the file //
            // Adapted from https://stackoverflow.com/questions/16906535/connect-and-read-mdb-item-with-c-sharp //
            db = new DataTable();
            conn = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = database.mdb");
            conn.Open();
        }

        void DBInsert(string query)
        {
            var command = new OleDbCommand(query, conn);
            command.ExecuteNonQuery();
        }

        List<DatabaseResponse> DBSelect(string query)
        {
            // Create a Dictionary of the results //
            List<DatabaseResponse> returnedValues = new List<DatabaseResponse>();

            var command = new OleDbCommand(query, conn);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                DatabaseResponse dr = new DatabaseResponse();
                try { dr.ID = reader["ID"].ToString(); } catch (IndexOutOfRangeException) { }
                try { dr.ObjectName = reader["ObjectName"].ToString(); } catch (IndexOutOfRangeException) { }
                try { dr.ObjectDescription = reader["ObjectDescription"].ToString(); } catch (IndexOutOfRangeException) { }
                returnedValues.Add(dr);
            }

            return returnedValues;
        }

        private void selectQueryBtn_Click(object sender, EventArgs e)
        {
            selectQueryBindingSource.Clear();
            List<DatabaseResponse> response = DBSelect(selectQueryTxt.Text);

            foreach(DatabaseResponse d in response) selectQueryBindingSource.Add(d);

            testGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void insertQueryBtn_Click(object sender, EventArgs e)
        {
            DBInsert(insertQueryTxt.Text);
        }
    }
}
