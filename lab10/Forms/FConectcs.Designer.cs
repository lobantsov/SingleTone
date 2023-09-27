namespace lab10
{
    partial class FConectcs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.BTConnect = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CBFilter = new System.Windows.Forms.CheckBox();
            this.BTCreate = new System.Windows.Forms.Button();
            this.BTTest_Connection = new System.Windows.Forms.Button();
            this.BTCreate_Connection = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BTDrop_Table = new System.Windows.Forms.Button();
            this.CBSwitcher = new System.Windows.Forms.CheckBox();
            this.BTInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(38, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "jwkrush.com.ua";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(38, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "kkte_nau";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(38, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(197, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "kkte_nau";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(38, 171);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "KkTe#NaU";
            // 
            // BTConnect
            // 
            this.BTConnect.Location = new System.Drawing.Point(38, 242);
            this.BTConnect.Name = "BTConnect";
            this.BTConnect.Size = new System.Drawing.Size(197, 23);
            this.BTConnect.TabIndex = 4;
            this.BTConnect.Text = "Connect";
            this.BTConnect.UseVisualStyleBackColor = true;
            this.BTConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(322, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(847, 656);
            this.dataGridView1.TabIndex = 6;
            // 
            // CBFilter
            // 
            this.CBFilter.AutoSize = true;
            this.CBFilter.Enabled = false;
            this.CBFilter.Location = new System.Drawing.Point(38, 419);
            this.CBFilter.Name = "CBFilter";
            this.CBFilter.Size = new System.Drawing.Size(18, 17);
            this.CBFilter.TabIndex = 7;
            this.CBFilter.UseVisualStyleBackColor = true;
            this.CBFilter.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BTCreate
            // 
            this.BTCreate.Enabled = false;
            this.BTCreate.Location = new System.Drawing.Point(38, 330);
            this.BTCreate.Name = "BTCreate";
            this.BTCreate.Size = new System.Drawing.Size(95, 23);
            this.BTCreate.TabIndex = 8;
            this.BTCreate.Text = "Create Table";
            this.BTCreate.UseVisualStyleBackColor = true;
            this.BTCreate.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BTTest_Connection
            // 
            this.BTTest_Connection.Location = new System.Drawing.Point(38, 283);
            this.BTTest_Connection.Name = "BTTest_Connection";
            this.BTTest_Connection.Size = new System.Drawing.Size(197, 23);
            this.BTTest_Connection.TabIndex = 9;
            this.BTTest_Connection.Text = "Test connection";
            this.BTTest_Connection.UseVisualStyleBackColor = true;
            this.BTTest_Connection.Click += new System.EventHandler(this.BTTest_Connection_Click);
            // 
            // BTCreate_Connection
            // 
            this.BTCreate_Connection.Location = new System.Drawing.Point(38, 213);
            this.BTCreate_Connection.Name = "BTCreate_Connection";
            this.BTCreate_Connection.Size = new System.Drawing.Size(197, 23);
            this.BTCreate_Connection.TabIndex = 10;
            this.BTCreate_Connection.Text = "Create connection";
            this.BTCreate_Connection.UseVisualStyleBackColor = true;
            this.BTCreate_Connection.Click += new System.EventHandler(this.BTCreate_Connection_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BTDrop_Table
            // 
            this.BTDrop_Table.Enabled = false;
            this.BTDrop_Table.Location = new System.Drawing.Point(140, 330);
            this.BTDrop_Table.Name = "BTDrop_Table";
            this.BTDrop_Table.Size = new System.Drawing.Size(95, 23);
            this.BTDrop_Table.TabIndex = 11;
            this.BTDrop_Table.Text = "Drop Table";
            this.BTDrop_Table.UseVisualStyleBackColor = true;
            this.BTDrop_Table.Click += new System.EventHandler(this.BTDrop_Table_Click);
            // 
            // CBSwitcher
            // 
            this.CBSwitcher.Appearance = System.Windows.Forms.Appearance.Button;
            this.CBSwitcher.AutoSize = true;
            this.CBSwitcher.Enabled = false;
            this.CBSwitcher.Location = new System.Drawing.Point(38, 373);
            this.CBSwitcher.Name = "CBSwitcher";
            this.CBSwitcher.Size = new System.Drawing.Size(67, 26);
            this.CBSwitcher.TabIndex = 12;
            this.CBSwitcher.Text = "Switcher";
            this.CBSwitcher.UseVisualStyleBackColor = true;
            this.CBSwitcher.CheckedChanged += new System.EventHandler(this.CBSwitcher_CheckedChanged);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(140, 376);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(95, 23);
            this.BTInsert.TabIndex = 13;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // FConectcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 692);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.CBSwitcher);
            this.Controls.Add(this.BTDrop_Table);
            this.Controls.Add(this.BTCreate_Connection);
            this.Controls.Add(this.BTTest_Connection);
            this.Controls.Add(this.BTCreate);
            this.Controls.Add(this.CBFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTConnect);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FConectcs";
            this.Text = "FConectcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button BTConnect;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox CBFilter;
        private System.Windows.Forms.Button BTCreate;
        private System.Windows.Forms.Button BTTest_Connection;
        private System.Windows.Forms.Button BTCreate_Connection;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTDrop_Table;
        private System.Windows.Forms.CheckBox CBSwitcher;
        private System.Windows.Forms.Button BTInsert;
    }
}