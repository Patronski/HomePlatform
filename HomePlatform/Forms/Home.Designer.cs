namespace HomePlatform.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGridView = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonGamePacman = new System.Windows.Forms.Button();
            this.buttonGameSnake = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/view home property";
            // 
            // buttonGridView
            // 
            this.buttonGridView.BackColor = System.Drawing.Color.DarkKhaki;
            this.buttonGridView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGridView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGridView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonGridView.Location = new System.Drawing.Point(12, 25);
            this.buttonGridView.Name = "buttonGridView";
            this.buttonGridView.Size = new System.Drawing.Size(144, 40);
            this.buttonGridView.TabIndex = 2;
            this.buttonGridView.Text = "Home property";
            this.buttonGridView.UseVisualStyleBackColor = false;
            this.buttonGridView.Click += new System.EventHandler(this.buttonGridView_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.buttonLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogOut.ForeColor = System.Drawing.Color.Black;
            this.buttonLogOut.Location = new System.Drawing.Point(203, 2);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(50, 20);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLogOut.UseVisualStyleBackColor = false;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonGamePacman
            // 
            this.buttonGamePacman.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGamePacman.FlatAppearance.BorderSize = 0;
            this.buttonGamePacman.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGamePacman.Image = ((System.Drawing.Image)(resources.GetObject("buttonGamePacman.Image")));
            this.buttonGamePacman.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonGamePacman.Location = new System.Drawing.Point(12, 154);
            this.buttonGamePacman.Name = "buttonGamePacman";
            this.buttonGamePacman.Size = new System.Drawing.Size(109, 128);
            this.buttonGamePacman.TabIndex = 4;
            this.buttonGamePacman.UseVisualStyleBackColor = true;
            this.buttonGamePacman.Click += new System.EventHandler(this.buttonGamePacman_Click);
            // 
            // buttonGameSnake
            // 
            this.buttonGameSnake.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGameSnake.FlatAppearance.BorderSize = 0;
            this.buttonGameSnake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameSnake.Image = ((System.Drawing.Image)(resources.GetObject("buttonGameSnake.Image")));
            this.buttonGameSnake.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonGameSnake.Location = new System.Drawing.Point(127, 154);
            this.buttonGameSnake.Name = "buttonGameSnake";
            this.buttonGameSnake.Size = new System.Drawing.Size(126, 128);
            this.buttonGameSnake.TabIndex = 6;
            this.buttonGameSnake.UseVisualStyleBackColor = true;
            this.buttonGameSnake.Click += new System.EventHandler(this.buttonGameSnake_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pacman game - will be installed for first time!";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(260, 284);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonGameSnake);
            this.Controls.Add(this.buttonGamePacman);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonGridView);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGridView;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonGamePacman;
        private System.Windows.Forms.Button buttonGameSnake;
        private System.Windows.Forms.Label label2;
    }
}