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
    public partial class FTicket : Form
    {
        DBManager dbManager;
        public FTicket()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FTicket_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Ticket", dataGridView1);
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Ticket", "code_=" + TBCode.Text);
            dbManager.selectAll("Ticket", dataGridView1);
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields = { "code_", "from_", "where_", "timetable_" };
            string[] values = { TBCode.Text, "'" + TBFrom.Text + "'", "'" + TBWhere.Text + "'","'"+TBTimeTable.Text+"'" };
            dbManager.insert("Ticket", fields, values);
            dbManager.selectAll("Ticket", dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBFrom.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBWhere.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TBTimeTable.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void BTEdit_Click(object sender, EventArgs e)
        {
            dbManager.ExecSQL("UPDATE Ticket SET code_=" + TBCode.Text +
                              ", from_=" + TBFrom.Text + ", where_=" + TBWhere.Text+ ", timetable_="+TBTimeTable.Text);
            dbManager.selectAll("Ticket", dataGridView1);
        }
    }
}
