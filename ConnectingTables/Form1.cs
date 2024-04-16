using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectingTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connstr = "server=10.6.0.127;port=3306;"+
            "user=PC1;"+"password=1111;"+"database=trees_zaimov";

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            string insertSQL = "INSERT INTO trees_zaimov.class"+
                "(`name`,name_bg)"+
                "VALUES(@Edward, @Едуард)";
            MySqlCommand query = new MySqlCommand(insertSQL, conn);
            query.Parameters.AddWithValue("@Edward", textBox1.Text);
            query.Parameters.AddWithValue("@Едуард", textBox2.Text);
            query.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("qko dance!");

        }
    }
}
