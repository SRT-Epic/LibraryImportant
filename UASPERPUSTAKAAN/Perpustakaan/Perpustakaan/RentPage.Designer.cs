namespace Perpustakaan
{
    partial class RentPage
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
            this.GenreLayout = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // GenreLayout
            // 
            this.GenreLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenreLayout.Location = new System.Drawing.Point(0, 0);
            this.GenreLayout.Name = "GenreLayout";
            this.GenreLayout.Size = new System.Drawing.Size(1006, 666);
            this.GenreLayout.TabIndex = 0;
            this.GenreLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.GenreLayout_Paint);
            // 
            // RentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 666);
            this.Controls.Add(this.GenreLayout);
            this.Name = "RentPage";
            this.Text = "RentPage";
            this.Load += new System.EventHandler(this.RentPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GenreLayout;
    }
}