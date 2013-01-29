using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSaleClassLibrary;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;


namespace DotEssence
{
    public partial class FormMain : Form
    {
        public FormMain()
        {

            

            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

            // TODO: This line of code loads data into the 'database1DataSet.CategoryTbl' table. You can move, or remove it, as needed.
            this.categoryTblTableAdapter.Fill(this.database1DataSet.CategoryTbl);
            // TODO: This line of code loads data into the 'database1DataSet.MenuItemTbl' table. You can move, or remove it, as needed.
            this.menuItemTblTableAdapter.Fill(this.database1DataSet.MenuItemTbl);
            
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

                    string name = dr.GetString(1);
                    

                }
                cn.Close();
                
            }


            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMenuItemForm additemform = new AddMenuItemForm();
            additemform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMenuCategoryForm addcategoryform = new AddMenuCategoryForm();
            addcategoryform.Show();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        } 
        private void loadlist(object sender, EventArgs e)
        {
            

            
           



           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddMenuItemNew loginformstart = new AddMenuItemNew();
            loginformstart.Show();

            loginformstart.BringToFront();

        }
    }
}
