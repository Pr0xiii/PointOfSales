namespace PointOfSalesApp
{
    partial class ClientForm
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
            clientNameInput = new TextBox();
            rb_Company = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tvaInput = new TextBox();
            internalCodeInput = new TextBox();
            moneyInput = new TextBox();
            b_Save = new Button();
            b_Cancel = new Button();
            b_Create = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Corbel", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 58);
            label1.Name = "label1";
            label1.Size = new Size(125, 27);
            label1.TabIndex = 0;
            label1.Text = "Client Name";
            // 
            // clientNameInput
            // 
            clientNameInput.Location = new Point(38, 88);
            clientNameInput.Name = "clientNameInput";
            clientNameInput.Size = new Size(711, 27);
            clientNameInput.TabIndex = 1;
            clientNameInput.TextChanged += clientNameInput_TextChanged;
            // 
            // rb_Company
            // 
            rb_Company.AutoSize = true;
            rb_Company.Location = new Point(38, 140);
            rb_Company.Name = "rb_Company";
            rb_Company.Size = new Size(91, 23);
            rb_Company.TabIndex = 2;
            rb_Company.TabStop = true;
            rb_Company.Text = "Company";
            rb_Company.UseVisualStyleBackColor = true;
            rb_Company.CheckedChanged += rb_Company_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 195);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 4;
            label2.Text = "TVA Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 195);
            label3.Name = "label3";
            label3.Size = new Size(97, 19);
            label3.TabIndex = 5;
            label3.Text = "Internal Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 254);
            label4.Name = "label4";
            label4.Size = new Size(55, 19);
            label4.TabIndex = 6;
            label4.Text = "Money";
            // 
            // tvaInput
            // 
            tvaInput.Location = new Point(146, 192);
            tvaInput.Name = "tvaInput";
            tvaInput.Size = new Size(194, 27);
            tvaInput.TabIndex = 7;
            tvaInput.TextChanged += tvaInput_TextChanged;
            // 
            // internalCodeInput
            // 
            internalCodeInput.Location = new Point(516, 187);
            internalCodeInput.Name = "internalCodeInput";
            internalCodeInput.Size = new Size(233, 27);
            internalCodeInput.TabIndex = 8;
            internalCodeInput.TextChanged += internalCodeInput_TextChanged;
            // 
            // moneyInput
            // 
            moneyInput.Location = new Point(146, 251);
            moneyInput.Name = "moneyInput";
            moneyInput.Size = new Size(194, 27);
            moneyInput.TabIndex = 9;
            moneyInput.TextChanged += moneyInput_TextChanged;
            // 
            // b_Save
            // 
            b_Save.Location = new Point(630, 12);
            b_Save.Name = "b_Save";
            b_Save.Size = new Size(85, 39);
            b_Save.TabIndex = 10;
            b_Save.Text = "Save";
            b_Save.UseVisualStyleBackColor = true;
            b_Save.Visible = false;
            b_Save.Click += b_Save_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Location = new Point(721, 12);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(75, 39);
            b_Cancel.TabIndex = 11;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Visible = false;
            b_Cancel.Click += b_Cancel_Click;
            // 
            // b_Create
            // 
            b_Create.Location = new Point(684, 299);
            b_Create.Name = "b_Create";
            b_Create.Size = new Size(112, 39);
            b_Create.TabIndex = 12;
            b_Create.Text = "Create";
            b_Create.UseVisualStyleBackColor = true;
            b_Create.Click += b_Create_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 361);
            Controls.Add(b_Create);
            Controls.Add(b_Cancel);
            Controls.Add(b_Save);
            Controls.Add(moneyInput);
            Controls.Add(internalCodeInput);
            Controls.Add(tvaInput);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rb_Company);
            Controls.Add(clientNameInput);
            Controls.Add(label1);
            Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ClientForm";
            Text = "ClientForm";
            FormClosing += ClientForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox clientNameInput;
        private RadioButton rb_Company;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tvaInput;
        private TextBox internalCodeInput;
        private TextBox moneyInput;
        private Button b_Save;
        private Button b_Cancel;
        private Button b_Create;
    }
}