namespace PointOfSalesApp
{
    partial class PointOfSalesApp
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
            vendorsLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // vendorsLayoutPanel
            // 
            vendorsLayoutPanel.Location = new Point(40, 30);
            vendorsLayoutPanel.Margin = new Padding(10);
            vendorsLayoutPanel.Name = "vendorsLayoutPanel";
            vendorsLayoutPanel.Padding = new Padding(10);
            vendorsLayoutPanel.Size = new Size(534, 323);
            vendorsLayoutPanel.TabIndex = 0;
            // 
            // PointOfSalesApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 392);
            Controls.Add(vendorsLayoutPanel);
            Name = "PointOfSalesApp";
            Text = "Point Of Sales Application";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel vendorsLayoutPanel;
    }
}
