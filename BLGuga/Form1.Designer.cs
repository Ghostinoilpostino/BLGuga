namespace BLGuga
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblRarMod = new System.Windows.Forms.Label();
            this.inputRarMod = new System.Windows.Forms.NumericUpDown();
            this.lbl12 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lblRollMod = new System.Windows.Forms.Label();
            this.inputRollMod = new System.Windows.Forms.ComboBox();
            this.btnZaino = new System.Windows.Forms.Button();
            this.btnZainoDebug = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputRarMod)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.Location = new System.Drawing.Point(343, 380);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(113, 50);
            this.btnGenerate.TabIndex = 0;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblRarMod
            // 
            this.lblRarMod.AutoSize = true;
            this.lblRarMod.BackColor = System.Drawing.Color.Transparent;
            this.lblRarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblRarMod.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRarMod.Location = new System.Drawing.Point(253, 570);
            this.lblRarMod.Name = "lblRarMod";
            this.lblRarMod.Size = new System.Drawing.Size(143, 24);
            this.lblRarMod.TabIndex = 1;
            this.lblRarMod.Text = "Rarity Modifier";
            // 
            // inputRarMod
            // 
            this.inputRarMod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRarMod.AutoSize = true;
            this.inputRarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRarMod.Location = new System.Drawing.Point(407, 569);
            this.inputRarMod.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputRarMod.Name = "inputRarMod";
            this.inputRarMod.Size = new System.Drawing.Size(120, 26);
            this.inputRarMod.TabIndex = 2;
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.BackColor = System.Drawing.Color.Transparent;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl12.ForeColor = System.Drawing.Color.Red;
            this.lbl12.Location = new System.Drawing.Point(573, 121);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(80, 55);
            this.lbl12.TabIndex = 3;
            this.lbl12.Text = "12";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.BackColor = System.Drawing.Color.Transparent;
            this.lbl20.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl20.Location = new System.Drawing.Point(573, 283);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(80, 55);
            this.lbl20.TabIndex = 4;
            this.lbl20.Text = "20";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.Transparent;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl6.ForeColor = System.Drawing.Color.Cyan;
            this.lbl6.Location = new System.Drawing.Point(587, 454);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(52, 55);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "6";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.BackColor = System.Drawing.Color.Transparent;
            this.lbl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl10.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbl10.Location = new System.Drawing.Point(140, 121);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(80, 55);
            this.lbl10.TabIndex = 6;
            this.lbl10.Text = "10";
            this.lbl10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.BackColor = System.Drawing.Color.Transparent;
            this.lbl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl8.Location = new System.Drawing.Point(156, 283);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(52, 55);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "8";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl4.Location = new System.Drawing.Point(156, 454);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(52, 55);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "4";
            // 
            // lbl100
            // 
            this.lbl100.AutoSize = true;
            this.lbl100.BackColor = System.Drawing.Color.Transparent;
            this.lbl100.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl100.ForeColor = System.Drawing.Color.Lime;
            this.lbl100.Location = new System.Drawing.Point(348, 158);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(105, 55);
            this.lbl100.TabIndex = 9;
            this.lbl100.Text = "100";
            this.lbl100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRollMod
            // 
            this.lblRollMod.AutoSize = true;
            this.lblRollMod.BackColor = System.Drawing.Color.Transparent;
            this.lblRollMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblRollMod.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRollMod.Location = new System.Drawing.Point(276, 70);
            this.lblRollMod.Name = "lblRollMod";
            this.lblRollMod.Size = new System.Drawing.Size(127, 24);
            this.lblRollMod.TabIndex = 10;
            this.lblRollMod.Text = "Roll Modifier";
            // 
            // inputRollMod
            // 
            this.inputRollMod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputRollMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputRollMod.FormattingEnabled = true;
            this.inputRollMod.Items.AddRange(new object[] {
            "None",
            "Weapon",
            "Grenade",
            "Relic",
            "Shield",
            "Equipment"});
            this.inputRollMod.Location = new System.Drawing.Point(406, 68);
            this.inputRollMod.Name = "inputRollMod";
            this.inputRollMod.Size = new System.Drawing.Size(121, 28);
            this.inputRollMod.TabIndex = 11;
            // 
            // btnZaino
            // 
            this.btnZaino.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnZaino.Location = new System.Drawing.Point(680, 574);
            this.btnZaino.Name = "btnZaino";
            this.btnZaino.Size = new System.Drawing.Size(66, 25);
            this.btnZaino.TabIndex = 12;
            this.btnZaino.Tag = "DEBUG";
            this.btnZaino.Text = "Zaino";
            this.btnZaino.UseVisualStyleBackColor = true;
            this.btnZaino.Click += new System.EventHandler(this.btnZaino_Click);
            // 
            // btnZainoDebug
            // 
            this.btnZainoDebug.Location = new System.Drawing.Point(31, 564);
            this.btnZainoDebug.Name = "btnZainoDebug";
            this.btnZainoDebug.Size = new System.Drawing.Size(130, 40);
            this.btnZainoDebug.TabIndex = 13;
            this.btnZainoDebug.Text = "DEBUG ZAINO";
            this.btnZainoDebug.UseVisualStyleBackColor = true;
            this.btnZainoDebug.Click += new System.EventHandler(this.btnZainoDebug_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.btnZainoDebug);
            this.Controls.Add(this.btnZaino);
            this.Controls.Add(this.inputRollMod);
            this.Controls.Add(this.lblRollMod);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.inputRarMod);
            this.Controls.Add(this.lblRarMod);
            this.Controls.Add(this.btnGenerate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Borderlands Loot Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputRarMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblRarMod;
        private System.Windows.Forms.NumericUpDown inputRarMod;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lblRollMod;
        private System.Windows.Forms.ComboBox inputRollMod;
        private System.Windows.Forms.Button btnZaino;
        private System.Windows.Forms.Button btnZainoDebug;
    }
}

