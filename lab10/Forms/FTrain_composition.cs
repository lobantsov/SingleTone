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
    public partial class FTrain_composition : Form
    {
        DBManager dbManager;
        public FTrain_composition()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FTrain_composition_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Train_composition", dataGridView1);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Train_composition", "train_=" + TBTrain.Text);
            dbManager.selectAll("Train_composition", dataGridView1);
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "train_", "vagon_", "type_vagon_", "seets_" };
            string[] values = { TBTrain.Text, TBVagon.Text, "'" + TBTypeVagon.Text + "'",TBSeets.Text};
            dbManager.insert("Train_composition", fields, values);
            dbManager.selectAll("Train_composition", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBTrain.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBVagon.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBTypeVagon.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBSeets.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            dbManager.ExecSQL("UPDATE Train_composition SET train_=" + TBTrain.Text +
                              ", vagon_=" + TBVagon.Text + ", type_vagon_=" + TBTypeVagon.Text+
                              ", seets_="+TBSeets.Text);
            dbManager.selectAll("Train_composition", dataGridView1);
        }
    }
}
