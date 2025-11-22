namespace BLGuga
{
    partial class Form4
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
            this.lswZaino = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lswZaino
            // 
            this.lswZaino.FullRowSelect = true;
            this.lswZaino.HideSelection = false;
            this.lswZaino.Location = new System.Drawing.Point(12, 12);
            this.lswZaino.Name = "lswZaino";
            this.lswZaino.Size = new System.Drawing.Size(473, 470);
            this.lswZaino.TabIndex = 0;
            this.lswZaino.UseCompatibleStateImageBehavior = false;
            this.lswZaino.View = System.Windows.Forms.View.List;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 494);
            this.Controls.Add(this.lswZaino);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lswZaino;
    }
}