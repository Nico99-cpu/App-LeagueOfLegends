namespace App_LeagueOfLegends
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
            this.dgvCampeones = new System.Windows.Forms.DataGridView();
            this.pbCampeones = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCampeones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCampeones
            // 
            this.dgvCampeones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCampeones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampeones.Location = new System.Drawing.Point(12, 23);
            this.dgvCampeones.Name = "dgvCampeones";
            this.dgvCampeones.Size = new System.Drawing.Size(585, 415);
            this.dgvCampeones.TabIndex = 0;
            this.dgvCampeones.SelectionChanged += new System.EventHandler(this.dgvPokemon_SelectionChanged);
            // 
            // pbCampeones
            // 
            this.pbCampeones.Location = new System.Drawing.Point(628, 23);
            this.pbCampeones.Name = "pbCampeones";
            this.pbCampeones.Size = new System.Drawing.Size(385, 335);
            this.pbCampeones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCampeones.TabIndex = 1;
            this.pbCampeones.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 537);
            this.ControlBox = false;
            this.Controls.Add(this.pbCampeones);
            this.Controls.Add(this.dgvCampeones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampeones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCampeones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCampeones;
        private System.Windows.Forms.PictureBox pbCampeones;
    }
}