namespace lab10
{
    partial class FTimeTable
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
            this.TBData = new System.Windows.Forms.TextBox();
            this.TBWay = new System.Windows.Forms.TextBox();
            this.TBStation = new System.Windows.Forms.TextBox();
            this.TBDepartureTime = new System.Windows.Forms.TextBox();
            this.TBArivalTime = new System.Windows.Forms.TextBox();
            this.TBRailway = new System.Windows.Forms.TextBox();
            this.TBTrainNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TBCode
            // 
            this.TBCode.Location = new System.Drawing.Point(1118, 12);
            this.TBCode.Name = "TBCode";
            this.TBCode.Size = new System.Drawing.Size(217, 22);
            this.TBCode.TabIndex = 1;
            // 
            // TBData
            // 
            this.TBData.Location = new System.Drawing.Point(1118, 54);
            this.TBData.Name = "TBData";
            this.TBData.Size = new System.Drawing.Size(217, 22);
            this.TBData.TabIndex = 2;
            // 
            // TBWay
            // 
            this.TBWay.Location = new System.Drawing.Point(1118, 103);
            this.TBWay.Name = "TBWay";
            this.TBWay.Size = new System.Drawing.Size(217, 22);
            this.TBWay.TabIndex = 3;
            // 
            // TBStation
            // 
            this.TBStation.Location = new System.Drawing.Point(1118, 154);
            this.TBStation.Name = "TBStation";
            this.TBStation.Size = new System.Drawing.Size(217, 22);
            this.TBStation.TabIndex = 4;
            // 
            // TBDepartureTime
            // 
            this.TBDepartureTime.Location = new System.Drawing.Point(1118, 346);
            this.TBDepartureTime.Name = "TBDepartureTime";
            this.TBDepartureTime.Size = new System.Drawing.Size(217, 22);
            this.TBDepartureTime.TabIndex = 8;
            // 
            // TBArivalTime
            // 
            this.TBArivalTime.Location = new System.Drawing.Point(1118, 295);
            this.TBArivalTime.Name = "TBArivalTime";
            this.TBArivalTime.Size = new System.Drawing.Size(217, 22);
            this.TBArivalTime.TabIndex = 7;
            // 
            // TBRailway
            // 
            this.TBRailway.Location = new System.Drawing.Point(1118, 246);
            this.TBRailway.Name = "TBRailway";
            this.TBRailway.Size = new System.Drawing.Size(217, 22);
            this.TBRailway.TabIndex = 6;
            // 
            // TBTrainNumber
            // 
            this.TBTrainNumber.Location = new System.Drawing.Point(1118, 204);
            this.TBTrainNumber.Name = "TBTrainNumber";
            this.TBTrainNumber.Size = new System.Drawing.Size(217, 22);
            this.TBTrainNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1018, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1018, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Way";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1018, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Station";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1018, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Train number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1018, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Railway";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1018, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Arival time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1018, 352);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Departure time";
            // 
            // BTDelete
            // 
            this.BTDelete.Location = new System.Drawing.Point(1118, 374);
            this.BTDelete.Name = "BTDelete";
            this.BTDelete.Size = new System.Drawing.Size(75, 23);
            this.BTDelete.TabIndex = 17;
            this.BTDelete.Text = "Delete";
            this.BTDelete.UseVisualStyleBackColor = true;
            this.BTDelete.Click += new System.EventHandler(this.BTDelete_Click);
            // 
            // BTInsert
            // 
            this.BTInsert.Location = new System.Drawing.Point(1260, 374);
            this.BTInsert.Name = "BTInsert";
            this.BTInsert.Size = new System.Drawing.Size(75, 23);
            this.BTInsert.TabIndex = 18;
            this.BTInsert.Text = "Insert";
            this.BTInsert.UseVisualStyleBackColor = true;
            this.BTInsert.Click += new System.EventHandler(this.BTInsert_Click);
            // 
            // BTEdit
            // 
            this.BTEdit.Location = new System.Drawing.Point(1129, 403);
            this.BTEdit.Name = "BTEdit";
            this.BTEdit.Size = new System.Drawing.Size(206, 23);
            this.BTEdit.TabIndex = 19;
            this.BTEdit.Text = "Edit";
            this.BTEdit.UseVisualStyleBackColor = true;
            this.BTEdit.Click += new System.EventHandler(this.BTEdit_Click);
            // 
            // FTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 450);
            this.Controls.Add(this.BTEdit);
            this.Controls.Add(this.BTInsert);
            this.Controls.Add(this.BTDelete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBDepartureTime);
            this.Controls.Add(this.TBArivalTime);
            this.Controls.Add(this.TBRailway);
            this.Controls.Add(this.TBTrainNumber);
            this.Controls.Add(this.TBStation);
            this.Controls.Add(this.TBWay);
            this.Controls.Add(this.TBData);
            this.Controls.Add(this.TBCode);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FTimeTable";
            this.Text = "FTimeTable";
            this.Load += new System.EventHandler(this.FTimeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TBCode;
        private System.Windows.Forms.TextBox TBData;
        private System.Windows.Forms.TextBox TBWay;
        private System.Windows.Forms.TextBox TBStation;
        private System.Windows.Forms.TextBox TBDepartureTime;
        private System.Windows.Forms.TextBox TBArivalTime;
        private System.Windows.Forms.TextBox TBRailway;
        private System.Windows.Forms.TextBox TBTrainNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTDelete;
        private System.Windows.Forms.Button BTInsert;
        private System.Windows.Forms.Button BTEdit;
    }
}