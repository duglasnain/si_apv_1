using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace colegiu
{
    public partial class FormRead : Form
    {
        static private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danac\OneDrive\Documents\College.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection c = new SqlConnection(conStr);
        public FormRead()
        {
            InitializeComponent();
            getTables();
        }

        private void getTables()
        {
            string cmdstr = "select * from sys.tables";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);

            try
            {
                sda.Fill(dt);
                foreach (DataRow row in dt.Rows)
                {
                    table_dropdown.Items.Add(row["name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void read_db_Click(object sender, EventArgs e)
        {
            if (table_dropdown.Text == "")
                MessageBox.Show("Alegeti tabelul dorit");

            string table = table_dropdown.Text;
            SqlCommand read = new SqlCommand($"select * from {table}", c);
            SqlDataAdapter sda = new SqlDataAdapter(read);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv.DataSource = dt;
            MessageBox.Show($"Here are all records for table {table}");
        }
    }
}
