using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Newtonsoft.Json;

namespace lab10
{
    public partial class FConectcs : Form
    {
        private DBManager db;

        public FConectcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //@"Server=localhost;Database=crucio;Uid=root;Pwd=1234";
            DBManager.deleteInstance();
            string conStr="";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = File.OpenText(openFileDialog1.FileName))
                {
                    var fileText = reader.ReadToEnd();
                     conStr = JsonConvert.DeserializeObject<string>(fileText);
                }
            }
            db = DBManager.getInstance(conStr);
            if (db.CheckConnection())
            {
                db.selectAll("INFORMATION_SCHEMA.TABLES", dataGridView1);
                BTCreate.Enabled=true;
                CBFilter.Enabled=true;
            }
            else MessageBox.Show("Failed connection");
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBFilter.Checked)
                db.Select(@"SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'", dataGridView1);
            else
                db.selectAll("INFORMATION_SCHEMA.TABLES", dataGridView1);
        }

        private void BTTest_Connection_Click(object sender, EventArgs e)
        {
            if (db == null)
            {
                MessageBox.Show("Failed connection");
                return;
            }

            if (db.CheckConnection()) MessageBox.Show("Test successfully");
            else MessageBox.Show("Failed connection");
        }

        private void BTCreate_Connection_Click(object sender, EventArgs e)
        {
            string conStr = (@"Server=" + textBox1.Text + ";Database=" + textBox2.Text + ";Uid=" +
                             textBox3.Text + ";Pwd=" + textBox4.Text);
            saveFileDialog1.Filter = "JSON (*.json)|";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = File.CreateText($"{saveFileDialog1.FileName}.json"))
                {
                    string output = JsonConvert.SerializeObject(conStr);
                    writer.Write(output);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] fields = { "code_", "name_", "type_" };
            string[] types = { "int not null primary key", "varchar(40)", "varchar(10)" };
            db.CreateTable("Lobantsov", fields, types);
            BTCreate.Enabled=false;
            CBSwitcher.Enabled = true;
            BTDrop_Table.Enabled = true;
        }

        private void BTDrop_Table_Click(object sender, EventArgs e)
        {
            db.DropTable("Lobantsov");
            BTCreate.Enabled = true;
            BTDrop_Table.Enabled = false;
            CBSwitcher.Checked= false;
            CBSwitcher.Enabled=false;
        }

        private void CBSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            if (CBSwitcher.Checked)
            {
                db.Select(@"SELECT * FROM Lobantsov", dataGridView1);
                CBFilter.Enabled = false;
            }
            else
            {
                db.Select(@"SELECT * FROM INFORMATION_SCHEMA.TABLES", dataGridView1);
                CBFilter.Enabled=true;
            }
        }

        private void BTInsert_Click(object sender, EventArgs e)
        {
            db.ExecSQL("INSERT INTO `Lobantsov` VALUES (1,'Київ-пасажирський','вокзал'),(2,'Львів','вокзал'),(3,'Дарницький','вокзал'),(4,'Коростень','вокзал'),(5,'Підземне','вокзал'),(6,'Звегель1','платформа'),(7,'Шепетівка','вокзал'),(8,'Кривин','плаформа'),(9,'Бороди','платформа'),(10,'Ходорів','вокзал'),(11,'Івано-Франківськ','вокзал'),(12,'Дарниця','вокзал'),(13,'Моргород','платформа'),(14,'Полтава Київська','вокзал'),(15,'Харків-пас','вокзал')");
        }
    }
}
