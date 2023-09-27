namespace lab10
{
    partial class FPath
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TBNumber = new System.Windows.Forms.TextBox();
            this.TBTimeArival = new System.Windows.Forms.TextBox();
            this.TBTimeDeparture = new System.Windows.Forms.TextBox();
            this.BTDetele = new System.Windows.Forms.Button();
            this.BTInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BTEdit = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(766, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TBNumber
            // 
            this.TBNumber.Location = new System.Drawing.Point(871, 107);
            this.TBNumber.Name = "TBNumber";
            this.TBNumber.Size = new System.Drawing.Size(177, 22);
            this.TBNumber.TabIndex = 3;
            // 
            // TBTimeArival
            // 
            this.TBTimeArival.Location = new System.Drawing.Point(871, 164);
            this.TBTimeArival.Name = "TBTimeArival";
            this.TBTimeArival.Size = new System.Drawing.Size(177, 22);
            this.TBTimeArival.TabIndex = 4;
            // 
            // TBTimeDeparture
            // 
            this.TBTimeDeparture.Location = new System.Drawing.Point(871, 223);
            this.TBTimeDeparture.Name = "TBTimeDeparture";
            this.TBTimeDeparture.Size = new System.Drawing.Size(177, 22);
            this.TBTimeDeparture.TabIndex = 5;
            // 
            // BTDetele
            // 
            this.BTDetele.Location = new System.Drawing.Point(973, 273);
            this.BTDetele.Name = "BTDetele";
            this.BTDetele.Size = new System.Drawing.Size(75, 23);
            this.BTDetele.TabIndex = 6;
            this.BTDetele.Text = "detele";
            this.BTDetele.UseVisualStyleBackColor = true;
            this.BTDetele.Click += new System.EventHandler(this.BTDetele_Click);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(871, 273);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(75, 23);
            this.BTInsert.TabIndex = 7;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(778, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Way";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Station";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "time arival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(772, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "time departure";
            // 
            // BTEdit
            // 
            this.BTEdit.Location = new System.Drawing.Point(871, 325);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(177, 23);
            this.BTEdit.TabIndex = 13;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(871, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(871, 61);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 14;
            // 
            // FPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.BTDetele);
            this.Controls.Add(this.TBTimeDeparture);
            this.Controls.Add(this.TBTimeArival);
            this.Controls.Add(this.TBNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FPath";
            this.Text = "FPath";
            this.Load += new System.EventHandler(this.FPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBNumber;
        private System.Windows.Forms.TextBox TBTimeArival;
        private System.Windows.Forms.TextBox TBTimeDeparture;
        private System.Windows.Forms.Button BTDetele;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BTEdit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}