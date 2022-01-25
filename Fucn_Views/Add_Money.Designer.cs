
namespace vista.Fucn_Views
{
    partial class Add_Money
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
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(12, 12);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(234, 42);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "ADD 5€";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(12, 60);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(234, 42);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "ADD 10€";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(12, 108);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(234, 42);
            this.btn20.TabIndex = 2;
            this.btn20.Text = "ADD 20€";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.Location = new System.Drawing.Point(12, 156);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(234, 42);
            this.btn50.TabIndex = 3;
            this.btn50.Text = "ADD 50€";
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btn100
            // 
            this.btn100.Location = new System.Drawing.Point(12, 204);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(234, 42);
            this.btn100.TabIndex = 4;
            this.btn100.Text = "ADD 100€";
            this.btn100.UseVisualStyleBackColor = true;
            this.btn100.Click += new System.EventHandler(this.btn100_Click);
            // 
            // Add_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 254);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Add_Money";
            this.Text = "Add Money";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Add_Money_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
    }
}