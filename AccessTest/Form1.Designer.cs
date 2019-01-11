namespace AccessTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.selectQueryTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertQueryTxt = new System.Windows.Forms.TextBox();
            this.selectQueryBtn = new System.Windows.Forms.Button();
            this.insertQueryBtn = new System.Windows.Forms.Button();
            this.selectQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testGrid = new System.Windows.Forms.DataGridView();
            this.TrackArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackBundle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT";
            // 
            // selectQueryTxt
            // 
            this.selectQueryTxt.Location = new System.Drawing.Point(16, 30);
            this.selectQueryTxt.Multiline = true;
            this.selectQueryTxt.Name = "selectQueryTxt";
            this.selectQueryTxt.Size = new System.Drawing.Size(417, 62);
            this.selectQueryTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(439, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "INSERT";
            // 
            // insertQueryTxt
            // 
            this.insertQueryTxt.Location = new System.Drawing.Point(442, 30);
            this.insertQueryTxt.Multiline = true;
            this.insertQueryTxt.Name = "insertQueryTxt";
            this.insertQueryTxt.Size = new System.Drawing.Size(417, 62);
            this.insertQueryTxt.TabIndex = 1;
            // 
            // selectQueryBtn
            // 
            this.selectQueryBtn.Location = new System.Drawing.Point(16, 99);
            this.selectQueryBtn.Name = "selectQueryBtn";
            this.selectQueryBtn.Size = new System.Drawing.Size(417, 33);
            this.selectQueryBtn.TabIndex = 2;
            this.selectQueryBtn.Text = "Go";
            this.selectQueryBtn.UseVisualStyleBackColor = true;
            this.selectQueryBtn.Click += new System.EventHandler(this.selectQueryBtn_Click);
            // 
            // insertQueryBtn
            // 
            this.insertQueryBtn.Location = new System.Drawing.Point(442, 98);
            this.insertQueryBtn.Name = "insertQueryBtn";
            this.insertQueryBtn.Size = new System.Drawing.Size(417, 33);
            this.insertQueryBtn.TabIndex = 2;
            this.insertQueryBtn.Text = "Go";
            this.insertQueryBtn.UseVisualStyleBackColor = true;
            this.insertQueryBtn.Click += new System.EventHandler(this.insertQueryBtn_Click);
            // 
            // testGrid
            // 
            this.testGrid.AllowUserToAddRows = false;
            this.testGrid.AllowUserToDeleteRows = false;
            this.testGrid.AllowUserToOrderColumns = true;
            this.testGrid.AllowUserToResizeColumns = false;
            this.testGrid.AllowUserToResizeRows = false;
            this.testGrid.AutoGenerateColumns = false;
            this.testGrid.BackgroundColor = System.Drawing.Color.White;
            this.testGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.testGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrackArtist,
            this.Label,
            this.TrackBundle});
            this.testGrid.DataSource = this.selectQueryBindingSource;
            this.testGrid.GridColor = System.Drawing.Color.SteelBlue;
            this.testGrid.Location = new System.Drawing.Point(16, 137);
            this.testGrid.Name = "testGrid";
            this.testGrid.ReadOnly = true;
            this.testGrid.Size = new System.Drawing.Size(843, 324);
            this.testGrid.TabIndex = 4;
            // 
            // TrackArtist
            // 
            this.TrackArtist.DataPropertyName = "ID";
            this.TrackArtist.HeaderText = "ID";
            this.TrackArtist.Name = "TrackArtist";
            this.TrackArtist.ReadOnly = true;
            // 
            // Label
            // 
            this.Label.DataPropertyName = "ObjectName";
            this.Label.HeaderText = "ObjectName";
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            // 
            // TrackBundle
            // 
            this.TrackBundle.DataPropertyName = "ObjectDescription";
            this.TrackBundle.HeaderText = "ObjectDescription";
            this.TrackBundle.Name = "TrackBundle";
            this.TrackBundle.ReadOnly = true;
            this.TrackBundle.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 474);
            this.Controls.Add(this.testGrid);
            this.Controls.Add(this.insertQueryBtn);
            this.Controls.Add(this.selectQueryBtn);
            this.Controls.Add(this.insertQueryTxt);
            this.Controls.Add(this.selectQueryTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AccessTest";
            ((System.ComponentModel.ISupportInitialize)(this.selectQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource dbConnectionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox selectQueryTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insertQueryTxt;
        private System.Windows.Forms.Button selectQueryBtn;
        private System.Windows.Forms.Button insertQueryBtn;
        private System.Windows.Forms.BindingSource selectQueryBindingSource;
        private System.Windows.Forms.DataGridView testGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackBundle;
    }
}

