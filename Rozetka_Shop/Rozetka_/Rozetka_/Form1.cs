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

namespace Rozetka_
{
    public partial class Form1 : Form
    {
    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData(){
            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Rozetka;Integrated Security=True"))
            {
                connection.Open();
                string sql = "SELECT * FROM Users";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        lstUsers.Items.Clear();
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Id"].ToString());
                            item.SubItems.Add(reader["Name"].ToString());
                            item.SubItems.Add(reader["Email"].ToString());
                            item.SubItems.Add(reader["Password"].ToString());
                            item.SubItems.Add(reader["Phone"].ToString());
                            item.SubItems.Add(reader["Address"].ToString());
                            lstUsers.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e){           
                using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Rozetka;Integrated Security=True"))
                {
                    connection.Open();
                    string sql = "INSERT INTO Users (Name, Email, Password, Phone, Address) VALUES (@Name, @Email, @Password, @Phone, @Address)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Name", txtName.Text);
                        command.Parameters.AddWithValue("@Email", txtEmail.Text);
                        command.Parameters.AddWithValue("@Password", txtPassword.Text);
                        command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);
                        command.ExecuteNonQuery();
                    }
                }
            LoadData();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Rozetka;Integrated Security=True"))
            {
                connection.Open();
                string sql = "UPDATE Users SET Name=@Name, Email=@Email, Password=@Password, Phone=@Phone, Address=@Address WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", txtId.Text);
                    command.Parameters.AddWithValue("@Name", txtName.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@Password", txtPassword.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Rozetka;Integrated Security=True"))
            {
                connection.Open();
                string sql = "DELETE FROM Users WHERE Id=@Id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", txtId.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadData();
        }

    }
}
