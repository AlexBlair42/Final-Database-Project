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

        List<string> MenuList = new List<string>();
        List<string> StockList = new List<string>();
        public AppWindow()
        {
            
            InitializeComponent();
            Active_panel = this.Menu_panel;
            LoadLeftPanel();

            LoadMenuList();
            LoadStockList();
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
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void LoadMenuList()
        {
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "SELECT M.Prod_Name FROM Menu M WHERE M.Quantity > 0";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    MenuList.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }

            Menu_List.DataSource = MenuList;
        }

        private void LoadStockList()
        {
            try
            {
                OleDbConnection connection = Utility.GetOleDBConnection();
                connection.Open();
                string Query = "SELECT M.Prod_Name FROM Menu M WHERE M.Quantity < 50";
                OleDbCommand cmd = new OleDbCommand(Query, connection);
                OleDbDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    StockList.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops, error: " + ex.Message + ex.StackTrace);
            }

            Stock_List.DataSource = StockList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            //The add button was clicked
            MenuList.Add("New item " + DateTime.Now.Second);        // <-- string of new item, pop up box that requires: 1) Name of product 2) Current Quantity 3) Price

            //Change the DataSouce
            Menu_List.DataSource = null;
            Menu_List.DataSource = MenuList;

            //If we just added an item, ensure the remove and edit buttons are enabled
            RemoveBtn.Enabled = true;
            EditBtn.Enabled = true;
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            //The remove button was clicked
            int selectedIndex = Menu_List.SelectedIndex;
            string productName = Menu_List.SelectedItem.ToString();

            try
            {   
                //Remove selected item in the list
                MenuList.RemoveAt(selectedIndex);
                if (StockList.Contains(productName))
                {
                    StockList.Remove(productName);
                    Stock_List.DataSource = null;
                    Stock_List.DataSource = StockList;
                }
            }
            catch
            {
            }

            Menu_List.DataSource = null;
            Menu_List.DataSource = MenuList;

            //If the list is empty disable the remove and edit buttons
            if (Menu_List.Items.Count == 0)
            {
                RemoveBtn.Enabled = false;
                EditBtn.Enabled = false;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
          

        }
    }
}
