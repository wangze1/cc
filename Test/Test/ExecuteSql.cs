using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class ExecuteSql : Form
    {
        public ExecuteSql()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = ConfigurationManager.ConnectionStrings["ycdb1"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(strCon))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(this.textBox1.Text, conn);
                    da.SelectCommand.CommandTimeout = 300;
                    da.SelectCommand.CommandType = CommandType.Text;

                    da.Fill(ds);
                    this.textBox1.Text = "成功";
                }
            }
            catch (Exception ex)
            {
                this.textBox1.Text = ex.Message + "\n" + ex.StackTrace;
            }
        }
    }
}
