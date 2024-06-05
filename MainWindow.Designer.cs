using System.Collections.Generic;
using System.Windows.Forms;

namespace Modelarz
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonKatalog = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.guna2Button4);
            this.panelMenu.Controls.Add(this.guna2Button3);
            this.panelMenu.Controls.Add(this.guna2Button1);
            this.panelMenu.Controls.Add(this.guna2Button2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.buttonExport);
            this.panelMenu.Controls.Add(this.buttonKatalog);
            this.panelMenu.Controls.Add(this.buttonHome);
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Location = new System.Drawing.Point(-1, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(125, 613);
            this.panelMenu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(121, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 613);
            this.panel1.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExport.FlatAppearance.BorderSize = 0;
            this.buttonExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonExport.Image = ((System.Drawing.Image)(resources.GetObject("buttonExport.Image")));
            this.buttonExport.Location = new System.Drawing.Point(22, 112);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(80, 44);
            this.buttonExport.TabIndex = 6;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Visible = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonKatalog
            // 
            this.buttonKatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonKatalog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonKatalog.FlatAppearance.BorderSize = 0;
            this.buttonKatalog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonKatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonKatalog.Image = ((System.Drawing.Image)(resources.GetObject("buttonKatalog.Image")));
            this.buttonKatalog.Location = new System.Drawing.Point(22, 62);
            this.buttonKatalog.Name = "buttonKatalog";
            this.buttonKatalog.Size = new System.Drawing.Size(80, 44);
            this.buttonKatalog.TabIndex = 3;
            this.buttonKatalog.UseVisualStyleBackColor = false;
            this.buttonKatalog.Visible = false;
            this.buttonKatalog.Click += new System.EventHandler(this.buttonKatalog_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonHome.Image = global::Modelarz.Properties.Resources.home;
            this.buttonHome.Location = new System.Drawing.Point(22, 12);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(80, 44);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Visible = false;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(22, 555);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 44);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Location = new System.Drawing.Point(122, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(762, 613);
            this.panelMain.TabIndex = 3;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button2.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(22, 12);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(80, 45);
            this.guna2Button2.TabIndex = 11;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            this.guna2Button2.MouseEnter += new System.EventHandler(this.guna2Button2_MouseEnter);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button1.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(22, 63);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(80, 45);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            this.guna2Button1.MouseEnter += new System.EventHandler(this.guna2Button1_MouseEnter);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.BorderThickness = 2;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button3.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button3.Location = new System.Drawing.Point(22, 114);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(80, 45);
            this.guna2Button3.TabIndex = 13;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            this.guna2Button3.MouseEnter += new System.EventHandler(this.guna2Button3_MouseEnter);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.BorderThickness = 2;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Button4.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageSize = new System.Drawing.Size(32, 32);
            this.guna2Button4.Location = new System.Drawing.Point(22, 555);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(80, 45);
            this.guna2Button4.TabIndex = 14;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            this.guna2Button4.MouseEnter += new System.EventHandler(this.guna2Button4_MouseEnter);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(884, 611);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modelarz";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonKatalog;
        private System.Windows.Forms.Button buttonExport;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
