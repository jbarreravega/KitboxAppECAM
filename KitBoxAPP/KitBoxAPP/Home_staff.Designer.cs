namespace KitBoxAPP
{
    partial class Home_staff
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
            this.button_order0 = new System.Windows.Forms.Button();
            this.button_catalog0 = new System.Windows.Forms.Button();
            this.button_staff0 = new System.Windows.Forms.Button();
            this.button_client0 = new System.Windows.Forms.Button();
            this.label_Welcome0 = new System.Windows.Forms.Label();
            this.button_orderToDo = new System.Windows.Forms.Button();
            this.button_catalogModified = new System.Windows.Forms.Button();
            this.button_stock = new System.Windows.Forms.Button();
            this.button_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_order0
            // 
            this.button_order0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_order0.Location = new System.Drawing.Point(568, 131);
            this.button_order0.Name = "button_order0";
            this.button_order0.Size = new System.Drawing.Size(225, 100);
            this.button_order0.TabIndex = 9;
            this.button_order0.Text = "Passer une commande";
            this.button_order0.UseVisualStyleBackColor = true;
            // 
            // button_catalog0
            // 
            this.button_catalog0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_catalog0.Location = new System.Drawing.Point(78, 131);
            this.button_catalog0.Name = "button_catalog0";
            this.button_catalog0.Size = new System.Drawing.Size(225, 100);
            this.button_catalog0.TabIndex = 8;
            this.button_catalog0.Text = "Consulter le catalogue";
            this.button_catalog0.UseVisualStyleBackColor = true;
            // 
            // button_staff0
            // 
            this.button_staff0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_staff0.Location = new System.Drawing.Point(735, 12);
            this.button_staff0.Name = "button_staff0";
            this.button_staff0.Size = new System.Drawing.Size(137, 67);
            this.button_staff0.TabIndex = 7;
            this.button_staff0.Text = "Personnel";
            this.button_staff0.UseVisualStyleBackColor = true;
            // 
            // button_client0
            // 
            this.button_client0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button_client0.Location = new System.Drawing.Point(12, 12);
            this.button_client0.Name = "button_client0";
            this.button_client0.Size = new System.Drawing.Size(137, 67);
            this.button_client0.TabIndex = 6;
            this.button_client0.Text = "Clientèle";
            this.button_client0.UseVisualStyleBackColor = true;
            // 
            // label_Welcome0
            // 
            this.label_Welcome0.AutoSize = true;
            this.label_Welcome0.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.label_Welcome0.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_Welcome0.Location = new System.Drawing.Point(172, 41);
            this.label_Welcome0.Name = "label_Welcome0";
            this.label_Welcome0.Size = new System.Drawing.Size(544, 55);
            this.label_Welcome0.TabIndex = 5;
            this.label_Welcome0.Text = "Bienvenue chez KitBox !";
            // 
            // button_orderToDo
            // 
            this.button_orderToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_orderToDo.Location = new System.Drawing.Point(170, 265);
            this.button_orderToDo.Name = "button_orderToDo";
            this.button_orderToDo.Size = new System.Drawing.Size(225, 100);
            this.button_orderToDo.TabIndex = 10;
            this.button_orderToDo.Text = "Commande à réaliser";
            this.button_orderToDo.UseVisualStyleBackColor = true;
            // 
            // button_catalogModified
            // 
            this.button_catalogModified.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_catalogModified.Location = new System.Drawing.Point(78, 405);
            this.button_catalogModified.Name = "button_catalogModified";
            this.button_catalogModified.Size = new System.Drawing.Size(225, 100);
            this.button_catalogModified.TabIndex = 11;
            this.button_catalogModified.Text = "Modifier le catalogue";
            this.button_catalogModified.UseVisualStyleBackColor = true;
            // 
            // button_stock
            // 
            this.button_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_stock.Location = new System.Drawing.Point(468, 265);
            this.button_stock.Name = "button_stock";
            this.button_stock.Size = new System.Drawing.Size(225, 100);
            this.button_stock.TabIndex = 12;
            this.button_stock.Text = "Gestion du stock";
            this.button_stock.UseVisualStyleBackColor = true;
            // 
            // button_history
            // 
            this.button_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button_history.Location = new System.Drawing.Point(568, 405);
            this.button_history.Name = "button_history";
            this.button_history.Size = new System.Drawing.Size(225, 100);
            this.button_history.TabIndex = 13;
            this.button_history.Text = "Historique des commandes";
            this.button_history.UseVisualStyleBackColor = true;
            // 
            // Home_staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(884, 521);
            this.Controls.Add(this.button_history);
            this.Controls.Add(this.button_stock);
            this.Controls.Add(this.button_catalogModified);
            this.Controls.Add(this.button_orderToDo);
            this.Controls.Add(this.button_order0);
            this.Controls.Add(this.button_catalog0);
            this.Controls.Add(this.button_staff0);
            this.Controls.Add(this.button_client0);
            this.Controls.Add(this.label_Welcome0);
            this.Name = "Home_staff";
            this.Text = "Home_staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_order0;
        private System.Windows.Forms.Button button_catalog0;
        private System.Windows.Forms.Button button_staff0;
        private System.Windows.Forms.Button button_client0;
        private System.Windows.Forms.Label label_Welcome0;
        private System.Windows.Forms.Button button_orderToDo;
        private System.Windows.Forms.Button button_catalogModified;
        private System.Windows.Forms.Button button_stock;
        private System.Windows.Forms.Button button_history;
    }
}