
namespace TicTacToe_Irica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.New = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Location = new System.Drawing.Point(18, 90);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(130, 130);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_Click);
            // 
            // A2
            // 
            this.A2.Location = new System.Drawing.Point(146, 90);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(130, 130);
            this.A2.TabIndex = 1;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_Click);
            // 
            // A3
            // 
            this.A3.Location = new System.Drawing.Point(274, 90);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(130, 130);
            this.A3.TabIndex = 2;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(274, 218);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(130, 130);
            this.B3.TabIndex = 5;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(146, 218);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(130, 130);
            this.B2.TabIndex = 4;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(18, 218);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(130, 130);
            this.B1.TabIndex = 3;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_Click);
            // 
            // C3
            // 
            this.C3.Location = new System.Drawing.Point(274, 346);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(130, 130);
            this.C3.TabIndex = 8;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_Click);
            // 
            // C2
            // 
            this.C2.Location = new System.Drawing.Point(146, 346);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(130, 130);
            this.C2.TabIndex = 7;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_Click);
            // 
            // C1
            // 
            this.C1.Location = new System.Drawing.Point(18, 346);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(130, 130);
            this.C1.TabIndex = 6;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_Click);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About,
            this.New,
            this.Help});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(423, 33);
            this.Menu.TabIndex = 9;
            this.Menu.Text = "Menu";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(78, 29);
            this.About.Text = "&About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // New
            // 
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(114, 29);
            this.New.Text = "&New Game";
            this.New.Click += new System.EventHandler(this.New_Game);
            // 
            // Help
            // 
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(124, 29);
            this.Help.Text = "&How to Play";
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 496);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        public System.Windows.Forms.Button C2;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem New;
        private System.Windows.Forms.ToolStripMenuItem Help;
    }
}

