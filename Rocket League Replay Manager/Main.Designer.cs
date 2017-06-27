namespace Rocket_League_Replay_Manager
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.img_RLPic = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtReplayDirectory = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.prgbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblFileCopied = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.img_RLPic)).BeginInit();
            this.SuspendLayout();
            // 
            // img_RLPic
            // 
            this.img_RLPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.img_RLPic.Image = global::Rocket_League_Replay_Manager.Properties.Resources.RLPic;
            this.img_RLPic.Location = new System.Drawing.Point(264, -12);
            this.img_RLPic.Name = "img_RLPic";
            this.img_RLPic.Size = new System.Drawing.Size(156, 155);
            this.img_RLPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_RLPic.TabIndex = 0;
            this.img_RLPic.TabStop = false;
            this.img_RLPic.Click += new System.EventHandler(this.RLPic_Click);
            this.img_RLPic.MouseEnter += new System.EventHandler(this.RLPic_MouseEnter);
            this.img_RLPic.MouseLeave += new System.EventHandler(this.img_RLPic_MouseLeave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Tele-Marines", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(44, 48);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(167, 44);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "RLR";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Tele-Marines", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(459, 58);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(243, 30);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Manager";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 143);
            this.panel1.TabIndex = 3;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnExport
            // 
            this.btnExport.Activecolor = System.Drawing.Color.Silver;
            this.btnExport.BackColor = System.Drawing.Color.Silver;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderRadius = 0;
            this.btnExport.ButtonText = "Export";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DisabledColor = System.Drawing.Color.Gray;
            this.btnExport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnExport.Iconimage")));
            this.btnExport.Iconimage_right = null;
            this.btnExport.Iconimage_right_Selected = null;
            this.btnExport.Iconimage_Selected = null;
            this.btnExport.IconMarginLeft = 0;
            this.btnExport.IconMarginRight = 0;
            this.btnExport.IconRightVisible = true;
            this.btnExport.IconRightZoom = 0D;
            this.btnExport.IconVisible = true;
            this.btnExport.IconZoom = 90D;
            this.btnExport.IsTab = false;
            this.btnExport.Location = new System.Drawing.Point(464, 232);
            this.btnExport.Name = "btnExport";
            this.btnExport.Normalcolor = System.Drawing.Color.Silver;
            this.btnExport.OnHovercolor = System.Drawing.Color.Gray;
            this.btnExport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExport.selected = false;
            this.btnExport.Size = new System.Drawing.Size(199, 52);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Textcolor = System.Drawing.Color.White;
            this.btnExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Activecolor = System.Drawing.Color.Silver;
            this.btnImport.BackColor = System.Drawing.Color.Silver;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderRadius = 0;
            this.btnImport.ButtonText = "Import";
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.DisabledColor = System.Drawing.Color.Gray;
            this.btnImport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImport.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnImport.Iconimage")));
            this.btnImport.Iconimage_right = null;
            this.btnImport.Iconimage_right_Selected = null;
            this.btnImport.Iconimage_Selected = null;
            this.btnImport.IconMarginLeft = 0;
            this.btnImport.IconMarginRight = 0;
            this.btnImport.IconRightVisible = true;
            this.btnImport.IconRightZoom = 0D;
            this.btnImport.IconVisible = true;
            this.btnImport.IconZoom = 90D;
            this.btnImport.IsTab = false;
            this.btnImport.Location = new System.Drawing.Point(464, 174);
            this.btnImport.Name = "btnImport";
            this.btnImport.Normalcolor = System.Drawing.Color.Silver;
            this.btnImport.OnHovercolor = System.Drawing.Color.Gray;
            this.btnImport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImport.selected = false;
            this.btnImport.Size = new System.Drawing.Size(199, 52);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "Import";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Textcolor = System.Drawing.Color.White;
            this.btnImport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtReplayDirectory
            // 
            this.txtReplayDirectory.BackColor = System.Drawing.Color.Silver;
            this.txtReplayDirectory.BorderColorFocused = System.Drawing.Color.Silver;
            this.txtReplayDirectory.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtReplayDirectory.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.txtReplayDirectory.BorderThickness = 3;
            this.txtReplayDirectory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReplayDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtReplayDirectory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReplayDirectory.isPassword = false;
            this.txtReplayDirectory.Location = new System.Drawing.Point(13, 174);
            this.txtReplayDirectory.Margin = new System.Windows.Forms.Padding(4);
            this.txtReplayDirectory.Name = "txtReplayDirectory";
            this.txtReplayDirectory.Size = new System.Drawing.Size(296, 43);
            this.txtReplayDirectory.TabIndex = 6;
            this.txtReplayDirectory.Text = "%USERPROFILE%\\Documents\\My Games\\Rocket League\\TAGame\\Demos";
            this.txtReplayDirectory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // prgbar1
            // 
            this.prgbar1.animated = false;
            this.prgbar1.animationIterval = 5;
            this.prgbar1.animationSpeed = 300;
            this.prgbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.prgbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prgbar1.BackgroundImage")));
            this.prgbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.prgbar1.ForeColor = System.Drawing.Color.Silver;
            this.prgbar1.LabelVisible = true;
            this.prgbar1.LineProgressThickness = 8;
            this.prgbar1.LineThickness = 5;
            this.prgbar1.Location = new System.Drawing.Point(558, 326);
            this.prgbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.prgbar1.MaxValue = 100;
            this.prgbar1.Name = "prgbar1";
            this.prgbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.prgbar1.ProgressColor = System.Drawing.Color.White;
            this.prgbar1.Size = new System.Drawing.Size(144, 144);
            this.prgbar1.TabIndex = 7;
            this.prgbar1.Value = 0;
            this.prgbar1.Visible = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(12, 152);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(273, 18);
            this.bunifuCustomLabel3.TabIndex = 8;
            this.bunifuCustomLabel3.Text = "Replay Directory (only change if needed)";
            // 
            // dropdown1
            // 
            this.dropdown1.AutoScroll = true;
            this.dropdown1.BackColor = System.Drawing.Color.Transparent;
            this.dropdown1.BorderRadius = 3;
            this.dropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.dropdown1.ForeColor = System.Drawing.Color.White;
            this.dropdown1.Items = new string[0];
            this.dropdown1.Location = new System.Drawing.Point(13, 228);
            this.dropdown1.Name = "dropdown1";
            this.dropdown1.NomalColor = System.Drawing.Color.Silver;
            this.dropdown1.onHoverColor = System.Drawing.Color.Silver;
            this.dropdown1.selectedIndex = -1;
            this.dropdown1.Size = new System.Drawing.Size(217, 35);
            this.dropdown1.TabIndex = 9;
            // 
            // lblFileCopied
            // 
            this.lblFileCopied.AutoSize = true;
            this.lblFileCopied.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileCopied.ForeColor = System.Drawing.Color.White;
            this.lblFileCopied.Location = new System.Drawing.Point(6, 452);
            this.lblFileCopied.Name = "lblFileCopied";
            this.lblFileCopied.Size = new System.Drawing.Size(102, 16);
            this.lblFileCopied.TabIndex = 10;
            this.lblFileCopied.Text = "Informative Text";
            this.lblFileCopied.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(714, 479);
            this.Controls.Add(this.lblFileCopied);
            this.Controls.Add(this.dropdown1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.prgbar1);
            this.Controls.Add(this.txtReplayDirectory);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.img_RLPic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "RLR Manager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.img_RLPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_RLPic;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnExport;
        private Bunifu.Framework.UI.BunifuFlatButton btnImport;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtReplayDirectory;
        private Bunifu.Framework.UI.BunifuCircleProgressbar prgbar1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown dropdown1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFileCopied;
    }
}

