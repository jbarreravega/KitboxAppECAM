namespace KitBoxAPP
{
    partial class ToGoToHomeStaff
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
            this.label_WelcomeT1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwd_Text_Box = new System.Windows.Forms.TextBox();
            this.button_homeT1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_WelcomeT1
            // 
            this.label_WelcomeT1.AutoSize = true;
            this.label_WelcomeT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label_WelcomeT1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_WelcomeT1.Location = new System.Drawing.Point(181, 71);
            this.label_WelcomeT1.Name = "label_WelcomeT1";
            this.label_WelcomeT1.Size = new System.Drawing.Size(544, 55);
            this.label_WelcomeT1.TabIndex = 1;
            this.label_WelcomeT1.Text = "Bienvenue chez KitBox !";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(188, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(544, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Veuillez entrer le mot de passe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Passwd_Text_Box
            // 
            this.Passwd_Text_Box.ForeColor = System.Drawing.Color.White;
            this.Passwd_Text_Box.Location = new System.Drawing.Point(361, 287);
            this.Passwd_Text_Box.Name = "Passwd_Text_Box";
            this.Passwd_Text_Box.Size = new System.Drawing.Size(211, 20);
            this.Passwd_Text_Box.TabIndex = 3;
            this.Passwd_Text_Box.TextChanged += new System.EventHandler(this.Passwd_Text_Box_TextChanged);
            // 
            // button_homeT1
            // 
            this.button_homeT1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button_homeT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_homeT1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_homeT1.Location = new System.Drawing.Point(731, 12);
            this.button_homeT1.Name = "button_homeT1";
            this.button_homeT1.Size = new System.Drawing.Size(150, 93);
            this.button_homeT1.TabIndex = 8;
            this.button_homeT1.Text = "Menu principal";
            this.button_homeT1.UseVisualStyleBackColor = true;
            this.button_homeT1.Click += new System.EventHandler(this.button_homeT1_Click);
            // 
            // ToGoToHomeStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.button_homeT1);
            this.Controls.Add(this.Passwd_Text_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_WelcomeT1);
            this.Name = "ToGoToHomeStaff";
            this.Text = "ToGoToHomeStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_WelcomeT1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passwd_Text_Box;
        private System.Windows.Forms.Button button_homeT1;
    }
}