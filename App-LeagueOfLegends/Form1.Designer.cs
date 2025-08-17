namespace App_LeagueOfLegends
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCampeones = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLol = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Gray;
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.btnCampeones);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 681);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Little Pat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Azure;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(0, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(200, 60);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Registar";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCampeones
            // 
            this.btnCampeones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCampeones.FlatAppearance.BorderSize = 0;
            this.btnCampeones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCampeones.Font = new System.Drawing.Font("Little Pat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampeones.ForeColor = System.Drawing.Color.Azure;
            this.btnCampeones.Image = ((System.Drawing.Image)(resources.GetObject("btnCampeones.Image")));
            this.btnCampeones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCampeones.Location = new System.Drawing.Point(0, 80);
            this.btnCampeones.Name = "btnCampeones";
            this.btnCampeones.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnCampeones.Size = new System.Drawing.Size(200, 60);
            this.btnCampeones.TabIndex = 3;
            this.btnCampeones.Text = " Campeones";
            this.btnCampeones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCampeones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCampeones.UseVisualStyleBackColor = true;
            this.btnCampeones.Click += new System.EventHandler(this.btnCampeones_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLogo.Controls.Add(this.btnLol);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // btnLol
            // 
            this.btnLol.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLol.FlatAppearance.BorderSize = 0;
            this.btnLol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLol.Image = ((System.Drawing.Image)(resources.GetObject("btnLol.Image")));
            this.btnLol.Location = new System.Drawing.Point(0, 0);
            this.btnLol.Name = "btnLol";
            this.btnLol.Size = new System.Drawing.Size(200, 80);
            this.btnLol.TabIndex = 0;
            this.btnLol.UseVisualStyleBackColor = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelPrincipal.Controls.Add(this.lblBienvenido);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrincipal.Location = new System.Drawing.Point(200, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1064, 80);
            this.panelPrincipal.TabIndex = 2;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenido.Font = new System.Drawing.Font("Molot", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(0, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(441, 73);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "Bienvenido...";
            this.lblBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1918, 1038);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LeagueOfLegends";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnCampeones;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Button btnLol;
    }
}

