namespace Pingpong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sign_up_bt = new System.Windows.Forms.Button();
            this.sign_in_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.sign_up_bt);
            this.panel1.Controls.Add(this.sign_in_bt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 435);
            this.panel1.TabIndex = 0;
            
            // 
            // sign_up_bt
            // 
            this.sign_up_bt.Location = new System.Drawing.Point(186, 310);
            this.sign_up_bt.Name = "sign_up_bt";
            this.sign_up_bt.Size = new System.Drawing.Size(96, 32);
            this.sign_up_bt.TabIndex = 2;
            this.sign_up_bt.Text = "Sign up";
            this.sign_up_bt.UseVisualStyleBackColor = true;
            // 
            // sign_in_bt
            // 
            this.sign_in_bt.Location = new System.Drawing.Point(186, 246);
            this.sign_in_bt.Name = "sign_in_bt";
            this.sign_in_bt.Size = new System.Drawing.Size(96, 34);
            this.sign_in_bt.TabIndex = 1;
            this.sign_in_bt.Text = "Sign in";
            this.sign_in_bt.UseVisualStyleBackColor = true;
            this.sign_in_bt.Click += new System.EventHandler(this.sign_in_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tomato;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(74, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "PingPong";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 435);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sign_up_bt;
        private System.Windows.Forms.Button sign_in_bt;
    }
}