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
               this.label1 = new System.Windows.Forms.Label();
               this.button2 = new System.Windows.Forms.Button();
               this.button1 = new System.Windows.Forms.Button();
               this.splitContainer2 = new System.Windows.Forms.SplitContainer();
               this.Concessions = new System.Windows.Forms.Label();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
               this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
               this.splitContainer1.Name = "splitContainer1";
               // 
               // splitContainer1.Panel1
               // 
               this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Maroon;
               this.splitContainer1.Panel1.Controls.Add(this.label1);
               this.splitContainer1.Panel1.Controls.Add(this.button2);
               this.splitContainer1.Panel1.Controls.Add(this.button1);
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
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.BackColor = System.Drawing.Color.Silver;
               this.label1.Font = new System.Drawing.Font("Verdana", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(18, 28);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(344, 45);
               this.label1.TabIndex = 5;
               this.label1.Text = "Movie Schedule";
               this.label1.Click += new System.EventHandler(this.label1_Click_1);
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
               // splitContainer2
               // 
               this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
               this.splitContainer2.Location = new System.Drawing.Point(0, 0);
               this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
               this.splitContainer2.Name = "splitContainer2";
               // 
               // splitContainer2.Panel1
               // 
               this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
               // 
               // splitContainer2.Panel2
               // 
               this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Maroon;
               this.splitContainer2.Panel2.Controls.Add(this.Concessions);
               this.splitContainer2.Panel2.Controls.Add(this.pictureBox1);
               this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
               this.splitContainer2.Size = new System.Drawing.Size(805, 980);
               this.splitContainer2.SplitterDistance = 206;
               this.splitContainer2.SplitterWidth = 6;
               this.splitContainer2.TabIndex = 0;
               // 
               // Concessions
               // 
               this.Concessions.AutoSize = true;
               this.Concessions.BackColor = System.Drawing.Color.Silver;
               this.Concessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
               this.Concessions.Location = new System.Drawing.Point(15, 13);
               this.Concessions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.Concessions.Name = "Concessions";
               this.Concessions.Size = new System.Drawing.Size(259, 48);
               this.Concessions.TabIndex = 1;
               this.Concessions.Text = "Concessions";
               this.Concessions.Click += new System.EventHandler(this.label1_Click);
               // 
               // pictureBox1
               // 
               this.pictureBox1.BackColor = System.Drawing.Color.White;
               this.pictureBox1.Location = new System.Drawing.Point(24, 87);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(367, 258);
               this.pictureBox1.TabIndex = 0;
               this.pictureBox1.TabStop = false;
               // 
               // AppWindow
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1214, 980);
               this.Controls.Add(this.splitContainer1);
               this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label Concessions;
          private System.Windows.Forms.Button button1;
          private System.Windows.Forms.Button button2;
          private System.Windows.Forms.Label label1;
     }
}

