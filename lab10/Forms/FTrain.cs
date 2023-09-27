using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class FTrain : Form
    {
        DBManager dbManager;
        public FTrain()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FTrain_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Train", dataGridView1);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Train", "train_number_=" + TBTrainNumber.Text);
            dbManager.selectAll("Train", dataGridView1);
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "train_number_", "type_" };
            string[] values = { TBTrainNumber.Text, "'" + TBType.Text+"'"};
            dbManager.insert("Train", fields, values);
            dbManager.selectAll("Train", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBTrainNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
