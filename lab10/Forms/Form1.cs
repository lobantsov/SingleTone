using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab10.Class;
using static System.Collections.Specialized.BitVector32;

namespace lab10
{
    public partial class Form1 : Form
    {
        private DBManager d;
        private Logger logger;
        public Form1()
        {
            InitializeComponent();
            d = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            logger = Logger.GetInstance("log");

            // d.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void BTStation_Click(object sender, EventArgs e)
        {
            if (!d.Exist("crucio","Station"))
            {
                string[] fields = { "code_", "name_", "type_" };
                string[] types = { "int not null primary key", "varchar(40)", "varchar(10)" };
                d.CreateTable("Station", fields, types);
                BTStation_Drop.Enabled = true;
                BTStation.Enabled = false;
                BTOpenStation.Enabled = true;
            }
            FStation f = new FStation();
            if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
        }

        private void BTPath_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Station") && d.Exist("crucio", "Way"))
            {
                if (!d.Exist("crucio", "Path_"))
                {
                    string[] fields = { "Way_", "Station_", "number_", "time_arival_", "time_departure_" };
                    string[] types = { "int not null", "int not null", "TINYINT", "TIME", "TIME" };
                    string[] fieldName = { "Way_", "Station_" };
                    string[] tableName = { "Way", "Station" };
                    string[] referenceFieldName = { "code_", "code_" };
                    string FK = d.CreateForenKey(fieldName, tableName, referenceFieldName);
                    d.CreateTable("Path_", fields, types, FK);
                    BTPath_Drop.Enabled = true;
                    BTPath.Enabled = false;
                    BTOpenPath.Enabled = true;
                }
                FPath f = new FPath();
                if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
            }
            else
            { 
                MessageBox.Show("linked tables are not created");
            }
        }

        private void BTWay_Click(object sender, EventArgs e)
        {
            if (!d.Exist("crucio", "Way"))
            {
                string[] fields = { "code_", "name_" };
                string[] types = { "int not null primary key", "varchar(60)" };
                d.CreateTable("Way", fields, types);
                BTWayDrop.Enabled = true;
                BTWay.Enabled = false;
                BTOpenWay.Enabled = true;
            }
            FWay f = new FWay();
            if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
        }

        private void BTTicket_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Station") && d.Exist("crucio", "Timetable"))
            {
                if (!d.Exist("crucio", "Ticket"))
                {
                    string[] fields = { "code_", "from_", "where_", "timetable_" };
                    string[] types = { "int not null primary key", "int not null", "int not null", "int not null" };
                    string[] fieldName = { "from_", "where_", "timetable_" };
                    string[] tableName = { "Station", "Station", "timetable" };
                    string[] referenceFieldName = { "code_", "code_", "code_" };
                    string FK = d.CreateForenKey(fieldName, tableName, referenceFieldName);
                    d.CreateTable("Ticket", fields, types, FK);
                    BTTikectDrop.Enabled = true;
                    BTTicket.Enabled = false;
                    BTOpenTicket.Enabled = true;
                }
                FTicket f = new FTicket();
                if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
            }
            else
            {
                MessageBox.Show("linked tables are not created");
            }
        }

        private void BTTrain_composition_Click(object sender, EventArgs e)
        {
            if (!d.Exist("crucio", "Train_composition"))
            {
                string[] fields = { "train_", "vagon_", "type_vagon_", "seets_" };
                string[] types = { "int not null primary key", "TINYINT", "CHAR(9)", "TINYINT" };
                d.CreateTable("Train_composition", fields, types);
                BTTrainComposition_drop.Enabled = true;
                BTTrain_composition.Enabled = false;
                BTOpenTrain_compsition.Enabled = true;
            }

            FTrain_composition f = new FTrain_composition();
            if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
        }

