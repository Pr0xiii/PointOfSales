namespace PointOfSalesApp
{
    partial class PointOfSaleForm
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
            labelVendorName = new Label();
            b_SetClient = new Button();
            b_CreateClient = new Button();
            productsLayoutPanel = new FlowLayoutPanel();
            groupBox_Sale = new GroupBox();
            b_Encaisser = new Button();
            b_CreateProduct = new Button();
            b_Cancel = new Button();
            groupBox_Sale.SuspendLayout();
            SuspendLayout();
            // 
            // labelVendorName
            // 
            labelVendorName.AutoSize = true;
            labelVendorName.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelVendorName.Location = new Point(31, 37);
            labelVendorName.Margin = new Padding(4, 0, 4, 0);
            labelVendorName.Name = "labelVendorName";
            labelVendorName.Size = new Size(97, 19);
            labelVendorName.TabIndex = 0;
            labelVendorName.Text = "Vendor name";
            // 
            // b_SetClient
            // 
            b_SetClient.Location = new Point(429, 17);
            b_SetClient.Name = "b_SetClient";
            b_SetClient.Size = new Size(183, 63);
            b_SetClient.TabIndex = 1;
            b_SetClient.Text = "Set Client";
            b_SetClient.UseVisualStyleBackColor = true;
            // 
            // b_CreateClient
            // 
            b_CreateClient.Location = new Point(633, 17);
            b_CreateClient.Name = "b_CreateClient";
            b_CreateClient.Size = new Size(183, 63);
            b_CreateClient.TabIndex = 2;
            b_CreateClient.Text = "New client";
            b_CreateClient.UseVisualStyleBackColor = true;
            b_CreateClient.Click += b_CreateClient_Click;
            // 
            // productsLayoutPanel
            // 
            productsLayoutPanel.Location = new Point(982, 122);
            productsLayoutPanel.Name = "productsLayoutPanel";
            productsLayoutPanel.Padding = new Padding(10);
            productsLayoutPanel.Size = new Size(494, 559);
            productsLayoutPanel.TabIndex = 3;
            // 
            // groupBox_Sale
            // 
            groupBox_Sale.Location = new Point(31, 122);
            groupBox_Sale.Name = "groupBox_Sale";
            groupBox_Sale.Size = new Size(785, 559);
            groupBox_Sale.TabIndex = 4;
            groupBox_Sale.TabStop = false;
            groupBox_Sale.Text = "Current Sale";
            // 
            // b_Encaisser
            // 
            b_Encaisser.Location = new Point(837, 583);
            b_Encaisser.Name = "b_Encaisser";
            b_Encaisser.Size = new Size(124, 98);
            b_Encaisser.TabIndex = 5;
            b_Encaisser.Text = "Encaisser";
            b_Encaisser.UseVisualStyleBackColor = true;
            b_Encaisser.Click += b_Encaisser_Click;
            // 
            // b_CreateProduct
            // 
            b_CreateProduct.Location = new Point(1299, 17);
            b_CreateProduct.Name = "b_CreateProduct";
            b_CreateProduct.Size = new Size(177, 63);
            b_CreateProduct.TabIndex = 6;
            b_CreateProduct.Text = "New Product";
            b_CreateProduct.UseVisualStyleBackColor = true;
            b_CreateProduct.Click += b_CreateProduct_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Location = new Point(837, 450);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(124, 93);
            b_Cancel.TabIndex = 7;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Click += b_Cancel_Click;
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1540, 742);
            Controls.Add(b_Cancel);
            Controls.Add(b_CreateProduct);
            Controls.Add(b_Encaisser);
            Controls.Add(groupBox_Sale);
            Controls.Add(productsLayoutPanel);
            Controls.Add(b_CreateClient);
            Controls.Add(b_SetClient);
            Controls.Add(labelVendorName);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PointOfSaleForm";
            Text = "PointOfSaleForm";
            groupBox_Sale.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelVendorName;
        private Button b_SetClient;
        private Button b_CreateClient;
        private FlowLayoutPanel productsLayoutPanel;
        private GroupBox groupBox_Sale;
        private Button b_Encaisser;
        private Button b_CreateProduct;
        private Button b_Cancel;
    }
}