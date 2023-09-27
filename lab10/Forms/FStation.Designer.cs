namespace lab10
{
    partial class FStation
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
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTInsert = new System.Windows.Forms.Button();
            this.TBCode = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(598, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(660, 167);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(75, 23);
            this.BTDelete.TabIndex = 1;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(766, 167);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(75, 23);
            this.BTInsert.TabIndex = 2;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(660, 12);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(181, 22);
            this.TBCode.TabIndex = 3;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(660, 58);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(181, 22);
            this.TBName.TabIndex = 4;
            // 
            // TBType
            // 
            this.TBType.Location = new System.Drawing.Point(660, 120);
            this.TBType.Name = "TBType";
            this.TBType.Size = new System.Drawing.Size(181, 22);
            this.TBType.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(614, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(614, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "type";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBType);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FStation";
            this.Text = "FStation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FStation_FormClosed);
            this.Load += new System.EventHandler(this.FStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}