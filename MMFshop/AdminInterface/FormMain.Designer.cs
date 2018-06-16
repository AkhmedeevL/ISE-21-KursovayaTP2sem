namespace AdminInterface
{
    partial class FormMain
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
            this.ButtonFurniture = new System.Windows.Forms.Button();
            this.ButtonCustomers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonFurniture
            // 
            this.ButtonFurniture.Location = new System.Drawing.Point(65, 37);
            this.ButtonFurniture.Name = "ButtonFurniture";
            this.ButtonFurniture.Size = new System.Drawing.Size(268, 49);
            this.ButtonFurniture.TabIndex = 1;
            this.ButtonFurniture.Text = "Управление товарами";
            this.ButtonFurniture.UseVisualStyleBackColor = true;
            this.ButtonFurniture.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonCustomers
            // 
            this.ButtonCustomers.Location = new System.Drawing.Point(65, 107);
            this.ButtonCustomers.Name = "ButtonCustomers";
            this.ButtonCustomers.Size = new System.Drawing.Size(268, 49);
            this.ButtonCustomers.TabIndex = 1;
            this.ButtonCustomers.Text = "Управление клиентами";
            this.ButtonCustomers.UseVisualStyleBackColor = true;
            this.ButtonCustomers.Click += new System.EventHandler(this.ButtonCustomers_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 180);
            this.Controls.Add(this.ButtonCustomers);
            this.Controls.Add(this.ButtonFurniture);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Администрирование";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonFurniture;
        private System.Windows.Forms.Button ButtonCustomers;
    }
}