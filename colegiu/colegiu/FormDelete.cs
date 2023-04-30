using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegiu
{
    public partial class FormDelete : Form
    {
        static private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danac\OneDrive\Documents\College.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection c = new SqlConnection(conStr);

        static private string columnName = "";

        private void getColumns(string table_name)
        {
            string cmdstr = $"select COLUMN_NAME from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table_name}'";
            DataTable dt_names = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);
            try
            {
                sda.Fill(dt_names);
                columnName = dt_names.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getIds(table_name);
        }
        private void getIds(string table_name)
        {
            string cmdstr = $"select {columnName} from {table_name}";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);
            try
            {
                sda.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    id_dropdown.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public FormDelete()
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
        private void delete_db_Click(object sender, EventArgs e)
        {
            c.Open();
            string table = table_dropdown.Text;
            SqlCommand delete = new SqlCommand($"delete from {table} where {columnName} = {id_dropdown.Text}", c);
            delete.ExecuteNonQuery();
            MessageBox.Show("Record deleted");
            c.Close();
        }

        private void table_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_dropdown.Items.Clear();
            getColumns(table_dropdown.Text);
        }

        private void id_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_dropdown.Text == "")
                MessageBox.Show("Alegeti id dorit");

            string table = table_dropdown.Text;
            SqlCommand read = new SqlCommand($"select * from {table} where {columnName} = {id_dropdown.Text}", c);
            SqlDataAdapter sda = new SqlDataAdapter(read);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dgv.DataSource = dt;
        }
    }
}
