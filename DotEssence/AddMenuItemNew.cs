using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DotEssence
{
    public partial class AddMenuItemNew : Form
    {
        

        public AddMenuItemNew()
        {
            InitializeComponent();
        }

        private void AddMenuItemNew_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "Select * from CategoryTbl Order By Name";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    cboxCategory.Items.Add(dr[1].ToString());


                }

            }
            cn.Close();
          

        }

        private void cboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                txtboxItemName.Text = listBox1.SelectedItem.ToString();
                cBoxItemCategory.Text = cboxCategory.SelectedItem.ToString();
                ckboxQuickItem.Checked = true;
            }

        }

        private void clearfields()
        {
            txtboxItemName.Text = "";

            cBoxItemCategory.Text = "";
            


        }



        private void loadlist()
        {
            listBox1.Items.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cn.Open();
            
            cmd.CommandText = "Select * from CategoryTbl where name='"+cboxCategory.Text.ToString()+"'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                    int newint = dr.GetInt32(0);
                   
                        
                    
                    
                    SqlConnection cnn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
                    SqlCommand cmdd = new SqlCommand();
                    SqlDataReader ddr;
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.CommandText = "select * from MenuItemTbl INNER JOIN CategoryTbl ON CategoryTbl.Id = MenuItemTbl.ItemCategory WHERE (CategoryTbl.Id ='" + newint + "')  Order by MenuItemTbl.ItemName";
                    
                    
                    ddr = cmd.ExecuteReader();
                    if (ddr.HasRows)
                    {
                        while (ddr.Read())
                        {
                            if (ddr[0] != null)
                            {
                                listBox1.Items.Add(ddr[1].ToString());
                            }
                        }
                    }
                    

                }

            }
            cn.Close();

        }

        private void cboxCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cboxCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cn.Open();

            cmd.CommandText = "Select * from CategoryTbl where name='" + cboxCategory.Text.ToString() + "'";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    int newint = dr.GetInt32(0);


                    

                    SqlConnection cnn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
                    SqlCommand cmdd = new SqlCommand();
                    SqlDataReader ddr;
                    cmd.Connection = cnn;
                    cnn.Open();
                    cmd.CommandText = "select ItemName from CategoryTbl INNER JOIN MenuItemTbl ON CategoryTbl.Id = MenuItemTbl.ItemCategory WHERE (CategoryTbl.Id ='" + newint + "') Order by MenuItemTbl.ItemName";


                    ddr = cmd.ExecuteReader();
                    if (ddr.HasRows)
                    {
                        while (ddr.Read())
                        {
                            if (ddr[0] != null)
                            {
                                listBox1.Items.Add(ddr[0].ToString());
                            }
                        }
                    }


                }

            }
            cn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cn.Open();
            if (txtboxItemName.Text != "")
            {
                cmd.Connection = cn;
                
                cmd.CommandText = "delete from MenuItemTbl where ItemName = '" + txtboxItemName.Text + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(listBox1.SelectedItem + "deleted");
                clearfields();
                loadlist();
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
     
    }
}
