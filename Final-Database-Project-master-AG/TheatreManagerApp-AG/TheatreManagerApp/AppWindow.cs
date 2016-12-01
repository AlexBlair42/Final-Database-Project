using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheatreManagerApp;
using System.Data.OleDb;

namespace TheatreManagerApp
{
    public partial class AppWindow : Form
    {
        Panel Active_panel;
        DataTable Schedule;
        DataTable Prices;
        int Querynum = 0;
        public AppWindow()
        {
            
            InitializeComponent();
            Active_panel = this.Menu_panel;
            LoadLeftPanel();
            
        }
        private void LoadLeftPanel()
        {
            string kids_price, adult_price, SS_price, matinee_price;
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = Utility.QuerySelect(0);
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();


                bool success = rdr.Read();
                if (success)
                {
                    label6.Text = rdr.GetValue(1).ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, error: " + ex.Message + ex.StackTrace);
            }
            
            

            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       

    }
}
