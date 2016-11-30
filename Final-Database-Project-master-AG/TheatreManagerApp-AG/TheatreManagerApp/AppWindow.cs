using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Prices = TheatreManagerApp.Utility.QueryDB(TheatreManagerApp.Utility.QuerySelect(0));
            DataTableReader rdr = Prices.CreateDataReader();
            rdr.Read();
            kids_price = rdr[1].ToString();
            this.label6.Text = kids_price;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

       

    }
}
