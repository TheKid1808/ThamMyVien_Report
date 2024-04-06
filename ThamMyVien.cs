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
namespace ThamMyVien_Report
{
    public partial class Tham_My_Vien : Form
    {
        private string connectionStrings = ConfigurationManager.ConnectionStrings["ThamMyVien_Report"].ConnectionString;
        public Tham_My_Vien()
        {
            InitializeComponent();
            ShowMaBenhNhan();
        }

        private void ShowMaBenhNhan()
        {
            using (SqlConnection connection = new SqlConnection(connectionStrings))
            {
                using (SqlCommand command = new SqlCommand("Select_BenhNhan", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cBox_MaBenhNhan.Items.Add(reader["MaBenhNhan_TNDA"].ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
        }
        private void ShowTenBenhNhan()
        {
            using (SqlConnection  connection = new SqlConnection(connectionStrings))
            {
                using (SqlCommand command = new SqlCommand("Select_TenBenhNhan_TNDA",connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    connection.Open();
                    command.Parameters.AddWithValue("@MaBenhNhan_TNDA", cBox_MaBenhNhan.Text);
                    tBox_TenBenhNhan.Text = command.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
        }

        private void cBox_MaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTenBenhNhan();
        }

        private void button_HienThiThongTin_Click(object sender, EventArgs e)
        {
            Form_SoKhamBenh soKhamBenh = new Form_SoKhamBenh();
            soKhamBenh.Show();
            soKhamBenh.ShowSoKhamBenh(cBox_MaBenhNhan.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cBox_MaBenhNhan.Text = "";
            tBox_TenBenhNhan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_DSKhamBenh_Click(object sender, EventArgs e)
        {
            Form_DSKhamBenh dSKhamBenh = new Form_DSKhamBenh();
            dSKhamBenh.Show();
            dSKhamBenh.ShowDSKhamBenh();
        }
    }
}
