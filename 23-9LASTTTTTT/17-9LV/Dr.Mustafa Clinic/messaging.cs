using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Dr.Mustafa_Clinic
{
    public partial class messaging : Form
    {
        backend send;
        string conString;
        String query;     
        SqlConnection con;
        SqlCommand command;
        contacts add;
        DataSet ds;
        DataTable custTable;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        List<string> numbers;
        public messaging()
        {
            InitializeComponent();
            conString = ModifiedConnection.GlobalValue;
            textBox1.Enabled = false;
            numbers = new List<string>();
            con = new SqlConnection(conString);
            con.Open();
            query = "select Name,Mob from Customers";
            command = new SqlCommand(query, con);
            sAdapter = new SqlDataAdapter(command);
            sBuilder = new SqlCommandBuilder(sAdapter);
            ds = new DataSet();
            sAdapter.Fill(ds, "Cust");
            custTable = ds.Tables["Cust"];
            dataGridView1.DataSource = custTable;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            add = new contacts();
            add.ShowDialog();
            if (add.number != null)
            {
                textBox1.AppendText(add.number);
                textBox1.AppendText(",");
                numbers.Add(add.number);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int i;
            if (checkBox1.CheckState == CheckState.Checked)
            {
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = CheckState.Checked;
                    checkBox1.Text = "UnSelect All Rows";
                }
            }
            else
            {
                for (i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = CheckState.Unchecked;
                    checkBox1.Text = "Select All Rows";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    string x = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    numbers.Add(x);
                }
            }
            send = new backend(numbers);
        }
    }
}
