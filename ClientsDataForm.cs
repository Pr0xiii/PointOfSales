using PointOfSalesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSalesApp
{
    public partial class ClientsDataForm : Form
    {
        public ClientsDataForm()
        {
            InitializeComponent();
            InitializeClients();
        }

        public void InitializeClients()
        {
            using(var db = new PosContext())
            {
                var clients = db.Clients.ToList();

                if(clients.Count > 0)
                {
                    clientsDataGridView.DataSource = clients;
                }
            }
        }
    }
}
