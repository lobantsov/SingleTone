using lab10.Class;
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
    public partial class FStation : Form
    {
        DBManager dbManager;
        private Logger logger;
        public FStation()
        {
            InitializeComponent();
            dbManager = DBManager.getInstance(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
            logger = Logger.GetInstance("log");
            //dbManager.ConnectTo(@"Server=localhost;Database=crucio;Uid=root;Pwd=1234");
        }

        private void FStation_Load(object sender, EventArgs e)
        {
            dbManager.selectAll("Station",dataGridView1);
            logger.AddLogg("Station table was loaded");
        }

        private void BTDelete_Click(object sender, EventArgs e)
        {
            dbManager.delete("Station","code_="+TBCode.Text);
            dbManager.selectAll("Station", dataGridView1);
            logger.AddLogg("Delete station row");
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            string[] fields={"code_","name_","type_"};
            string[] values={TBCode.Text,"'"+TBName.Text+"'","'"+TBType.Text+"'"};
            dbManager.insert("Station",fields,values);
            dbManager.selectAll("Station",dataGridView1);
            logger.AddLogg("Insert inf in Station table");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TBCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TBName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TBType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            logger.AddLogg("Change position of grid position to "+e.RowIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbManager.ExecSQL("UPDATE Station SET code_=" + TBCode.Text + 
                              ", name_=" + TBName.Text + ", type_=" + TBType.Text);
            dbManager.selectAll("Station", dataGridView1);
        }

        private void FStation_FormClosed(object sender, FormClosedEventArgs e)
        {
            logger.AddLogg("Close Station");
            logger.Save();
        }
    }
}