        private void BTTrain_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Train_composition"))
            {
                if (!d.Exist("crucio", "Train"))
                {
                    string[] fields = { "train_number_", "type_" };
                    string[] types = { "int not null", "char(10)" };
                    d.CreateTable("Train", fields, types, d.CreateForenKey("train_number_", "Train_composition", "train_"));
                    BTTrainDrop.Enabled = true;
                    BTTrain.Enabled = false;
                    BTOpenTrain.Enabled = true;
                }
                FTrain f = new FTrain();
                if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
            }
            else
            {
                MessageBox.Show("linked tables are not created");
            }
        }

        private void BTTimetable_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Way")&&d.Exist("crucio", "Station")&&d.Exist("crucio", "Train"))
            {
                if (!d.Exist("crucio", "Timetable"))
                {

                    string[] fields =
                    {
                        "code_", "data_", "way_", "station_", "train_number_", "railway",
                        "arival_time", "departure_time"
                    };
                    string[] types =
                    {
                        "int not null primary key", "time", "int not null", "int not null", "int not null",
                        "TINYINT", "time", "time"
                    };
                    string[] fieldName = { "way_", "station_", "train_number_" };
                    string[] tableName = { "Way", "Station", "Train" };
                    string[] referenceFieldName = { "code_", "code_", "train_number_" };
                    string FK = d.CreateForenKey(fieldName, tableName, referenceFieldName);
                    d.CreateTable("Timetable", fields, types, FK);
                    BTTimeTibleDrop.Enabled = true;
                    BTTimetable.Enabled = false;
                    BTOpenTimetable.Enabled = true;
                }
                FTimeTable f = new FTimeTable();
                if (f.DialogResult == DialogResult.OK || f.DialogResult == DialogResult.Cancel);
            }
            else
            {
                MessageBox.Show("linked tables are not created");
            }
        }

        private void BtStationDropClick(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Station")&&!d.Exist("crucio", "Path_")
                                            && !d.Exist("crucio", "Timetable")
                                             && !d.Exist("crucio", "Ticket"))
            {
                d.DropTable("Station");
                MessageBox.Show("Station droped");
                BTStation_Drop.Enabled = false;
                BTStation.Enabled = true;
                BTOpenStation.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Way")&& !d.Exist("crucio", "Path_") &&
                !d.Exist("crucio", "Timetable"))
            {
                d.DropTable("Way");
                MessageBox.Show("Way droped");
                BTWayDrop.Enabled = false;
                BTWay.Enabled = true;
                BTOpenWay.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void BTPath_Drop_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Path_"))
            {
                d.DeleteAllFK("crucio","Path_");
                d.DropTable("Path_");
                MessageBox.Show("Path_ droped");
                BTPath_Drop.Enabled = false;
                BTPath.Enabled = true;
                BTOpenPath.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Train_composition") && 
                !d.Exist("crucio", "Train"))
            {
                d.DropTable("Train_composition");
                MessageBox.Show("Train_composition droped");
                BTTrainComposition_drop.Enabled = false;
                BTTrain_composition.Enabled = true;
                BTOpenTrain_compsition.Enabled= false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Train")&&
                !d.Exist("crucio", "Timetable"))
            {
                d.DropTable("Train");
                MessageBox.Show("Train droped");
                BTTrainDrop.Enabled = false;
                BTTrain.Enabled = true;
                BTOpenTrain.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Ticket"))
            {
                d.DropTable("Ticket");
                MessageBox.Show("Ticket droped");
                BTTikectDrop.Enabled = false;
                BTTicket.Enabled = true;
                BTOpenTicket.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Timetable") &&
                !d.Exist("crucio", "Train"))
            {
                d.DropTable("Timetable");
                MessageBox.Show("Timetable droped");
                BTTimeTibleDrop.Enabled = false;
                BTTimetable.Enabled = true;
                BTOpenTimetable.Enabled = false;
            }
            else
            {
                MessageBox.Show("there is a relationship with the table");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (d.Exist("crucio", "Station"))
            {
                BTStation.Enabled = false;
                BTStation_Drop.Enabled = true;
                BTOpenStation.Enabled = true;
            }
            else
            {
                BTStation.Enabled = true;
                BTStation_Drop.Enabled = false;
                BTOpenStation.Enabled = false;
            }

            if (d.Exist("crucio", "Path_"))
            {
                BTPath.Enabled=false;
                BTPath_Drop.Enabled=true;
                BTOpenPath.Enabled=true;
            }
            else
            {
                BTPath.Enabled=true;
                BTPath_Drop.Enabled=false;
                BTOpenPath.Enabled = false;
            }

            if (d.Exist("crucio", "Train_composition"))
            {
                BTTrain_composition.Enabled=false;
                BTTrainComposition_drop.Enabled=true;
                BTOpenTrain_compsition.Enabled=true;
            }
            else
            {
                BTTrain_composition.Enabled = true;
                BTTrainComposition_drop.Enabled = false;
                BTOpenTrain_compsition.Enabled=false;
            }

            if (d.Exist("crucio", "Train"))
            {
                BTTrain.Enabled=false;
                BTTrainDrop.Enabled=true;
                BTOpenTrain.Enabled=true;
            }
            else
            {
                BTTrain.Enabled = true;
                BTTrainDrop.Enabled = false;
                BTOpenTrain.Enabled=false;
            }

            if (d.Exist("crucio", "Ticket"))
            {
                BTTicket.Enabled=false;
                BTTikectDrop.Enabled=true;
                BTOpenTicket.Enabled=true;
            }
            else
            {
                BTTicket.Enabled = true;
                BTTikectDrop.Enabled = false;
                BTOpenTicket.Enabled= false;
            }

            if (d.Exist("crucio", "Way"))
            {
                BTWay.Enabled=false;
                BTWayDrop.Enabled=true;
                BTOpenWay.Enabled=true;
            }
            else
            {
                BTWay.Enabled = true;
                BTWayDrop.Enabled = false;
                BTOpenWay.Enabled=false;
            }

            if (d.Exist("crucio", "Timetable"))
            {
                BTTimetable.Enabled=false;
                BTTimeTibleDrop.Enabled=true;
                BTOpenTimetable.Enabled=true;
            }
            else
            {
                BTTimetable.Enabled = true;
                BTTimeTibleDrop.Enabled = false;
                BTOpenTimetable.Enabled= false;
            }
        }

        private void BTOpenStation_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open station");
            logger.Save();
            FStation f = new FStation();
            f.ShowDialog();
        }

        private void BTOpenPath_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open path");
            logger.Save();
            FPath f = new FPath();
            f.ShowDialog();
        }

        private void BTOpenTrain_compsition_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open Train_compsition");
            logger.Save();
            FTrain_composition f = new FTrain_composition();
            f.ShowDialog();
        }

        private void BTOpenTrain_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open Train");
            logger.Save();
            FTrain f = new FTrain();
            f.ShowDialog();
        }

        private void BTOpenTicket_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open Ticket");
            logger.Save();
            FTicket f = new FTicket();
            f.ShowDialog();
        }

        private void BTOpenWay_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open Way");
            logger.Save();
            FWay f = new FWay();
            f.ShowDialog();
        }

        private void BTOpenTimetable_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open TimeTable");
            logger.Save();
            FTimeTable f = new FTimeTable();
            f.ShowDialog();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logger.AddLogg("Open connectTool");
            logger.Save();
            FConectcs f = new FConectcs();
            f.ShowDialog();
        }
    }
}
