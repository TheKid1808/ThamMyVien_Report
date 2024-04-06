using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using System.Data.SqlClient;
namespace ThamMyVien_Report
{
    public partial class Form_SoKhamBenh : Form
    {
        private string connectionStrings = ConfigurationManager.ConnectionStrings["ThamMyVien_Report"].ConnectionString;
        public Form_SoKhamBenh()
        {
            InitializeComponent();
        }

        public void ShowSoKhamBenh(string MaBenhNhan, string ProcName = "ChiTietHopDong_TNDA;1")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand command = new SqlCommand(ProcName, connection))
                    {
                        connection.Open();
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@MaBenhNhan_TNDA",int.Parse(MaBenhNhan));
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            dataAdapter.SelectCommand = command;
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);


                                ReportDocument report = new ReportDocument();
                                string path = string.Format("E:\\Lap trinh huong su kien\\Visual Studio\\ThamMyVien_Report\\SoKhamBenh_Report.rpt");
                                report.Load(path);

                                report.Database.Tables[ProcName].SetDataSource(dataTable);

                                cryRptViewer_SoKhamBenh.ReportSource = report;
                                cryRptViewer_SoKhamBenh.Refresh();
                            }
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                this.Close();
            }
        }
    }
}
