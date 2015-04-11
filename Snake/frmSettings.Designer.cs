namespace Snake
{
    partial class frmSettings
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
            this.SuspendLayout();
            // 
            // frmSettings
            // 
            this.ClientSize = new System.Drawing.Size(990, 499);
            this.Name = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar tbarVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox imgBG;
    }
}