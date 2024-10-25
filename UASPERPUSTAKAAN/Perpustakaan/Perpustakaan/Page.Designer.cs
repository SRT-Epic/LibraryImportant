namespace Perpustakaan
{
    partial class Page
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GENRESLabel = new System.Windows.Forms.Label();
            this.PenulisNameBook = new System.Windows.Forms.Label();
            this.PublishNameBook = new System.Windows.Forms.Label();
            this.DescriptionNameBook = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PageNameBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureCover = new System.Windows.Forms.PictureBox();
            this.CommentPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.roundButton2 = new Perpustakaan.RoundButton();
            this.roundButton1 = new Perpustakaan.RoundButton();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.profilePanel);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CommentPanel);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.roundButton2);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.GenreLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.GENRESLabel);
            this.panel1.Controls.Add(this.roundButton1);
            this.panel1.Controls.Add(this.PenulisNameBook);
            this.panel1.Controls.Add(this.PublishNameBook);
            this.panel1.Controls.Add(this.DescriptionNameBook);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PageNameBook);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureCover);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1892, 961);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 668);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(664, 97);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 36);
            this.label4.TabIndex = 16;
            this.label4.Text = "Comment";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.Gray;
            this.TitleLabel.Location = new System.Drawing.Point(393, 94);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(77, 27);
            this.TitleLabel.TabIndex = 14;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(362, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 27);
            this.label8.TabIndex = 13;
            this.label8.Text = ">";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreLabel.ForeColor = System.Drawing.Color.Gray;
            this.GenreLabel.Location = new System.Drawing.Point(254, 94);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(77, 27);
            this.GenreLabel.TabIndex = 12;
            this.GenreLabel.Text = "Genre";
            this.GenreLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(223, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = ">";
            // 
            // GENRESLabel
            // 
            this.GENRESLabel.AutoSize = true;
            this.GENRESLabel.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENRESLabel.ForeColor = System.Drawing.Color.Gray;
            this.GENRESLabel.Location = new System.Drawing.Point(127, 94);
            this.GENRESLabel.Name = "GENRESLabel";
            this.GENRESLabel.Size = new System.Drawing.Size(90, 27);
            this.GENRESLabel.TabIndex = 10;
            this.GENRESLabel.Text = "GENRES";
            this.GENRESLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // PenulisNameBook
            // 
            this.PenulisNameBook.AutoSize = true;
            this.PenulisNameBook.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PenulisNameBook.Location = new System.Drawing.Point(482, 326);
            this.PenulisNameBook.Name = "PenulisNameBook";
            this.PenulisNameBook.Size = new System.Drawing.Size(168, 27);
            this.PenulisNameBook.TabIndex = 8;
            this.PenulisNameBook.Text = "DESCRIPTION:";
            // 
            // PublishNameBook
            // 
            this.PublishNameBook.AutoSize = true;
            this.PublishNameBook.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishNameBook.Location = new System.Drawing.Point(482, 211);
            this.PublishNameBook.Name = "PublishNameBook";
            this.PublishNameBook.Size = new System.Drawing.Size(168, 27);
            this.PublishNameBook.TabIndex = 7;
            this.PublishNameBook.Text = "DESCRIPTION:";
            // 
            // DescriptionNameBook
            // 
            this.DescriptionNameBook.AutoSize = true;
            this.DescriptionNameBook.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionNameBook.Location = new System.Drawing.Point(482, 431);
            this.DescriptionNameBook.Name = "DescriptionNameBook";
            this.DescriptionNameBook.Size = new System.Drawing.Size(168, 27);
            this.DescriptionNameBook.TabIndex = 6;
            this.DescriptionNameBook.Text = "DESCRIPTION:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "DESCRIPTION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(482, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "PENULIS:";
            // 
            // PageNameBook
            // 
            this.PageNameBook.AutoSize = true;
            this.PageNameBook.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageNameBook.Location = new System.Drawing.Point(482, 124);
            this.PageNameBook.Name = "PageNameBook";
            this.PageNameBook.Size = new System.Drawing.Size(77, 27);
            this.PageNameBook.TabIndex = 3;
            this.PageNameBook.Text = "Title";
            this.PageNameBook.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "PUBLISHED:";
            // 
            // pictureCover
            // 
            this.pictureCover.Location = new System.Drawing.Point(132, 124);
            this.pictureCover.Name = "pictureCover";
            this.pictureCover.Size = new System.Drawing.Size(316, 456);
            this.pictureCover.TabIndex = 0;
            this.pictureCover.TabStop = false;
            // 
            // CommentPanel
            // 
            this.CommentPanel.AutoScroll = true;
            this.CommentPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CommentPanel.Location = new System.Drawing.Point(135, 786);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.Size = new System.Drawing.Size(653, 248);
            this.CommentPanel.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(819, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 75);
            this.button1.TabIndex = 20;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // roundButton2
            // 
            this.roundButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundButton2.FlatAppearance.BorderSize = 0;
            this.roundButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(190)))), ((int)(((byte)(185)))));
            this.roundButton2.Location = new System.Drawing.Point(474, 528);
            this.roundButton2.Name = "roundButton2";
            this.roundButton2.Size = new System.Drawing.Size(161, 52);
            this.roundButton2.TabIndex = 15;
            this.roundButton2.Text = "Add To Cart";
            this.roundButton2.UseVisualStyleBackColor = false;
            this.roundButton2.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(190)))), ((int)(((byte)(185)))));
            this.roundButton1.FlatAppearance.BorderSize = 0;
            this.roundButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundButton1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundButton1.ForeColor = System.Drawing.Color.White;
            this.roundButton1.Location = new System.Drawing.Point(641, 528);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(156, 52);
            this.roundButton1.TabIndex = 9;
            this.roundButton1.Text = "Rent Now";
            this.roundButton1.UseVisualStyleBackColor = false;
            this.roundButton1.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // profilePanel
            // 
            this.profilePanel.AutoScroll = true;
            this.profilePanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.profilePanel.Location = new System.Drawing.Point(54, 786);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(75, 248);
            this.profilePanel.TabIndex = 20;
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1892, 961);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Page";
            this.Text = "Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureCover;
        private System.Windows.Forms.Label PageNameBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PenulisNameBook;
        private System.Windows.Forms.Label PublishNameBook;
        private System.Windows.Forms.Label DescriptionNameBook;
        private System.Windows.Forms.Label label3;
        private RoundButton roundButton1;
        private System.Windows.Forms.Label GENRESLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label label5;
        private RoundButton roundButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel CommentPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel profilePanel;
    }
}