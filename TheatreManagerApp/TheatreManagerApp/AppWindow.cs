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
        public AppWindow()
        {
            InitializeComponent();
        }


        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {   

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

          private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
          {
               
          }

          private void AppWindow_Load(object sender, EventArgs e)
          {

          }

          private void label2_Click(object sender, EventArgs e)
          {
               
          }

          private void button1_Click(object sender, EventArgs e)
          {

          }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {
              
          }

          private void button1_Click_1(object sender, EventArgs e)
          {
               Schedule S1 = new Schedule();
               S1.ShowDialog();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Schedule S2 = new Schedule();
                    S2.ShowDialog();
          }

          private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
          {

          }

          private void label1_Click(object sender, EventArgs e)
          {

          }

          private void label1_Click_1(object sender, EventArgs e)
          {

          }
     }
}
