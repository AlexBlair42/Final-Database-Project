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
            this.EditMatPriceBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.EditSSPriceBtn = new System.Windows.Forms.Button();
            this.TicketPricesLb = new System.Windows.Forms.Label();
            this.EditAdultPriceBtn = new System.Windows.Forms.Button();
            this.MatineePriceLb = new System.Windows.Forms.Label();
            this.SSPriceLb = new System.Windows.Forms.Label();
            this.EditKidPriceBtn = new System.Windows.Forms.Button();
            this.AdultPriceLb = new System.Windows.Forms.Label();
            this.KidsPriceLb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Inventory_panel = new System.Windows.Forms.Panel();
            this.Menu_toolstrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.Stock_List = new System.Windows.Forms.ListBox();
            this.Menu_List = new System.Windows.Forms.ListBox();
            this.Low_Stock = new System.Windows.Forms.Label();
            this.MenuLb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CalendarLb = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.AdvancedDetailsLb = new System.Windows.Forms.Label();
            this.Image_Movie_Product = new System.Windows.Forms.PictureBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.Price_panel.SuspendLayout();
            this.Inventory_panel.SuspendLayout();
            this.Menu_toolstrip2.SuspendLayout();
            this.Menu_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Movie_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // Price_panel
            // 
            this.Price_panel.Controls.Add(this.flowLayoutPanel1);
            this.Price_panel.Controls.Add(this.EditMatPriceBtn);
            this.Price_panel.Controls.Add(this.label8);
            this.Price_panel.Controls.Add(this.EditSSPriceBtn);
            this.Price_panel.Controls.Add(this.TicketPricesLb);
            this.Price_panel.Controls.Add(this.EditAdultPriceBtn);
            this.Price_panel.Controls.Add(this.MatineePriceLb);
            this.Price_panel.Controls.Add(this.SSPriceLb);
            this.Price_panel.Controls.Add(this.EditKidPriceBtn);
            this.Price_panel.Controls.Add(this.AdultPriceLb);
            this.Price_panel.Controls.Add(this.KidsPriceLb);
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
            // EditMatPriceBtn
            // 
            this.EditMatPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditMatPriceBtn.Location = new System.Drawing.Point(304, 133);
            this.EditMatPriceBtn.Name = "EditMatPriceBtn";
            this.EditMatPriceBtn.Size = new System.Drawing.Size(53, 29);
            this.EditMatPriceBtn.TabIndex = 12;
            this.EditMatPriceBtn.Text = "Edit";
            this.EditMatPriceBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(252, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "SPL";
            // 
            // EditSSPriceBtn
            // 
            this.EditSSPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditSSPriceBtn.Location = new System.Drawing.Point(304, 104);
            this.EditSSPriceBtn.Name = "EditSSPriceBtn";
            this.EditSSPriceBtn.Size = new System.Drawing.Size(53, 29);
            this.EditSSPriceBtn.TabIndex = 11;
            this.EditSSPriceBtn.Text = "Edit";
            this.EditSSPriceBtn.UseVisualStyleBackColor = true;
            // 
            // TicketPricesLb
            // 
            this.TicketPricesLb.AutoSize = true;
            this.TicketPricesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.TicketPricesLb.Location = new System.Drawing.Point(3, 1);
            this.TicketPricesLb.Name = "TicketPricesLb";
            this.TicketPricesLb.Size = new System.Drawing.Size(199, 37);
            this.TicketPricesLb.TabIndex = 2;
            this.TicketPricesLb.Text = "Ticket Prices";
            // 
            // EditAdultPriceBtn
            // 
            this.EditAdultPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditAdultPriceBtn.Location = new System.Drawing.Point(304, 75);
            this.EditAdultPriceBtn.Name = "EditAdultPriceBtn";
            this.EditAdultPriceBtn.Size = new System.Drawing.Size(53, 29);
            this.EditAdultPriceBtn.TabIndex = 10;
            this.EditAdultPriceBtn.Text = "Edit";
            this.EditAdultPriceBtn.UseVisualStyleBackColor = true;
            // 
            // MatineePriceLb
            // 
            this.MatineePriceLb.AutoSize = true;
            this.MatineePriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MatineePriceLb.Location = new System.Drawing.Point(6, 133);
            this.MatineePriceLb.Name = "MatineePriceLb";
            this.MatineePriceLb.Size = new System.Drawing.Size(125, 24);
            this.MatineePriceLb.TabIndex = 3;
            this.MatineePriceLb.Text = "Matinee Price";
            // 
            // SSPriceLb
            // 
            this.SSPriceLb.AutoSize = true;
            this.SSPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.SSPriceLb.Location = new System.Drawing.Point(6, 104);
            this.SSPriceLb.Name = "SSPriceLb";
            this.SSPriceLb.Size = new System.Drawing.Size(182, 24);
            this.SSPriceLb.TabIndex = 2;
            this.SSPriceLb.Text = "Senior/Student Price";
            // 
            // EditKidPriceBtn
            // 
            this.EditKidPriceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.EditKidPriceBtn.Location = new System.Drawing.Point(304, 46);
            this.EditKidPriceBtn.Name = "EditKidPriceBtn";
            this.EditKidPriceBtn.Size = new System.Drawing.Size(53, 29);
            this.EditKidPriceBtn.TabIndex = 9;
            this.EditKidPriceBtn.Text = "Edit";
            this.EditKidPriceBtn.UseVisualStyleBackColor = true;
            // 
            // AdultPriceLb
            // 
            this.AdultPriceLb.AutoSize = true;
            this.AdultPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AdultPriceLb.Location = new System.Drawing.Point(6, 75);
            this.AdultPriceLb.Name = "AdultPriceLb";
            this.AdultPriceLb.Size = new System.Drawing.Size(110, 24);
            this.AdultPriceLb.TabIndex = 1;
            this.AdultPriceLb.Text = "Adults Price";
            // 
            // KidsPriceLb
            // 
            this.KidsPriceLb.AutoSize = true;
            this.KidsPriceLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.KidsPriceLb.Location = new System.Drawing.Point(6, 46);
            this.KidsPriceLb.Name = "KidsPriceLb";
            this.KidsPriceLb.Size = new System.Drawing.Size(94, 24);
            this.KidsPriceLb.TabIndex = 0;
            this.KidsPriceLb.Text = "Kids Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(252, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "KPL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(248, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "MPL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(251, 80);
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
            // Menu_panel
            // 
            this.Menu_panel.Controls.Add(this.EditBtn);
            this.Menu_panel.Controls.Add(this.RemoveBtn);
            this.Menu_panel.Controls.Add(this.AddBtn);
            this.Menu_panel.Controls.Add(this.Stock_List);
            this.Menu_panel.Controls.Add(this.Menu_List);
            this.Menu_panel.Controls.Add(this.Low_Stock);
            this.Menu_panel.Controls.Add(this.MenuLb);
            this.Menu_panel.Location = new System.Drawing.Point(-1, 180);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(360, 496);
            this.Menu_panel.TabIndex = 1;
            // 
            // Stock_List
            // 
            this.Stock_List.FormattingEnabled = true;
            this.Stock_List.Location = new System.Drawing.Point(10, 345);
            this.Stock_List.Name = "Stock_List";
            this.Stock_List.Size = new System.Drawing.Size(344, 134);
            this.Stock_List.TabIndex = 19;
            // 
            // Menu_List
            // 
            this.Menu_List.FormattingEnabled = true;
            this.Menu_List.Location = new System.Drawing.Point(10, 41);
            this.Menu_List.Name = "Menu_List";
            this.Menu_List.Size = new System.Drawing.Size(344, 251);
            this.Menu_List.TabIndex = 18;
            // 
            // Low_Stock
            // 
            this.Low_Stock.AutoSize = true;
            this.Low_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.Low_Stock.Location = new System.Drawing.Point(3, 305);
            this.Low_Stock.Name = "Low_Stock";
            this.Low_Stock.Size = new System.Drawing.Size(165, 37);
            this.Low_Stock.TabIndex = 17;
            this.Low_Stock.Text = "Low Stock";
            // 
            // MenuLb
            // 
            this.MenuLb.AutoSize = true;
            this.MenuLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.MenuLb.Location = new System.Drawing.Point(3, 0);
            this.MenuLb.Name = "MenuLb";
            this.MenuLb.Size = new System.Drawing.Size(96, 37);
            this.MenuLb.TabIndex = 16;
            this.MenuLb.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.CalendarLb);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(312, 438);
            this.dataGridView1.TabIndex = 14;
            // 
            // CalendarLb
            // 
            this.CalendarLb.AutoSize = true;
            this.CalendarLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.CalendarLb.Location = new System.Drawing.Point(16, 0);
            this.CalendarLb.Name = "CalendarLb";
            this.CalendarLb.Size = new System.Drawing.Size(147, 37);
            this.CalendarLb.TabIndex = 13;
            this.CalendarLb.Text = "Calendar";
            this.CalendarLb.Click += new System.EventHandler(this.label10_Click);
            // 
            // AdvancedDetailsLb
            // 
            this.AdvancedDetailsLb.AutoSize = true;
            this.AdvancedDetailsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.AdvancedDetailsLb.Location = new System.Drawing.Point(725, 0);
            this.AdvancedDetailsLb.Name = "AdvancedDetailsLb";
            this.AdvancedDetailsLb.Size = new System.Drawing.Size(265, 37);
            this.AdvancedDetailsLb.TabIndex = 13;
            this.AdvancedDetailsLb.Text = "Advanced Details";
            // 
            // Image_Movie_Product
            // 
            this.Image_Movie_Product.Location = new System.Drawing.Point(732, 45);
            this.Image_Movie_Product.Name = "Image_Movie_Product";
            this.Image_Movie_Product.Size = new System.Drawing.Size(318, 162);
            this.Image_Movie_Product.TabIndex = 14;
            this.Image_Movie_Product.TabStop = false;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(117, 14);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(279, 14);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 21;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(198, 14);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AppWindow
            // 
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.Image_Movie_Product);
            this.Controls.Add(this.AdvancedDetailsLb);
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
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Image_Movie_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private Panel Price_panel;
        private Panel Menu_panel;
        private Panel Inventory_panel;
        private ToolStrip Menu_toolstrip2;
        private ToolStripLabel toolStripLabel2;
        private ToolStripButton toolStripButton2;
        private Label TicketPricesLb;
        private Button EditMatPriceBtn;
        private Label label8;
        private Button EditSSPriceBtn;
        private Button EditAdultPriceBtn;
        private Label MatineePriceLb;
        private Label SSPriceLb;
        private Button EditKidPriceBtn;
        private Label AdultPriceLb;
        private Label KidsPriceLb;
        private Label label6;
        private Label label9;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label CalendarLb;
        private DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MonthCalendar monthCalendar1;
        private Label MenuLb;
        private Label Low_Stock;
        private ListBox Stock_List;
        private ListBox Menu_List;
        private Label AdvancedDetailsLb;
        private PictureBox Image_Movie_Product;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button EditBtn;
    }
    #endregion
}

