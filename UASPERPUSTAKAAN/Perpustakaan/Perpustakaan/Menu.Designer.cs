namespace Perpustakaan
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ScrollPanel = new System.Windows.Forms.Panel();
            this.TitleHome = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GradientBoxTop = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ScrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradientBoxTop)).BeginInit();
            this.SuspendLayout();
            // 
            // ScrollPanel
            // 
            this.ScrollPanel.AutoScroll = true;
            this.ScrollPanel.Controls.Add(this.label2);
            this.ScrollPanel.Controls.Add(this.label1);
            this.ScrollPanel.Controls.Add(this.pictureBox12);
            this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollPanel.Location = new System.Drawing.Point(0, 517);
            this.ScrollPanel.Name = "ScrollPanel";
            this.ScrollPanel.Padding = new System.Windows.Forms.Padding(2);
            this.ScrollPanel.Size = new System.Drawing.Size(1872, 329);
            this.ScrollPanel.TabIndex = 48;
            // 
            // TitleHome
            // 
            this.TitleHome.AutoSize = true;
            this.TitleHome.BackColor = System.Drawing.Color.Transparent;
            this.TitleHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TitleHome.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleHome.ForeColor = System.Drawing.Color.Transparent;
            this.TitleHome.Location = new System.Drawing.Point(896, 127);
            this.TitleHome.Name = "TitleHome";
            this.TitleHome.Size = new System.Drawing.Size(206, 55);
            this.TitleHome.TabIndex = 49;
            this.TitleHome.Text = "Library";
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(364, 32);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(237, 322);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 46;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Perpustakaan.Properties.Resources.gradient__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-8, 813);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1884, 45);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // GradientBoxTop
            // 
            this.GradientBoxTop.Cursor = System.Windows.Forms.Cursors.Default;
            this.GradientBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.GradientBoxTop.ErrorImage = null;
            this.GradientBoxTop.Image = ((System.Drawing.Image)(resources.GetObject("GradientBoxTop.Image")));
            this.GradientBoxTop.Location = new System.Drawing.Point(0, 0);
            this.GradientBoxTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GradientBoxTop.Name = "GradientBoxTop";
            this.GradientBoxTop.Size = new System.Drawing.Size(1872, 517);
            this.GradientBoxTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GradientBoxTop.TabIndex = 50;
            this.GradientBoxTop.TabStop = false;
            this.GradientBoxTop.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(616, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "The best seller book about the guy name Harry Potter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(614, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 36);
            this.label2.TabIndex = 48;
            this.label2.Text = "Best Seller ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1872, 846);
            this.ControlBox = false;
            this.Controls.Add(this.TitleHome);
            this.Controls.Add(this.ScrollPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GradientBoxTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Collection_Load);
            this.ScrollPanel.ResumeLayout(false);
            this.ScrollPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GradientBoxTop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel ScrollPanel;
        private System.Windows.Forms.Label TitleHome;
        private System.Windows.Forms.PictureBox GradientBoxTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}