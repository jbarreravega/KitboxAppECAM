namespace KitBoxAPP
{
    partial class Home_client
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.button_client = new System.Windows.Forms.Button();
            this.button_staff = new System.Windows.Forms.Button();
            this.button_catalog = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label_Welcome.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Welcome.Location = new System.Drawing.Point(172, 41);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(544, 55);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Bienvenue chez KitBox !";
            // 
            // button_client
            // 
            this.button_client.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_client.Location = new System.Drawing.Point(12, 12);
            this.button_client.Name = "button_client";
            this.button_client.Size = new System.Drawing.Size(137, 67);
            this.button_client.TabIndex = 1;
            this.button_client.Text = "Clientèle";
            this.button_client.UseVisualStyleBackColor = true;
            // 
            // button_staff
            // 
            this.button_staff.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_staff.Location = new System.Drawing.Point(735, 12);
            this.button_staff.Name = "button_staff";
            this.button_staff.Size = new System.Drawing.Size(137, 67);
            this.button_staff.TabIndex = 2;
            this.button_staff.Text = "Personnel";
            this.button_staff.UseVisualStyleBackColor = true;
            // 
            // button_catalog
            // 
            this.button_catalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_catalog.Location = new System.Drawing.Point(182, 208);
            this.button_catalog.Name = "button_catalog";
            this.button_catalog.Size = new System.Drawing.Size(223, 133);
            this.button_catalog.TabIndex = 3;
            this.button_catalog.Text = "Consulter le catalogue";
            this.button_catalog.UseVisualStyleBackColor = true;
            // 
            // button_order
            // 
            this.button_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_order.Location = new System.Drawing.Point(493, 208);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(223, 133);
            this.button_order.TabIndex = 4;
            this.button_order.Text = "Passer une commande";
            this.button_order.UseVisualStyleBackColor = true;
            this.button_order.Click += new System.EventHandler(this.button_order_Click);
            // 
            // Home_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_catalog);
            this.Controls.Add(this.button_staff);
            this.Controls.Add(this.button_client);
            this.Controls.Add(this.label_Welcome);
            this.Name = "Home_client";
            this.Text = "Home_client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Button button_client;
        private System.Windows.Forms.Button button_staff;
        private System.Windows.Forms.Button button_catalog;
        private System.Windows.Forms.Button button_order;

    }
}