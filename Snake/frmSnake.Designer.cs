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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblScoreTxt = new System.Windows.Forms.Label();
            this.lblScoreVal = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbCanvas.Location = new System.Drawing.Point(12, 12);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(646, 454);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // lblScoreTxt
            // 
            this.lblScoreTxt.AutoSize = true;
            this.lblScoreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTxt.Location = new System.Drawing.Point(697, 26);
            this.lblScoreTxt.Name = "lblScoreTxt";
            this.lblScoreTxt.Size = new System.Drawing.Size(127, 39);
            this.lblScoreTxt.TabIndex = 1;
            this.lblScoreTxt.Text = "Score: ";
            // 
            // lblScoreVal
            // 
            this.lblScoreVal.AutoSize = true;
            this.lblScoreVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreVal.Location = new System.Drawing.Point(704, 94);
            this.lblScoreVal.Name = "lblScoreVal";
            this.lblScoreVal.Size = new System.Drawing.Size(0, 37);
            this.lblScoreVal.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(24, 26);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(100, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label1";
            this.lblGameOver.Visible = false;
            // 
            // frmSnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 496);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScoreVal);
            this.Controls.Add(this.lblScoreTxt);
            this.Controls.Add(this.pbCanvas);
            this.Name = "frmSnake";
            this.Text = "frmSnake";
            this.Load += new System.EventHandler(this.frmSnake_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmSnake_KeyUp);
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