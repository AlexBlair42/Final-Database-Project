using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace TheatreManagerApp
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppWindow());
        }

        static DataTable QueryDB(string Query)
        {
            DataTable QueryResults = new DataTable();
            try
            {

                OleDbConnection MyConnection;
                string ConnectionPath = "Data Source=CS1;Initial Catalog=TheaterDB;Integrated Security=True;";
                MyConnection = new OleDbConnection(ConnectionPath);
                MyConnection.Open();
                OleDbDataAdapter myAdapter = new OleDbDataAdapter(Query, MyConnection);

                myAdapter.Fill(QueryResults);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Oops, error: " + ex.Message + ex.StackTrace);
            }

            return QueryResults;
        }

        static DataTable FilterTable(DataTable table, DateTime Start, DateTime End)
        {
            return table;
        }

    }
}
