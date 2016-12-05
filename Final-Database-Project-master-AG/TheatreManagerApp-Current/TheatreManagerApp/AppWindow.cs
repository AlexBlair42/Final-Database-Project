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
using System.Globalization;

namespace TheatreManagerApp
{
    public partial class AppWindow : Form
    {
        TheaterDBDataSet theDB = new TheaterDBDataSet();

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
            TheaterDBDataSetTableAdapters.Box_OfficeTableAdapter BOAdapter = new TheaterDBDataSetTableAdapters.Box_OfficeTableAdapter();
            TheatreManagerApp.TheaterDBDataSet.Box_OfficeDataTable BODataTable = BOAdapter.GetData();
            IEnumerable<DataRow> query =
                                    from product in BODataTable.AsEnumerable()
                                    select product;

            DataRow TopRow = query.First<DataRow>();

            this.label6.Text = TopRow[1].ToString();
            this.label7.Text = TopRow[2].ToString();
            this.label8.Text = TopRow[3].ToString();
            this.label9.Text = TopRow[4].ToString();
            }
        }

        
    }

