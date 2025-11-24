namespace PointOfSalesApp
{
    partial class ProductForm
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
            label1 = new Label();
            productNameField = new TextBox();
            label2 = new Label();
            barcodeField = new TextBox();
            label3 = new Label();
            costPriceField = new TextBox();
            label4 = new Label();
            comboBoxMarge = new ComboBox();
            label5 = new Label();
            salePriceField = new TextBox();
            label6 = new Label();
            comboBoxTVA = new ComboBox();
            b_Save = new Button();
            b_Create = new Button();
            b_Cancel = new Button();
            label7 = new Label();
            defaultCodeInput = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 23);
            label1.TabIndex = 0;
            label1.Text = "Product Name";
            // 
            // productNameField
            // 
            productNameField.Location = new Point(43, 53);
            productNameField.Margin = new Padding(5);
            productNameField.Name = "productNameField";
            productNameField.Size = new Size(450, 30);
            productNameField.TabIndex = 1;
            productNameField.TextChanged += productNameField_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 119);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 2;
            label2.Text = "Barcode";
            // 
            // barcodeField
            // 
            barcodeField.Location = new Point(146, 116);
            barcodeField.Name = "barcodeField";
            barcodeField.Size = new Size(347, 30);
            barcodeField.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 182);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 4;
            label3.Text = "Cost Price";
            // 
            // costPriceField
            // 
            costPriceField.Location = new Point(146, 179);
            costPriceField.Name = "costPriceField";
            costPriceField.Size = new Size(100, 30);
            costPriceField.TabIndex = 5;
            costPriceField.TextChanged += costPriceField_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 282);
            label4.Name = "label4";
            label4.Size = new Size(60, 23);
            label4.TabIndex = 6;
            label4.Text = "Marge";
            // 
            // comboBoxMarge
            // 
            comboBoxMarge.FormattingEnabled = true;
            comboBoxMarge.Items.AddRange(new object[] { "Fixed", "Variable" });
            comboBoxMarge.Location = new Point(109, 279);
            comboBoxMarge.Name = "comboBoxMarge";
            comboBoxMarge.Size = new Size(137, 30);
            comboBoxMarge.TabIndex = 7;
            comboBoxMarge.SelectedIndexChanged += comboBoxMarge_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 346);
            label5.Name = "label5";
            label5.Size = new Size(84, 23);
            label5.TabIndex = 8;
            label5.Text = "Sale Price";
            // 
            // salePriceField
            // 
            salePriceField.Location = new Point(146, 343);
            salePriceField.Name = "salePriceField";
            salePriceField.Size = new Size(100, 30);
            salePriceField.TabIndex = 9;
            salePriceField.ReadOnlyChanged += salePriceField_ReadOnlyChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 230);
            label6.Name = "label6";
            label6.Size = new Size(44, 23);
            label6.TabIndex = 10;
            label6.Text = "TVA";
            // 
            // comboBoxTVA
            // 
            comboBoxTVA.FormattingEnabled = true;
            comboBoxTVA.Items.AddRange(new object[] { "None", "6%", "21%" });
            comboBoxTVA.Location = new Point(109, 230);
            comboBoxTVA.Name = "comboBoxTVA";
            comboBoxTVA.Size = new Size(137, 30);
            comboBoxTVA.TabIndex = 11;
            comboBoxTVA.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // b_Save
            // 
            b_Save.Location = new Point(584, 20);
            b_Save.Name = "b_Save";
            b_Save.Size = new Size(75, 32);
            b_Save.TabIndex = 12;
            b_Save.Text = "Save";
            b_Save.UseVisualStyleBackColor = true;
            b_Save.Visible = false;
            b_Save.Click += b_Save_Click;
            // 
            // b_Create
            // 
            b_Create.Location = new Point(677, 369);
            b_Create.Name = "b_Create";
            b_Create.Size = new Size(92, 32);
            b_Create.TabIndex = 13;
            b_Create.Text = "Create";
            b_Create.UseVisualStyleBackColor = true;
            b_Create.Click += b_Create_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Location = new Point(677, 20);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(92, 32);
            b_Cancel.TabIndex = 14;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Visible = false;
            b_Cancel.Click += b_Cancel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(342, 182);
            label7.Name = "label7";
            label7.Size = new Size(151, 23);
            label7.TabIndex = 15;
            label7.Text = "Internal Reference";
            // 
            // defaultCodeInput
            // 
            defaultCodeInput.Location = new Point(508, 182);
            defaultCodeInput.Name = "defaultCodeInput";
            defaultCodeInput.Size = new Size(151, 30);
            defaultCodeInput.TabIndex = 16;
            defaultCodeInput.TextChanged += defaultCodeInput_TextChanged;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 413);
            Controls.Add(defaultCodeInput);
            Controls.Add(label7);
            Controls.Add(b_Cancel);
            Controls.Add(b_Create);
            Controls.Add(b_Save);
            Controls.Add(comboBoxTVA);
            Controls.Add(label6);
            Controls.Add(salePriceField);
            Controls.Add(label5);
            Controls.Add(comboBoxMarge);
            Controls.Add(label4);
            Controls.Add(costPriceField);
            Controls.Add(label3);
            Controls.Add(barcodeField);
            Controls.Add(label2);
            Controls.Add(productNameField);
            Controls.Add(label1);
            Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "ProductForm";
            Text = "ProductForm";
            FormClosing += ProductForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productNameField;
        private Label label2;
        private TextBox barcodeField;
        private Label label3;
        private TextBox costPriceField;
        private Label label4;
        private ComboBox comboBoxMarge;
        private Label label5;
        private TextBox salePriceField;
        private Label label6;
        private ComboBox comboBoxTVA;
        private Button b_Save;
        private Button b_Create;
        private Button b_Cancel;
        private Label label7;
        private TextBox defaultCodeInput;
    }
}