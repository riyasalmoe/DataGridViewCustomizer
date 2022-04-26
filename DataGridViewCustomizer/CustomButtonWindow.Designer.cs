namespace DataGridViewCustomizer
{
    partial class CustomButtonWindow
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
            this.ProductsPanel = new System.Windows.Forms.Panel();
            this.productButton1 = new AroniumButton.ProductButton();
            this.SuspendLayout();
            // 
            // ProductsPanel
            // 
            this.ProductsPanel.BackColor = System.Drawing.Color.Khaki;
            this.ProductsPanel.Location = new System.Drawing.Point(0, 0);
            this.ProductsPanel.Name = "ProductsPanel";
            this.ProductsPanel.Size = new System.Drawing.Size(850, 585);
            this.ProductsPanel.TabIndex = 0;
            // 
            // productButton1
            // 
            this.productButton1.BackColor = System.Drawing.Color.Black;
            this.productButton1.Location = new System.Drawing.Point(884, 107);
            this.productButton1.Name = "productButton1";
            this.productButton1.Size = new System.Drawing.Size(170, 195);
            this.productButton1.TabIndex = 1;
            // 
            // CustomButtonWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 591);
            this.Controls.Add(this.productButton1);
            this.Controls.Add(this.ProductsPanel);
            this.Name = "CustomButtonWindow";
            this.Text = "Products Buttons";
            this.Load += new System.EventHandler(this.CustomButtonWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ProductsPanel;
        private AroniumButton.ProductButton productButton1;
    }
}