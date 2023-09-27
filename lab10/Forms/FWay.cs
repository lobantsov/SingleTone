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

namespace lab10
{
    public partial class FWay : Form
    {
        DBManager dbManager;
        public FWay()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
           // dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FWay_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Way", dataGridView1);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Way", "code_=" + TBCode.Text);
            dbManager.selectAll("Way", dataGridView1);
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "code_", "name_" };
            string[] values = { TBCode.Text, "'" + TBName.Text + "'"};
            dbManager.insert("Way", fields, values);
            dbManager.selectAll("Way", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            dbManager.ExecSQL("UPDATE Way SET code_=" + TBCode.Text +
                              ", name_=" + TBName.Text);
            dbManager.selectAll("Way", dataGridView1);
        }
    }
}
