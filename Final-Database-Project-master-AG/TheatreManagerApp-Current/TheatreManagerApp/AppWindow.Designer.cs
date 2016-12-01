using System.Windows.Forms;

namespace TheatreManagerApp
{
    partial class AppWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppWindow));
               this.Price_panel = new System.Windows.Forms.Panel();
               this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
               this.button5 = new System.Windows.Forms.Button();
               this.label8 = new System.Windows.Forms.Label();
               this.button4 = new System.Windows.Forms.Button();
               this.label1 = new System.Windows.Forms.Label();
               this.button3 = new System.Windows.Forms.Button();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.button2 = new System.Windows.Forms.Button();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label6 = new System.Windows.Forms.Label();
               this.label9 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.Inventory_panel = new System.Windows.Forms.Panel();
               this.Menu_toolstrip2 = new System.Windows.Forms.ToolStrip();
               this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
               this.Menu_toolstrip = new System.Windows.Forms.ToolStrip();
               this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
               this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
               this.Menu_panel = new System.Windows.Forms.Panel();
               this.panel1 = new System.Windows.Forms.Panel();
               this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
               this.dataGridView1 = new System.Windows.Forms.DataGridView();
               this.label10 = new System.Windows.Forms.Label();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.Price_panel.SuspendLayout();
               this.Inventory_panel.SuspendLayout();
               this.Menu_toolstrip2.SuspendLayout();
               this.Menu_toolstrip.SuspendLayout();
               this.Menu_panel.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
               this.SuspendLayout();
               // 
               // Price_panel
               // 
               this.Price_panel.Controls.Add(this.flowLayoutPanel1);
               this.Price_panel.Controls.Add(this.button5);
               this.Price_panel.Controls.Add(this.label8);
               this.Price_panel.Controls.Add(this.button4);
               this.Price_panel.Controls.Add(this.label1);
               this.Price_panel.Controls.Add(this.button3);
               this.Price_panel.Controls.Add(this.label5);
               this.Price_panel.Controls.Add(this.label4);
               this.Price_panel.Controls.Add(this.button2);
               this.Price_panel.Controls.Add(this.label3);
               this.Price_panel.Controls.Add(this.label2);
               this.Price_panel.Controls.Add(this.label6);
               this.Price_panel.Controls.Add(this.label9);
               this.Price_panel.Controls.Add(this.label7);
               this.Price_panel.Location = new System.Drawing.Point(-1, -1);
               this.Price_panel.Name = "Price_panel";
               this.Price_panel.Size = new System.Drawing.Size(360, 175);
               this.Price_panel.TabIndex = 0;
               // 
               // flowLayoutPanel1
               // 
               this.flowLayoutPanel1.Location = new System.Drawing.Point(360, 0);
               this.flowLayoutPanel1.Name = "flowLayoutPanel1";
               this.flowLayoutPanel1.Size = new System.Drawing.Size(360, 677);
               this.flowLayoutPanel1.TabIndex = 3;
               // 
               // button5
               // 
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.button5.Location = new System.Drawing.Point(304, 133);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(53, 29);
               this.button5.TabIndex = 12;
               this.button5.Text = "Edit";
               this.button5.UseVisualStyleBackColor = true;
               // 
               // label8
               // 
               this.label8.AutoSize = true;
               this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label8.Location = new System.Drawing.Point(247, 104);
               this.label8.Name = "label8";
               this.label8.Size = new System.Drawing.Size(44, 24);
               this.label8.TabIndex = 6;
               this.label8.Text = "SPL";
               // 
               // button4
               // 
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.button4.Location = new System.Drawing.Point(304, 104);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(53, 29);
               this.button4.TabIndex = 11;
               this.button4.Text = "Edit";
               this.button4.UseVisualStyleBackColor = true;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
               this.label1.Location = new System.Drawing.Point(3, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(199, 37);
               this.label1.TabIndex = 2;
               this.label1.Text = "Ticket Prices";
               // 
               // button3
               // 
               this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.button3.Location = new System.Drawing.Point(304, 75);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(53, 29);
               this.button3.TabIndex = 10;
               this.button3.Text = "Edit";
               this.button3.UseVisualStyleBackColor = true;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label5.Location = new System.Drawing.Point(6, 133);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(125, 24);
               this.label5.TabIndex = 3;
               this.label5.Text = "Matinee Price";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label4.Location = new System.Drawing.Point(6, 104);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(182, 24);
               this.label4.TabIndex = 2;
               this.label4.Text = "Senior/Student Price";
               // 
               // button2
               // 
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
               this.button2.Location = new System.Drawing.Point(304, 46);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(53, 29);
               this.button2.TabIndex = 9;
               this.button2.Text = "Edit";
               this.button2.UseVisualStyleBackColor = true;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label3.Location = new System.Drawing.Point(6, 75);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(110, 24);
               this.label3.TabIndex = 1;
               this.label3.Text = "Adults Price";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label2.Location = new System.Drawing.Point(6, 46);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(94, 24);
               this.label2.TabIndex = 0;
               this.label2.Text = "Kids Price";
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label6.Location = new System.Drawing.Point(251, 46);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(44, 24);
               this.label6.TabIndex = 4;
               this.label6.Text = "KPL";
               // 
               // label9
               // 
               this.label9.AutoSize = true;
               this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label9.Location = new System.Drawing.Point(247, 133);
               this.label9.Name = "label9";
               this.label9.Size = new System.Drawing.Size(48, 24);
               this.label9.TabIndex = 7;
               this.label9.Text = "MPL";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
               this.label7.Location = new System.Drawing.Point(251, 75);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(45, 24);
               this.label7.TabIndex = 5;
               this.label7.Text = "APL";
               // 
               // Inventory_panel
               // 
               this.Inventory_panel.BackColor = System.Drawing.Color.Coral;
               this.Inventory_panel.Controls.Add(this.Menu_toolstrip2);
               this.Inventory_panel.Location = new System.Drawing.Point(-1, 180);
               this.Inventory_panel.Name = "Inventory_panel";
               this.Inventory_panel.Size = new System.Drawing.Size(360, 496);
               this.Inventory_panel.TabIndex = 1;
               this.Inventory_panel.Visible = false;
               // 
               // Menu_toolstrip2
               // 
               this.Menu_toolstrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.Menu_toolstrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripButton2});
               this.Menu_toolstrip2.Location = new System.Drawing.Point(0, 0);
               this.Menu_toolstrip2.Name = "Menu_toolstrip2";
               this.Menu_toolstrip2.Size = new System.Drawing.Size(360, 27);
               this.Menu_toolstrip2.TabIndex = 0;
               this.Menu_toolstrip2.Text = "toolStrip1";
               this.Menu_toolstrip2.Visible = false;
               // 
               // toolStripLabel2
               // 
               this.toolStripLabel2.Name = "toolStripLabel2";
               this.toolStripLabel2.Size = new System.Drawing.Size(86, 24);
               this.toolStripLabel2.Text = "toolStripLabel1";
               // 
               // toolStripButton2
               // 
               this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
               this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButton2.Name = "toolStripButton2";
               this.toolStripButton2.Size = new System.Drawing.Size(24, 24);
               this.toolStripButton2.Text = "toolStripButton1";
               this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
               // 
               // Menu_toolstrip
               // 
               this.Menu_toolstrip.ImageScalingSize = new System.Drawing.Size(20, 20);
               this.Menu_toolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButton1});
               this.Menu_toolstrip.Location = new System.Drawing.Point(0, 0);
               this.Menu_toolstrip.Name = "Menu_toolstrip";
               this.Menu_toolstrip.Size = new System.Drawing.Size(360, 27);
               this.Menu_toolstrip.TabIndex = 0;
               this.Menu_toolstrip.Text = "toolStrip1";
               // 
               // toolStripLabel1
               // 
               this.toolStripLabel1.Name = "toolStripLabel1";
               this.toolStripLabel1.Size = new System.Drawing.Size(86, 24);
               this.toolStripLabel1.Text = "toolStripLabel1";
               // 
               // toolStripButton1
               // 
               this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
               this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
               this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
               this.toolStripButton1.Name = "toolStripButton1";
               this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
               this.toolStripButton1.Text = "toolStripButton1";
               this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
               // 
               // Menu_panel
               // 
               this.Menu_panel.Controls.Add(this.Menu_toolstrip);
               this.Menu_panel.Location = new System.Drawing.Point(-1, 180);
               this.Menu_panel.Name = "Menu_panel";
               this.Menu_panel.Size = new System.Drawing.Size(360, 496);
               this.Menu_panel.TabIndex = 1;
               // 
               // panel1
               // 
               this.panel1.Controls.Add(this.monthCalendar1);
               this.panel1.Controls.Add(this.dataGridView1);
               this.panel1.Controls.Add(this.label10);
               this.panel1.Location = new System.Drawing.Point(360, 0);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(360, 676);
               this.panel1.TabIndex = 2;
               // 
               // monthCalendar1
               // 
               this.monthCalendar1.Location = new System.Drawing.Point(23, 45);
               this.monthCalendar1.Name = "monthCalendar1";
               this.monthCalendar1.TabIndex = 15;
               this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
               // 
               // dataGridView1
               // 
               this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
               this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
               this.dataGridView1.GridColor = System.Drawing.Color.Black;
               this.dataGridView1.Location = new System.Drawing.Point(23, 234);
               this.dataGridView1.Name = "dataGridView1";
               this.dataGridView1.RowTemplate.Height = 24;
               this.dataGridView1.Size = new System.Drawing.Size(312, 397);
               this.dataGridView1.TabIndex = 14;
               this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
               // 
               // label10
               // 
               this.label10.AutoSize = true;
               this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
               this.label10.Location = new System.Drawing.Point(2, 0);
               this.label10.Name = "label10";
               this.label10.Size = new System.Drawing.Size(147, 37);
               this.label10.TabIndex = 13;
               this.label10.Text = "Calendar";
               this.label10.Click += new System.EventHandler(this.label10_Click);
               // 
               // AppWindow
               // 
               this.ClientSize = new System.Drawing.Size(1062, 673);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.Menu_panel);
               this.Controls.Add(this.Price_panel);
               this.Name = "AppWindow";
               this.Price_panel.ResumeLayout(false);
               this.Price_panel.PerformLayout();
               this.Inventory_panel.ResumeLayout(false);
               this.Inventory_panel.PerformLayout();
               this.Menu_toolstrip2.ResumeLayout(false);
               this.Menu_toolstrip2.PerformLayout();
               this.Menu_toolstrip.ResumeLayout(false);
               this.Menu_toolstrip.PerformLayout();
               this.Menu_panel.ResumeLayout(false);
               this.Menu_panel.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
               this.ResumeLayout(false);

        }
        
        private Panel Price_panel;
        private Panel Menu_panel;
        private Panel Inventory_panel;
        private ToolStrip Menu_toolstrip;
        private ToolStrip Menu_toolstrip2;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton2;
        private Label label1;
        private Button button5;
        private Label label8;
        private Button button4;
        private Button button3;
        private Label label5;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label9;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label10;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MonthCalendar monthCalendar1;
    }
    #endregion
}

