using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colegiu
{
    public partial class FormUpdate : Form
    {
        static private string conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danac\OneDrive\Documents\College.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection c = new SqlConnection(conStr);
        static private string lastTable = "";
        static private string columnName = "";

        private void getIDColumn(string table_name)
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

        private void removeColumns(string table_name)
        {
            if (lastTable == "") return;
            string cmdstr = $"select COLUMN_NAME, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table_name}'";
            DataTable dt_names = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);
            try
            {
                sda.Fill(dt_names);
                for (int i = 0; i < dt_names.Rows.Count; i++)
                {
                    Control ct0 = this.Controls[dt_names.Rows[i][0].ToString()];
                    this.Controls.Remove(ct0);
                    Control ct1 = this.Controls[dt_names.Rows[i][0].ToString() + "_input"];
                    this.Controls.Remove(ct1);
                }
                lastTable = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void getColumns(string table_name)
        {
            string cmdstr = $"select COLUMN_NAME, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table_name}'";
            DataTable dt_names = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstr, conStr);
            int[] start_names = { 12, 71 };
            int[] start_inputs = { 12, 98 };
            try
            {
                sda.Fill(dt_names);
                for (int i = 0; i < dt_names.Rows.Count; i++)
                {
                    if (dt_names.Rows[i][0].ToString().Substring(0, 3) == "id_" && i == 0) continue;
                    Label l = new Label();
                    l.Name = dt_names.Rows[i][0].ToString();
                    l.Location = new Point(start_names[0], start_names[1]);
                    l.Size = new Size(106, 24);
                    l.Text = dt_names.Rows[i][0].ToString();
                    l.BackColor = Color.FromArgb(255, 192, 128);
                    l.BorderStyle = BorderStyle.FixedSingle;
                    l.ForeColor = Color.White;
                    l.Font = new Font("Times New Roman", 10, FontStyle.Bold);

                    TextBox tb = new TextBox();
                    tb.Size = new Size(106, 24);
                    tb.Name = dt_names.Rows[i][0].ToString() + "_input";
                    tb.Location = new Point(start_inputs[0], start_inputs[1]);

                    this.Controls.Add(l);
                    this.Controls.Add(tb);
                    if (start_names[0] + 200 < this.Size.Width)
                    {
                        start_names[0] += 134;
                        start_inputs[0] += 134;
                    }
                    else
                    {
                        start_names[0] = 12;
                        start_inputs[0] = 12;
                        start_names[1] += 62;
                        start_inputs[1] += 62;

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public FormUpdate()
        {
            InitializeComponent();
            getTables();
        }

        private void update_db_Click(object sender, EventArgs e)
        {
            string table_name = table_dropdown.Text;
            string cmdstrColumns = $"select COLUMN_NAME, DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{table_name}'";
            DataTable dt_names = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmdstrColumns, conStr);
            string cmdstr = $"update {table_name} set ";
            try
            {
                sda.Fill(dt_names);
                for (int i = 0; i < dt_names.Rows.Count; i++)
                {
                    if (dt_names.Rows[i][0].ToString().Substring(0, 3) == "id_" && i == 0) continue;
                    Control ct_value = this.Controls[dt_names.Rows[i][0].ToString() + "_input"];
                    Control ct_name = this.Controls[dt_names.Rows[i][0].ToString()];
                    if (ct_name != null && ct_value != null)
                    {
                        cmdstr += ct_name.Text.ToString() + "='" + ct_value.Text.ToString() + "' ";
                    }
                }
                cmdstr += $"where {columnName}={id_dropdown.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Debug.WriteLine(cmdstr);
            c.Open();
            SqlCommand update = new SqlCommand(cmdstr, c);
            try
            {
                update.ExecuteNonQuery();
                MessageBox.Show("Record updated");
                removeColumns(lastTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            c.Close();
        }

        private void table_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_dropdown.Items.Clear();
            removeColumns(lastTable);
            getColumns(table_dropdown.Text);
            lastTable = table_dropdown.Text;
            getIDColumn(table_dropdown.Text);
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
