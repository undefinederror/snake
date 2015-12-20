namespace Snake
{
    partial class frmSnake
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScoreTxt
            // 
            resources.ApplyResources(this.lblScoreTxt, "lblScoreTxt");
            this.lblScoreTxt.Name = "lblScoreTxt";
            // 
            // lblScoreVal
            // 
            resources.ApplyResources(this.lblScoreVal, "lblScoreVal");
            this.lblScoreVal.Name = "lblScoreVal";
            // 
            // lblGameOver
            // 
            resources.ApplyResources(this.lblGameOver, "lblGameOver");
            this.lblGameOver.Name = "lblGameOver";
            // 
            // pbCanvas
            // 
            resources.ApplyResources(this.pbCanvas, "pbCanvas");
            this.pbCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // frmSnake
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScoreVal);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.pbCanvas);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmSnake";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSnake_FormClosed);
            this.Shown += new System.EventHandler(this.frmSnake_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblScoreTxt;
        private System.Windows.Forms.Label lblScoreVal;
        private System.Windows.Forms.Label lblGameOver;
    }
}