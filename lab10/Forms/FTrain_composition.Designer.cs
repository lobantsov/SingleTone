namespace lab10
{
    partial class FTrain_composition
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
            this.TBTrain = new System.Windows.Forms.TextBox();
            this.TBVagon = new System.Windows.Forms.TextBox();
            this.TBTypeVagon = new System.Windows.Forms.TextBox();
            this.TBSeets = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BTDelete = new System.Windows.Forms.Button();
            this.BTInsert = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(666, 470);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TBTrain
            // 
            this.TBTrain.Location = new System.Drawing.Point(795, 12);
            this.TBTrain.Name = "TBTrain";
            this.TBTrain.Size = new System.Drawing.Size(171, 22);
            this.TBTrain.TabIndex = 1;
            // 
            // TBVagon
            // 
            this.TBVagon.Location = new System.Drawing.Point(795, 71);
            this.TBVagon.Name = "TBVagon";
            this.TBVagon.Size = new System.Drawing.Size(171, 22);
            this.TBVagon.TabIndex = 2;
            // 
            // TBTypeVagon
            // 
            this.TBTypeVagon.Location = new System.Drawing.Point(795, 135);
            this.TBTypeVagon.Name = "TBTypeVagon";
            this.TBTypeVagon.Size = new System.Drawing.Size(171, 22);
            this.TBTypeVagon.TabIndex = 3;
            // 
            // TBSeets
            // 
            this.TBSeets.Location = new System.Drawing.Point(795, 198);
            this.TBSeets.Name = "TBSeets";
            this.TBSeets.Size = new System.Drawing.Size(171, 22);
            this.TBSeets.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "train";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "vagon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "type_vagon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "seets";
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(795, 252);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(75, 23);
            this.BTDelete.TabIndex = 9;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(891, 252);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(75, 23);
            this.BTInsert.TabIndex = 10;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // BTEdit
            // 
            this.BTEdit.Location = new System.Drawing.Point(795, 281);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(171, 23);
            this.BTEdit.TabIndex = 11;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // FTrain_composition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 470);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBSeets);
            this.Controls.Add(this.TBTypeVagon);
            this.Controls.Add(this.TBVagon);
            this.Controls.Add(this.TBTrain);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FTrain_composition";
            this.Text = "FTrain_composition";
            this.Load += new System.EventHandler(this.FTrain_composition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBTrain;
        private System.Windows.Forms.TextBox TBVagon;
        private System.Windows.Forms.TextBox TBTypeVagon;
        private System.Windows.Forms.TextBox TBSeets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.Button BTEdit;
    }
}