namespace PointOfSalesApp
{
    partial class ClientsDataForm
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
            clientsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // clientsDataGridView
            // 
            clientsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientsDataGridView.Location = new Point(23, 32);
            clientsDataGridView.Name = "clientsDataGridView";
            clientsDataGridView.Size = new Size(747, 406);
            clientsDataGridView.TabIndex = 0;
            // 
            // ClientsDataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clientsDataGridView);
            Name = "ClientsDataForm";
            Text = "ClientsDataForm";
            ((System.ComponentModel.ISupportInitialize)clientsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView clientsDataGridView;
    }
}