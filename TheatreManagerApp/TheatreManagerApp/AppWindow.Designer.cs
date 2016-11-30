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
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.label1 = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
               this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.splitContainer1.Name = "splitContainer1";
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
               this.splitContainer1.Panel1.Controls.Add(this.textBox1);
               this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
               // 
               // splitContainer1.Panel2
               // 
               this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
               this.splitContainer1.Size = new System.Drawing.Size(662, 531);
               this.splitContainer1.SplitterDistance = 220;
               this.splitContainer1.SplitterWidth = 3;
               this.splitContainer1.TabIndex = 2;
               // 
               // splitContainer2
               // 
               this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer2.Location = new System.Drawing.Point(0, 0);
               this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
               this.splitContainer2.Size = new System.Drawing.Size(439, 531);
               this.splitContainer2.SplitterDistance = 204;
               this.splitContainer2.SplitterWidth = 3;
               this.splitContainer2.TabIndex = 0;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
               this.label1.Location = new System.Drawing.Point(8, 7);
               this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(79, 29);
               this.label1.TabIndex = 1;
               this.label1.Text = "label1";
               // 
               // pictureBox1
               // 
               this.pictureBox1.Location = new System.Drawing.Point(13, 47);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(200, 140);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // textBox1
               // 
               this.textBox1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.textBox1.Location = new System.Drawing.Point(24, 47);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(164, 33);
               this.textBox1.TabIndex = 1;
               this.textBox1.Text = "Movie Schedule";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // monthCalendar1
               // 
               this.monthCalendar1.Location = new System.Drawing.Point(0, 174);
               this.monthCalendar1.Name = "monthCalendar1";
               this.monthCalendar1.TabIndex = 2;
               // 
               // AppWindow
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(662, 531);
               this.Controls.Add(this.splitContainer1);
               this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
     }
}

