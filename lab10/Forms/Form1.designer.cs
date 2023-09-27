namespace lab10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTStation = new System.Windows.Forms.Button();
            this.BTPath = new System.Windows.Forms.Button();
            this.BTTrain_composition = new System.Windows.Forms.Button();
            this.BTTrain = new System.Windows.Forms.Button();
            this.BTTicket = new System.Windows.Forms.Button();
            this.BTWay = new System.Windows.Forms.Button();
            this.BTTimetable = new System.Windows.Forms.Button();
            this.BTTimeTibleDrop = new System.Windows.Forms.Button();
            this.BTWayDrop = new System.Windows.Forms.Button();
            this.BTTikectDrop = new System.Windows.Forms.Button();
            this.BTTrainDrop = new System.Windows.Forms.Button();
            this.BTTrainComposition_drop = new System.Windows.Forms.Button();
            this.BTPath_Drop = new System.Windows.Forms.Button();
            this.BTStation_Drop = new System.Windows.Forms.Button();
            this.BTOpenStation = new System.Windows.Forms.Button();
            this.BTOpenPath = new System.Windows.Forms.Button();
            this.BTOpenTrain_compsition = new System.Windows.Forms.Button();
            this.BTOpenTrain = new System.Windows.Forms.Button();
            this.BTOpenTicket = new System.Windows.Forms.Button();
            this.BTOpenWay = new System.Windows.Forms.Button();
            this.BTOpenTimetable = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTStation
            // 
            this.BTStation.Location = new System.Drawing.Point(12, 56);
            this.BTStation.Name = "BTStation";
            this.BTStation.Size = new System.Drawing.Size(175, 23);
            this.BTStation.TabIndex = 0;
            this.BTStation.Text = "Create Station";
            this.BTStation.UseVisualStyleBackColor = true;
            this.BTStation.Click += new System.EventHandler(this.BTStation_Click);
            // 
            // BTPath
            // 
            this.BTPath.Location = new System.Drawing.Point(12, 85);
            this.BTPath.Name = "BTPath";
            this.BTPath.Size = new System.Drawing.Size(175, 23);
            this.BTPath.TabIndex = 1;
            this.BTPath.Text = "Create Path";
            this.BTPath.UseVisualStyleBackColor = true;
            this.BTPath.Click += new System.EventHandler(this.BTPath_Click);
            // 
            // BTTrain_composition
            // 
            this.BTTrain_composition.Location = new System.Drawing.Point(12, 114);
            this.BTTrain_composition.Name = "BTTrain_composition";
            this.BTTrain_composition.Size = new System.Drawing.Size(175, 23);
            this.BTTrain_composition.TabIndex = 2;
            this.BTTrain_composition.Text = "Create train composition";
            this.BTTrain_composition.UseVisualStyleBackColor = true;
            this.BTTrain_composition.Click += new System.EventHandler(this.BTTrain_composition_Click);
            // 
            // BTTrain
            // 
            this.BTTrain.Location = new System.Drawing.Point(12, 143);
            this.BTTrain.Name = "BTTrain";
            this.BTTrain.Size = new System.Drawing.Size(175, 23);
            this.BTTrain.TabIndex = 3;
            this.BTTrain.Text = "Create Train";
            this.BTTrain.UseVisualStyleBackColor = true;
            this.BTTrain.Click += new System.EventHandler(this.BTTrain_Click);
            // 
            // BTTicket
            // 
            this.BTTicket.Location = new System.Drawing.Point(12, 172);
            this.BTTicket.Name = "BTTicket";
            this.BTTicket.Size = new System.Drawing.Size(175, 23);
            this.BTTicket.TabIndex = 4;
            this.BTTicket.Text = "Create Ticket";
            this.BTTicket.UseVisualStyleBackColor = true;
            this.BTTicket.Click += new System.EventHandler(this.BTTicket_Click);
            // 
            // BTWay
            // 
            this.BTWay.Location = new System.Drawing.Point(12, 201);
            this.BTWay.Name = "BTWay";
            this.BTWay.Size = new System.Drawing.Size(175, 23);
            this.BTWay.TabIndex = 5;
            this.BTWay.Text = "Create Way";
            this.BTWay.UseVisualStyleBackColor = true;
            this.BTWay.Click += new System.EventHandler(this.BTWay_Click);
            // 
            // BTTimetable
            // 
            this.BTTimetable.Location = new System.Drawing.Point(12, 230);
            this.BTTimetable.Name = "BTTimetable";
            this.BTTimetable.Size = new System.Drawing.Size(175, 23);
            this.BTTimetable.TabIndex = 6;
            this.BTTimetable.Text = "Create Timetable";
            this.BTTimetable.UseVisualStyleBackColor = true;
            this.BTTimetable.Click += new System.EventHandler(this.BTTimetable_Click);
            // 
            // BTTimeTibleDrop
            // 
            this.BTTimeTibleDrop.Location = new System.Drawing.Point(368, 230);
            this.BTTimeTibleDrop.Name = "BTTimeTibleDrop";
            this.BTTimeTibleDrop.Size = new System.Drawing.Size(167, 23);
            this.BTTimeTibleDrop.TabIndex = 13;
            this.BTTimeTibleDrop.Text = "Drop Timetable";
            this.BTTimeTibleDrop.UseVisualStyleBackColor = true;
            this.BTTimeTibleDrop.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTWayDrop
            // 
            this.BTWayDrop.Location = new System.Drawing.Point(368, 201);
            this.BTWayDrop.Name = "BTWayDrop";
            this.BTWayDrop.Size = new System.Drawing.Size(167, 23);
            this.BTWayDrop.TabIndex = 12;
            this.BTWayDrop.Text = "Drop Way";
            this.BTWayDrop.UseVisualStyleBackColor = true;
            this.BTWayDrop.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTTikectDrop
            // 
            this.BTTikectDrop.Location = new System.Drawing.Point(368, 172);
            this.BTTikectDrop.Name = "BTTikectDrop";
            this.BTTikectDrop.Size = new System.Drawing.Size(167, 23);
            this.BTTikectDrop.TabIndex = 11;
            this.BTTikectDrop.Text = "Drop Ticket";
            this.BTTikectDrop.UseVisualStyleBackColor = true;
            this.BTTikectDrop.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTTrainDrop
            // 
            this.BTTrainDrop.Location = new System.Drawing.Point(368, 143);
            this.BTTrainDrop.Name = "BTTrainDrop";
            this.BTTrainDrop.Size = new System.Drawing.Size(167, 23);
            this.BTTrainDrop.TabIndex = 10;
            this.BTTrainDrop.Text = "Drop Train";
            this.BTTrainDrop.UseVisualStyleBackColor = true;
            this.BTTrainDrop.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTTrainComposition_drop
            // 
            this.BTTrainComposition_drop.Location = new System.Drawing.Point(368, 114);
            this.BTTrainComposition_drop.Name = "BTTrainComposition_drop";
            this.BTTrainComposition_drop.Size = new System.Drawing.Size(167, 23);
            this.BTTrainComposition_drop.TabIndex = 9;
            this.BTTrainComposition_drop.Text = "Drop train composition";
            this.BTTrainComposition_drop.UseVisualStyleBackColor = true;
            this.BTTrainComposition_drop.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTPath_Drop
            // 
            this.BTPath_Drop.Location = new System.Drawing.Point(368, 85);
            this.BTPath_Drop.Name = "BTPath_Drop";
            this.BTPath_Drop.Size = new System.Drawing.Size(167, 23);
            this.BTPath_Drop.TabIndex = 8;
            this.BTPath_Drop.Text = "Drop Path";
            this.BTPath_Drop.UseVisualStyleBackColor = true;
            this.BTPath_Drop.Click += new System.EventHandler(this.BTPath_Drop_Click);
            // 
            // BTStation_Drop
            // 
            this.BTStation_Drop.Location = new System.Drawing.Point(368, 56);
            this.BTStation_Drop.Name = "BTStation_Drop";
            this.BTStation_Drop.Size = new System.Drawing.Size(167, 23);
            this.BTStation_Drop.TabIndex = 7;
            this.BTStation_Drop.Text = "Drop Station";
            this.BTStation_Drop.UseVisualStyleBackColor = true;
            this.BTStation_Drop.Click += new System.EventHandler(this.BtStationDropClick);
            // 
            // BTOpenStation
            // 
            this.BTOpenStation.Location = new System.Drawing.Point(193, 56);
            this.BTOpenStation.Name = "BTOpenStation";
            this.BTOpenStation.Size = new System.Drawing.Size(169, 23);
            this.BTOpenStation.TabIndex = 14;
            this.BTOpenStation.Text = "Open Station";
            this.BTOpenStation.UseVisualStyleBackColor = true;
            this.BTOpenStation.Click += new System.EventHandler(this.BTOpenStation_Click);
            // 
            // BTOpenPath
            // 
            this.BTOpenPath.Location = new System.Drawing.Point(193, 85);
            this.BTOpenPath.Name = "BTOpenPath";
            this.BTOpenPath.Size = new System.Drawing.Size(169, 23);
            this.BTOpenPath.TabIndex = 15;
            this.BTOpenPath.Text = "Open Path";
            this.BTOpenPath.UseVisualStyleBackColor = true;
            this.BTOpenPath.Click += new System.EventHandler(this.BTOpenPath_Click);
            // 
            // BTOpenTrain_compsition
            // 
            this.BTOpenTrain_compsition.Location = new System.Drawing.Point(193, 114);
            this.BTOpenTrain_compsition.Name = "BTOpenTrain_compsition";
            this.BTOpenTrain_compsition.Size = new System.Drawing.Size(169, 23);
            this.BTOpenTrain_compsition.TabIndex = 16;
            this.BTOpenTrain_compsition.Text = "Open train compsition";
            this.BTOpenTrain_compsition.UseVisualStyleBackColor = true;
            this.BTOpenTrain_compsition.Click += new System.EventHandler(this.BTOpenTrain_compsition_Click);
            // 
            // BTOpenTrain
            // 
            this.BTOpenTrain.Location = new System.Drawing.Point(193, 143);
            this.BTOpenTrain.Name = "BTOpenTrain";
            this.BTOpenTrain.Size = new System.Drawing.Size(169, 23);
            this.BTOpenTrain.TabIndex = 17;
            this.BTOpenTrain.Text = "Open Train";
            this.BTOpenTrain.UseVisualStyleBackColor = true;
            this.BTOpenTrain.Click += new System.EventHandler(this.BTOpenTrain_Click);
            // 
            // BTOpenTicket
            // 
            this.BTOpenTicket.Location = new System.Drawing.Point(193, 172);
            this.BTOpenTicket.Name = "BTOpenTicket";
            this.BTOpenTicket.Size = new System.Drawing.Size(169, 23);
            this.BTOpenTicket.TabIndex = 18;
            this.BTOpenTicket.Text = "Open Ticket";
            this.BTOpenTicket.UseVisualStyleBackColor = true;
            this.BTOpenTicket.Click += new System.EventHandler(this.BTOpenTicket_Click);
            // 
            // BTOpenWay
            // 
            this.BTOpenWay.Location = new System.Drawing.Point(193, 201);
            this.BTOpenWay.Name = "BTOpenWay";
            this.BTOpenWay.Size = new System.Drawing.Size(169, 23);
            this.BTOpenWay.TabIndex = 19;
            this.BTOpenWay.Text = "Open way";
            this.BTOpenWay.UseVisualStyleBackColor = true;
            this.BTOpenWay.Click += new System.EventHandler(this.BTOpenWay_Click);
            // 
            // BTOpenTimetable
            // 
            this.BTOpenTimetable.Location = new System.Drawing.Point(193, 230);
            this.BTOpenTimetable.Name = "BTOpenTimetable";
            this.BTOpenTimetable.Size = new System.Drawing.Size(169, 23);
            this.BTOpenTimetable.TabIndex = 20;
            this.BTOpenTimetable.Text = "Open Timetable";
            this.BTOpenTimetable.UseVisualStyleBackColor = true;
            this.BTOpenTimetable.Click += new System.EventHandler(this.BTOpenTimetable_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.connectToolStripMenuItem.Text = "connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 269);
            this.Controls.Add(this.BTOpenTimetable);
            this.Controls.Add(this.BTOpenWay);
            this.Controls.Add(this.BTOpenTicket);
            this.Controls.Add(this.BTOpenTrain);
            this.Controls.Add(this.BTOpenTrain_compsition);
            this.Controls.Add(this.BTOpenPath);
            this.Controls.Add(this.BTOpenStation);
            this.Controls.Add(this.BTTimeTibleDrop);
            this.Controls.Add(this.BTWayDrop);
            this.Controls.Add(this.BTTikectDrop);
            this.Controls.Add(this.BTTrainDrop);
            this.Controls.Add(this.BTTrainComposition_drop);
            this.Controls.Add(this.BTPath_Drop);
            this.Controls.Add(this.BTStation_Drop);
            this.Controls.Add(this.BTTimetable);
            this.Controls.Add(this.BTWay);
            this.Controls.Add(this.BTTicket);
            this.Controls.Add(this.BTTrain);
            this.Controls.Add(this.BTTrain_composition);
            this.Controls.Add(this.BTPath);
            this.Controls.Add(this.BTStation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTStation;
        private System.Windows.Forms.Button BTPath;
        private System.Windows.Forms.Button BTTrain_composition;
        private System.Windows.Forms.Button BTTrain;
        private System.Windows.Forms.Button BTTicket;
        private System.Windows.Forms.Button BTWay;
        private System.Windows.Forms.Button BTTimetable;
        private System.Windows.Forms.Button BTTimeTibleDrop;
        private System.Windows.Forms.Button BTWayDrop;
        private System.Windows.Forms.Button BTTikectDrop;
        private System.Windows.Forms.Button BTTrainDrop;
        private System.Windows.Forms.Button BTTrainComposition_drop;
        private System.Windows.Forms.Button BTPath_Drop;
        private System.Windows.Forms.Button BTStation_Drop;
        private System.Windows.Forms.Button BTOpenStation;
        private System.Windows.Forms.Button BTOpenPath;
        private System.Windows.Forms.Button BTOpenTrain_compsition;
        private System.Windows.Forms.Button BTOpenTrain;
        private System.Windows.Forms.Button BTOpenTicket;
        private System.Windows.Forms.Button BTOpenWay;
        private System.Windows.Forms.Button BTOpenTimetable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
    }
}

