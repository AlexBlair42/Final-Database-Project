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
               this.splitContainer1 = new System.Windows.Forms.SplitContainer();
               this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.label1 = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
               this.splitContainer1.Panel1.SuspendLayout();
               this.splitContainer1.Panel2.SuspendLayout();
               this.splitContainer1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
               this.splitContainer2.Panel2.SuspendLayout();
               this.splitContainer2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               this.SuspendLayout();
               // 
               // splitContainer1
               // 
               this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer1.Location = new System.Drawing.Point(0, 0);
               this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.splitContainer1.Name = "splitContainer1";
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Maroon;
               this.splitContainer1.Panel1.Controls.Add(this.button2);
               this.splitContainer1.Panel1.Controls.Add(this.button1);
               this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
               this.splitContainer1.Panel1.Controls.Add(this.textBox1);
               this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
               this.splitContainer1.Size = new System.Drawing.Size(1214, 980);
               this.splitContainer1.SplitterDistance = 403;
               this.splitContainer1.SplitterWidth = 6;
               this.splitContainer1.TabIndex = 2;
               // 
               // monthCalendar1
               // 
               this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
               this.monthCalendar1.Location = new System.Drawing.Point(26, 142);
               this.monthCalendar1.Margin = new System.Windows.Forms.Padding(17, 17, 17, 17);
               this.monthCalendar1.Name = "monthCalendar1";
               this.monthCalendar1.TabIndex = 2;
               this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.Color.Silver;
               this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(53, 41);
               this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(297, 52);
               this.textBox1.TabIndex = 1;
               this.textBox1.Text = "Movie Schedule";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // splitContainer2
               // 
               this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer2.Location = new System.Drawing.Point(0, 0);
               this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.splitContainer2.Name = "splitContainer2";
               // 
               // splitContainer2.Panel1
               // 
               this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
               // 
               // splitContainer2.Panel2
               // 
               this.splitContainer2.Panel2.Controls.Add(this.label1);
               this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
               this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
               this.splitContainer2.Size = new System.Drawing.Size(805, 980);
               this.splitContainer2.SplitterDistance = 374;
               this.splitContainer2.SplitterWidth = 6;
               this.splitContainer2.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
               this.label1.Location = new System.Drawing.Point(15, 13);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(132, 48);
               this.label1.TabIndex = 1;
               this.label1.Text = "label1";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(24, 87);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(367, 258);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Silver;
               this.button1.Font = new System.Drawing.Font("Verdana", 6.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button1.Location = new System.Drawing.Point(26, 491);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(141, 60);
               this.button1.TabIndex = 3;
               this.button1.Text = "Add Movie Time";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click_1);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.Color.Silver;
               this.button2.Font = new System.Drawing.Font("Verdana", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.button2.Location = new System.Drawing.Point(205, 492);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(174, 59);
               this.button2.TabIndex = 4;
               this.button2.Text = "Edit Movie Times";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // AppWindow
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1214, 980);
               this.Controls.Add(this.splitContainer1);
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "AppWindow";
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.AppWindow_Load);
               this.splitContainer1.Panel1.ResumeLayout(false);
               this.splitContainer1.Panel1.PerformLayout();
               this.splitContainer1.Panel2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
               this.splitContainer1.ResumeLayout(false);
               this.splitContainer2.Panel2.ResumeLayout(false);
               this.splitContainer2.Panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
               this.splitContainer2.ResumeLayout(false);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox textBox1;
          private System.Windows.Forms.MonthCalendar monthCalendar1;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
     }
}

