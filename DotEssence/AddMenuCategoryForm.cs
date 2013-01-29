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
    public partial class AddMenuCategoryForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        


        public AddMenuCategoryForm()
        {
            InitializeComponent();
            cmd.Connection = cn;
            LoadList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtboxcategoryName.Text != "" & txtboxcategoryRank.Text != "")
            {
                
                int myint;
                myint = Convert.ToInt32(txtboxcategoryRank.Text);
                cn.Open();
                cmd.CommandText = "insert into CategoryTbl(Name,Rank) values ('"+txtboxcategoryName.Text+"','"+myint+"')";
                cmd.Connection = cn;
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Record Inserted");
                txtboxcategoryName.Text = "";
                txtboxcategoryRank.Text = "";
                cn.Close();
                LoadList();
                
          
            
            }
            
                       

        }
        private void LoadList()
        {
            
            listboxCatName.Items.Clear();
            listBoxCatRank.Items.Clear();
            cn.Open();
            cmd.CommandText = "Select * from CategoryTbl";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listboxCatName.Items.Add(dr[1].ToString());
                    listBoxCatRank.Items.Add(dr[2].ToString());


                }
                
            }
            cn.Close();
        }
        private void AddMenuCategoryForm_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        cmd.Connection = cn;
            cn.Open();
                cmd.CommandText = "select * from CategoryTbl";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string mystring;
                    mystring = Convert.ToString(dr[1]);
                    txtboxcategoryName.Text = mystring;

                }
                
            }
            cn.Close();
        }

        private void listBoxCatRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox CatName= sender as ListBox;
            if(CatName.SelectedIndex!= -1)
            {
                listboxCatName.SelectedIndex=CatName.SelectedIndex;
                listBoxCatRank.SelectedIndex = listBoxCatRank.SelectedIndex;
                txtboxcategoryName.Text = listboxCatName.SelectedItem.ToString();
                

            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            if (txtboxcategoryName.Text != "")
            {
                cn.Open();
                cmd.CommandText = "delete from CategoryTbl where Name = '" + txtboxcategoryName.Text + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(listboxCatName.SelectedItem + "deleted");
                LoadList();


            }
        }
    }
}
