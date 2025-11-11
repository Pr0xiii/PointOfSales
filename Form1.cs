namespace PointOfSalesApp
{
    public partial class PointOfSalesApp : Form
    {
        public PointOfSale PointOfSale { get; private set; }
        public PointOfSalesApp()
        {
            InitializeComponent();
            InitializeVendors();
            InitializePointOfSale();
        }

        public void InitializeVendors()
        {
            var allVendors = Enum.GetValues(typeof(Vendors));

            for(int i = 0; i < allVendors.Length; i++)
            {
                Button btn = new Button();
                btn.Size = new Size(120, 70);
                btn.Text = allVendors.GetValue(i).ToString();
                btn.Click += (sender, e) => OnClickVendor((Vendors)allVendors.GetValue(i));
                vendorsLayoutPanel.Controls.Add(btn);
            }
        }

        public void OnClickVendor(Vendors vendor)
        {
            PointOfSale.SetVendor(vendor);
            PointOfSaleForm pos = new PointOfSaleForm();
            pos.PointOfSale = this.PointOfSale;
            DialogResult dialog = pos.ShowDialog();

            if(dialog == DialogResult.Cancel)
            {
                MessageBox.Show($"Point of Sale closed");
            }
        }

        public void InitializePointOfSale()
        {
            PointOfSale = new PointOfSale("Jolan Company", 2500.0);
        }
    }
}
