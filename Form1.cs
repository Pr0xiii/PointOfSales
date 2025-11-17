namespace PointOfSalesApp
{
    public partial class PointOfSalesApp : Form
    {
        private readonly PointOfSale _pos;
        public PointOfSalesApp(PointOfSale pos)
        {
            _pos = pos;
            InitializeComponent();
            InitializeVendors();
        }

        public void InitializeVendors()
        {
            var allVendors = Enum.GetValues(typeof(Vendors));

            for(int i = 0; i < allVendors.Length; i++)
            {
                int index = i;

                Button btn = new Button();
                btn.Size = new Size(120, 70);
                btn.Text = ((Vendors)index).ToString();
                btn.Click += (sender, e) => OnClickVendor((Vendors)index);

                vendorsLayoutPanel.Controls.Add(btn);
            }
        }

        public void OnClickVendor(Vendors vendor)
        {
            _pos.SetVendor(vendor);
            PointOfSaleForm pos = new PointOfSaleForm(_pos);
            DialogResult dialog = pos.ShowDialog();

            if (dialog == DialogResult.Cancel)
            {
                MessageBox.Show($"Point of Sale closed");
            }
        }
    }
}
