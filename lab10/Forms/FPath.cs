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
    public partial class FPath : Form
    {
        DBManager dbManager;
        public FPath()
        {
            InitializeComponent();
            dbManager =  DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        struct way_info
        {
            public int code_;
            public string name_;
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "Way_", "Station_", "number_", "time_arival_", "time_departure_" };
            //string[] values =
            //{
            //    TBWay.Text, TBStation.Text, "'" + TBNumber.Text + "'","'"+TBTimeArival.Text+"'" ,
            //    "'"+TBTimeDeparture.Text+"'"

            //};
            //dbManager.insert("Path_", fields, values);
            //dbManager.selectAll("Path_", dataGridView1);
        }

        private void FPath_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Path_", dataGridView1);
            var way_ = dbManager.selectAll("way");
            for (int i = 0; i < way_.Count; i++)
            {
                way_info tmp = new way_info();
                tmp.code_ = Convert.ToInt32( way_[i][0].ToString());
                tmp.name_ = way_[i][1].ToString();
                comboBox1.Items.Add(tmp);
                comboBox1.Text = tmp.name_;


            }
        }

        private void BTDetele_Click(object sender, EventArgs e)
        {
            //dbManager.delete("Path_","Way_="+TBWay.Text);
            dbManager.selectAll("Path_", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //TBWay.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            //TBStation.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBTimeArival.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TBTimeDeparture.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            //dbManager.ExecSQL("UPDATE Path_ SET Way_=" + TBWay.Text +
            //                  ", Station_=" + TBStation.Text + ", number_=" + TBNumber.Text + ", time_arival_="
            //                  + TBTimeArival.Text + ", time_departure_=" + TBTimeDeparture.Text);
            //dbManager.selectAll("Path_", dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Text = ((way_info)comboBox1.SelectedItem).name_;
        }
    }
}
