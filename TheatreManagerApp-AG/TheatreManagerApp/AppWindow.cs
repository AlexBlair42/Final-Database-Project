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
        public AppWindow()
        {
            InitializeComponent();
            Active_panel = this.Menu_panel;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(Active_panel == Menu_panel)
            {
                this.Menu_panel.Visible = false;
                this.Inventory_panel.Visible = true;
            }
            else
            {
                this.Inventory_panel.Visible = false;
                this.Menu_panel.Visible = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
