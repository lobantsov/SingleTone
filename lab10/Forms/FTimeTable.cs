using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab10
{
    public partial class FTimeTable : Form
    {
        DBManager dbManager;
        public FTimeTable()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FTimeTable_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Timetable", dataGridView1);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Timetable", "code_=" + TBCode.Text);
            dbManager.selectAll("Timetable", dataGridView1);
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "code_", "data_", "way_", "station_", "train_number_", "railway", "arival_time", "departure_time" };
            string[] values =
            {
                TBCode.Text, TBData.Text,TBWay.Text,TBStation.Text,
                TBTrainNumber.Text,TBRailway.Text,TBArivalTime.Text,TBDepartureTime.Text
            };
            dbManager.insert("Ticket", fields, values);
            dbManager.selectAll("Ticket", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBData.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBWay.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBStation.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBTrainNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            TBRailway.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            TBArivalTime.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            TBDepartureTime.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            dbManager.ExecSQL("UPDATE Timetable SET code_=" + TBCode.Text +
                              ", data_=" + TBData.Text + ", way_=" + TBWay.Text+ ", station_="+TBStation.Text+
                              ", train_number_="+TBTrainNumber.Text+ ", railway="+TBRailway.Text+
                              ", arival_time="+TBArivalTime.Text+ ", departure_time="+TBDepartureTime.Text);
            dbManager.selectAll("Timetable", dataGridView1);
        }
    }
}
