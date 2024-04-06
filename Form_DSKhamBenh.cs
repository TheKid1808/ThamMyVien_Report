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
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace ThamMyVien_Report
{
    public partial class Form_DSKhamBenh : Form
    {
        private string connectionStrings = ConfigurationManager.ConnectionStrings["ThamMyVien_Report"].ConnectionString;
        public Form_DSKhamBenh()
        {
            InitializeComponent();
        }

        public void ShowDSKhamBenh(string ProcName = "select_TatCaThongTin;1")
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionStrings))
                {
                    using (SqlCommand command = new SqlCommand(ProcName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter())
                        {
                            dataAdapter.SelectCommand = command;
                            using (DataTable dataTable = new DataTable())
                            {
                                dataAdapter.Fill(dataTable);


                                ReportDocument report = new ReportDocument();
                                string path = string.Format("E:\\Lap trinh huong su kien\\Visual Studio\\ThamMyVien_Report\\KhamBenhTheoThoiGianReport.rpt");
                                report.Load(path);

                                report.Database.Tables[ProcName].SetDataSource(dataTable);

                                cryRpt_DSKhamBenh.ReportSource = report;
                                cryRpt_DSKhamBenh.Refresh();
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }
    }
}
