using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTK
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=MSI;Initial Catalog=FPT;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        DataSet getDataGridCustomer()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM KHACHHANG";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        DataSet getDataGridFinance()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM TAICHINH";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        DataSet getDataGridContact()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM HOPDONG";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        DataSet getDataGridProject()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM DUAN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        DataSet getDataGridPersonnel()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM NHANSU";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        DataSet getDataGridFinace_Project()
        {
            DataSet data = new DataSet();

            string query = "SELECT * FROM TAICHINH_DUAN";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            gridCustomer.DataSource = getDataGridCustomer().Tables[0];
            gridFinance.DataSource = getDataGridFinance().Tables[0];
            gridContact.DataSource = getDataGridContact().Tables[0];
            gridProjects.DataSource = getDataGridProject().Tables[0];
            gridPersonnel.DataSource = getDataGridPersonnel().Tables[0];
            gridFinance_Project.DataSource = getDataGridFinace_Project().Tables[0];
        }
    }
}
