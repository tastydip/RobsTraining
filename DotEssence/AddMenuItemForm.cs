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
    public partial class AddMenuItemForm : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public AddMenuItemForm()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            LoadList();
        }
        private void LoadList()
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = "Select * from MenuItemTbl";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int newint = dr.GetInt32(2);
                    listBox1.Items.Add(dr[1].ToString());
                    listBox2.Items.Add(newint.ToString());



                }

            }
            cn.Close();
        }
        private void AddMenuItemForm_Load(object sender, EventArgs e)
        {

            comboboxMenuCategory.Text = "";
            SqlConnection cn = new SqlConnection(@"Data Source=MOBILE-DEMON\SQLEXPRESS;Initial Catalog=Database1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = cn;
            cn.Open();
            cmd.CommandText = "select Name from CategoryTbl";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {

                    comboboxMenuCategory.Items.Add(dr[0].ToString());



                }
                cn.Close();
                dr.Dispose();
            }

        }

        private void comboboxMenuCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblcat.Text = comboboxMenuCategory.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtboxName.Text != "" & txtboxPrice.Text != "")
            {
                cmd.Connection = cn;
                decimal mydec;
                mydec = Convert.ToDecimal(txtboxPrice.Text);



                cn.Open();
                string combostring = Convert.ToString(comboboxMenuCategory.SelectedItem);
                cmd.CommandText = "select Name,Id from CategoryTbl where Name= ('" + combostring + "')";

                dr = cmd.ExecuteReader();
                dr.Read();


                string drstring = dr[0].ToString();
                int myint = dr.GetInt32(1);
                cn.Close();


                cn.Open();
                string mystring = Convert.ToString(comboboxMenuCategory.SelectedItem);
                cmd.CommandText = "select * from MenuItemTbl";
                dr = cmd.ExecuteReader();

                if (txtboxName.Text != "")
                {
                    cn.Close();
                    cn.Open();


                    cmd.CommandText = "insert into MenuItemTbl(ItemName,ItemPrice,ItemCategory) values ('" + txtboxName.Text + "','" + mydec + "','" + myint + "')";
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Record Inserted");

                    cn.Close();
                    LoadList();

                }
                dr.Dispose();
                btncool.Visible = true;
            }

        }

        private void btncool_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtboxName.Text != "")
            {
                cmd.Connection = cn;
                cn.Open();
                cmd.CommandText = "delete from MenuItemTbl where ItemName = '" + txtboxName.Text + "'";
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(listBox1.SelectedItem + "deleted");
                LoadList();

            }
        }
    }
}