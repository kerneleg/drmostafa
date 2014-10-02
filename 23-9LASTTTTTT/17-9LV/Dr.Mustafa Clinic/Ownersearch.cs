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
    public partial class Ownersearch : Form
    {
        owner_form client;
        DBConnection objConnect = new DBConnection();
        SqlCommand sCommand;
        SqlDataAdapter sAdapter;
        SqlCommandBuilder sBuilder;
        string conString;
        DataSet ds;
        DataTable sTable;
        string name;
        
        int fff;
        public Ownersearch(string temp_name,int ffffl)
        {
            InitializeComponent();
            name = temp_name;
            fff = ffffl;
            refresh();
        }
        void refresh()
        {
            if (name == "")
            {
                try
                {
                    if(fff==0)
                    {
                        conString = Dr.Mustafa_Clinic.ModifiedConnection.GlobalValue;
                    }
                    if (fff == 1)
                    {
                        conString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Ahmed\Kernel\k\Database2.mdf;Integrated Security=True";
                    }
                    objConnect.connection_string = conString;
                    string sql = "SELECT Customerid,Name,Mob,Unpaid FROM Customers";
                    SqlConnection con = new SqlConnection(conString);
                    con.Open();
                    sCommand = new SqlCommand(sql, con);
                    sAdapter = new SqlDataAdapter(sCommand);
                    sBuilder = new SqlCommandBuilder(sAdapter);
                    ds = new DataSet();
                    sAdapter.Fill(ds, "Customers");
                    sTable = ds.Tables["Customers"];
                    con.Close();
                    OwnSearchDatagrid.DataSource = sTable;
                    OwnSearchDatagrid.ReadOnly = true;
                    OwnSearchDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    OwnSearchDatagrid.Columns[1].Visible = false;

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                conString = ModifiedConnection.GlobalValue;
                objConnect.connection_string = conString;
                string sql = "SELECT Customerid,Name,Mob,Unpaid FROM Customers where Name LIKE + @test+ '%'  ";
                SqlConnection con = new SqlConnection(conString);
                con.Open();
                sCommand = new SqlCommand(sql, con);
                sCommand.Parameters.AddWithValue("@test", name);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                ds = new DataSet();
                sAdapter.Fill(ds, "Customers");
                sTable = ds.Tables["Customers"];
                con.Close();
                OwnSearchDatagrid.DataSource = sTable;
                OwnSearchDatagrid.ReadOnly = true;
                OwnSearchDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                OwnSearchDatagrid.Columns[1].Visible = false;
            }
            OwnSearchDatagrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OwnSearchDatagrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OwnSearchDatagrid.Columns[3].HeaderText = "Mobile Number";
            OwnSearchDatagrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OwnSearchDatagrid.Columns[4].HeaderText = "Unpaid Amount";
            OwnSearchDatagrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < OwnSearchDatagrid.Rows.Count - 1)
            {
                client = new owner_form(OwnSearchDatagrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                client.ShowDialog();
                refresh();
            }
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            try
            {
                conString = ModifiedConnection.GlobalValue;
                objConnect.connection_string = conString;
                string CNSearch = owner_filter.Text.ToString();
                string MobSearch = mob_filter.Text.ToString();
                StringBuilder Sqlquery = new StringBuilder();
                if (CNSearch != "")
                {
                    if (MobSearch != "")
                    {
                        if (unpaid.CheckState == CheckState.Unchecked)
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Name LIKE + @CNSearch + '%' and Mob LIKE + @MobSearch + '%' ");
                        }
                        else
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Name LIKE + @CNSearch + '%' and Mob LIKE + @MobSearch + '%' and Unpaid > 0 ");
                        }
                    }
                    if (MobSearch == "")
                    {
                        if (unpaid.CheckState == CheckState.Unchecked)
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Name LIKE + @CNSearch + '%' ");
                        }
                        else
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Name LIKE + @CNSearch + '%' and Unpaid > 0 ");
                        }
                    }
                }

                if (CNSearch == "")
                {
                    if (MobSearch == "")
                    {

                        if (unpaid.CheckState == CheckState.Unchecked)
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers");
                        }
                        else
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Unpaid > 0 ");
                        }
                    }
                    else
                    {
                        if (unpaid.CheckState == CheckState.Unchecked)
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Mob LIKE + @MobSearch + '%' ");
                        }
                        else
                        {
                            Sqlquery.Append("SELECT Customerid,Name,Mob,Unpaid FROM Customers WHERE Mob LIKE + @MobSearch + '%' and Unpaid > 0 ");
                        }                       
                    }
                }


                SqlConnection con = new SqlConnection(conString);
                con.Open();
                sCommand = new SqlCommand(Sqlquery.ToString(), con);
                sCommand.Parameters.AddWithValue("@MobSearch", MobSearch);
                sCommand.Parameters.AddWithValue("@CNSearch", CNSearch);
                sAdapter = new SqlDataAdapter(sCommand);
                sBuilder = new SqlCommandBuilder(sAdapter);
                ds = new DataSet();
                sAdapter.Fill(ds, "Customers");
                sTable = ds.Tables["Customers"];
                con.Close();
                OwnSearchDatagrid.DataSource = sTable;
                OwnSearchDatagrid.ReadOnly = true;
                OwnSearchDatagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

         
        } 
    }

