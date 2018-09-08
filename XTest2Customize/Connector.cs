using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Configuration;
using System.Windows.Forms;

namespace XTest2Customize
{
    class Connector
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        private static NpgsqlConnection conn = new NpgsqlConnection(connectionString);

        public static void Connect()
        {
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void Disconnect()
        {
            conn.Close();
        }
    }
}
