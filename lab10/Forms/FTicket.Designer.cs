namespace lab10
{
    partial class FTicket
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
            this.TBCode = new System.Windows.Forms.TextBox();
            this.TBFrom = new System.Windows.Forms.TextBox();
            this.TBWhere = new System.Windows.Forms.TextBox();
            this.TBTimeTable = new System.Windows.Forms.TextBox();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTEdit = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(658, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(742, 23);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(196, 22);
            this.TBCode.TabIndex = 1;
            // 
            // TBFrom
            // 
            this.TBFrom.Location = new System.Drawing.Point(742, 76);
            this.TBFrom.Name = "TBFrom";
            this.TBFrom.Size = new System.Drawing.Size(196, 22);
            this.TBFrom.TabIndex = 2;
            // 
            // TBWhere
            // 
            this.TBWhere.Location = new System.Drawing.Point(742, 131);
            this.TBWhere.Name = "TBWhere";
            this.TBWhere.Size = new System.Drawing.Size(196, 22);
            this.TBWhere.TabIndex = 3;
            // 
            // TBTimeTable
            // 
            this.TBTimeTable.Location = new System.Drawing.Point(742, 188);
            this.TBTimeTable.Name = "TBTimeTable";
            this.TBTimeTable.Size = new System.Drawing.Size(196, 22);
            this.TBTimeTable.TabIndex = 4;
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(742, 232);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(75, 23);
            this.BTDelete.TabIndex = 5;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(863, 232);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(75, 23);
            this.BTInsert.TabIndex = 6;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Where";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "TimeTable";
            // 
            // BTEdit
            // 
            this.BTEdit.Location = new System.Drawing.Point(742, 261);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(196, 23);
            this.BTEdit.TabIndex = 11;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // FTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.TBTimeTable);
            this.Controls.Add(this.TBWhere);
            this.Controls.Add(this.TBFrom);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FTicket";
            this.Text = "FTicket";
            this.Load += new System.EventHandler(this.FTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.TextBox TBFrom;
        private System.Windows.Forms.TextBox TBWhere;
        private System.Windows.Forms.TextBox TBTimeTable;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTEdit;
    }
}