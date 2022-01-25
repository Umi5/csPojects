
namespace vista
{
    partial class Main_view
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
            this.btnHome = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLib = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMoneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeControl1 = new vista.User_Control.homeControl();
            this.libControl1 = new vista.User_Control.libControl();
            this.shopControl1 = new vista.User_Control.shopControl();
            this.profileControl1 = new vista.User_Control.profileControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHome.Location = new System.Drawing.Point(49, 27);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(158, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "⌂";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnShop
            // 
            this.btnShop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnShop.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnShop.Location = new System.Drawing.Point(229, 27);
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(158, 55);
            this.btnShop.TabIndex = 1;
            this.btnShop.Text = "🛒";
            this.btnShop.UseVisualStyleBackColor = false;
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnProfile);
            this.panel1.Controls.Add(this.btnLib);
            this.panel1.Controls.Add(this.btnShop);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 116);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Profile";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Library";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Home";
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProfile.Location = new System.Drawing.Point(589, 27);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(158, 55);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "👤";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLib
            // 
            this.btnLib.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLib.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLib.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLib.Location = new System.Drawing.Point(409, 27);
            this.btnLib.Name = "btnLib";
            this.btnLib.Size = new System.Drawing.Size(158, 55);
            this.btnLib.TabIndex = 2;
            this.btnLib.Text = "🕮";
            this.btnLib.UseVisualStyleBackColor = false;
            this.btnLib.Click += new System.EventHandler(this.btnLib_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMoneyToolStripMenuItem,
            this.buyGameToolStripMenuItem,
            this.sellGameToolStripMenuItem,
            this.changeDescriptionToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // addMoneyToolStripMenuItem
            // 
            this.addMoneyToolStripMenuItem.Name = "addMoneyToolStripMenuItem";
            this.addMoneyToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addMoneyToolStripMenuItem.Text = "Add Money";
            this.addMoneyToolStripMenuItem.Click += new System.EventHandler(this.addMoneyToolStripMenuItem_Click);
            // 
            // buyGameToolStripMenuItem
            // 
            this.buyGameToolStripMenuItem.Name = "buyGameToolStripMenuItem";
            this.buyGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.buyGameToolStripMenuItem.Text = "Buy Game";
            this.buyGameToolStripMenuItem.Click += new System.EventHandler(this.buyGameToolStripMenuItem_Click);
            // 
            // sellGameToolStripMenuItem
            // 
            this.sellGameToolStripMenuItem.Name = "sellGameToolStripMenuItem";
            this.sellGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sellGameToolStripMenuItem.Text = "Sell Game";
            this.sellGameToolStripMenuItem.Click += new System.EventHandler(this.sellGameToolStripMenuItem_Click);
            // 
            // changeDescriptionToolStripMenuItem
            // 
            this.changeDescriptionToolStripMenuItem.Name = "changeDescriptionToolStripMenuItem";
            this.changeDescriptionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeDescriptionToolStripMenuItem.Text = "Change Description";
            this.changeDescriptionToolStripMenuItem.Click += new System.EventHandler(this.changeDescriptionToolStripMenuItem_Click);
            // 
            // homeControl1
            // 
            this.homeControl1.AutoScroll = true;
            this.homeControl1.AutoSize = true;
            this.homeControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.homeControl1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.homeControl1.Location = new System.Drawing.Point(-3, 111);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(800, 413);
            this.homeControl1.TabIndex = 1;
            this.homeControl1.userValue = null;
            // 
            // libControl1
            // 
            this.libControl1.AutoScroll = true;
            this.libControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.libControl1.Location = new System.Drawing.Point(-3, 104);
            this.libControl1.Name = "libControl1";
            this.libControl1.Size = new System.Drawing.Size(803, 420);
            this.libControl1.TabIndex = 8;
            this.libControl1.userValue = null;
            // 
            // shopControl1
            // 
            this.shopControl1.AutoScroll = true;
            this.shopControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.shopControl1.Location = new System.Drawing.Point(0, 111);
            this.shopControl1.Name = "shopControl1";
            this.shopControl1.Size = new System.Drawing.Size(800, 413);
            this.shopControl1.TabIndex = 9;
            this.shopControl1.userValue = null;
            // 
            // profileControl1
            // 
            this.profileControl1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.profileControl1.Location = new System.Drawing.Point(0, 111);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(800, 413);
            this.profileControl1.TabIndex = 8;
            this.profileControl1.userValue = null;
            // 
            // Main_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.profileControl1);
            this.Controls.Add(this.shopControl1);
            this.Controls.Add(this.libControl1);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_view";
            this.Text = "Steam 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.user_view_FormClosed);
            this.Load += new System.EventHandler(this.Main_view_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private User_Control.homeControl homeControl1;
        private User_Control.libControl libControl1;
        private User_Control.shopControl shopControl1;
        private User_Control.profileControl profileControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMoneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeDescriptionToolStripMenuItem;
    }
}