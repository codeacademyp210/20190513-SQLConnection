using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Weekend_Task
{
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            //this.Hide();
            //Login login = new Login(this);
            //login.Show();
            FillComboboxes();
         

        }


        private void FillComboboxes()
        {
            SqlConnection conn = null;

            try
            {
                string connString = ConfigurationManager.ConnectionStrings["P210Weekend"].ConnectionString;
                conn = new SqlConnection(connString);
                conn.Open();


                string comm = "SELECT * FROM CATEGORIES";
                SqlCommand command = new SqlCommand(comm, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    cmbCategory.Items.Add(reader.GetString(1));
                }

                string commBrand = "SELECT * FROM Brands";
                SqlCommand commandBrand = new SqlCommand(commBrand, conn);
                reader.Close();
                SqlDataReader reader2 = commandBrand.ExecuteReader();
                while (reader2.Read())
                {
                    cmbBrand.Items.Add(reader2.GetString(1));
                }
            }
            catch (Exception e)
            {
                
            }
            finally
            {
                conn.Close();
            }
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
