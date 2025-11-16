namespace BLGuga
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHP = new System.Windows.Forms.Label();
            this.lblTurns = new System.Windows.Forms.Label();
            this.lblRarita = new System.Windows.Forms.Label();
            this.imgCompagnia = new System.Windows.Forms.PictureBox();
            this.lblNomeLeggendaria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCompagnia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(277, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "          ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.BackColor = System.Drawing.Color.Transparent;
            this.lblHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHP.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHP.Location = new System.Drawing.Point(226, 469);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(41, 29);
            this.lblHP.TabIndex = 1;
            this.lblHP.Text = "20";
            // 
            // lblTurns
            // 
            this.lblTurns.AutoSize = true;
            this.lblTurns.BackColor = System.Drawing.Color.Transparent;
            this.lblTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurns.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblTurns.Location = new System.Drawing.Point(459, 469);
            this.lblTurns.Name = "lblTurns";
            this.lblTurns.Size = new System.Drawing.Size(41, 29);
            this.lblTurns.TabIndex = 2;
            this.lblTurns.Text = "20";
            // 
            // lblRarita
            // 
            this.lblRarita.BackColor = System.Drawing.Color.Transparent;
            this.lblRarita.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.lblRarita.ForeColor = System.Drawing.Color.Red;
            this.lblRarita.Location = new System.Drawing.Point(224, -2);
            this.lblRarita.Name = "lblRarita";
            this.lblRarita.Size = new System.Drawing.Size(276, 46);
            this.lblRarita.TabIndex = 3;
            this.lblRarita.Text = " ";
            this.lblRarita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgCompagnia
            // 
            this.imgCompagnia.BackColor = System.Drawing.Color.Transparent;
            this.imgCompagnia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCompagnia.ErrorImage = null;
            this.imgCompagnia.InitialImage = null;
            this.imgCompagnia.Location = new System.Drawing.Point(244, 373);
            this.imgCompagnia.Name = "imgCompagnia";
            this.imgCompagnia.Size = new System.Drawing.Size(237, 60);
            this.imgCompagnia.TabIndex = 4;
            this.imgCompagnia.TabStop = false;
            // 
            // lblNomeLeggendaria
            // 
            this.lblNomeLeggendaria.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeLeggendaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLeggendaria.Location = new System.Drawing.Point(64, 524);
            this.lblNomeLeggendaria.Name = "lblNomeLeggendaria";
            this.lblNomeLeggendaria.Size = new System.Drawing.Size(596, 46);
            this.lblNomeLeggendaria.TabIndex = 5;
            this.lblNomeLeggendaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BLGuga.Properties.Resources.Shield;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(724, 586);
            this.Controls.Add(this.lblNomeLeggendaria);
            this.Controls.Add(this.imgCompagnia);
            this.Controls.Add(this.lblRarita);
            this.Controls.Add(this.lblTurns);
            this.Controls.Add(this.lblHP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.Text = "Borderlands Loot Generator";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form3_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.imgCompagnia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.Label lblTurns;
        private System.Windows.Forms.Label lblRarita;
        private System.Windows.Forms.PictureBox imgCompagnia;
        private System.Windows.Forms.Label lblNomeLeggendaria;
    }
}