using PointOfSalesApp.Data;
using PointOfSalesApp.Models;
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
    public partial class ClientForm : Form
    {
        private readonly PointOfSale _pos;
        private readonly Client _client;

        private double currentMoney = 0;
        private bool isCompany = true;
        public ClientForm(PointOfSale pos)
        {
            _pos = pos;
            InitializeComponent();
            _client = new Client();
        }

        private void clientNameInput_TextChanged(object sender, EventArgs e)
        {
            OnChangeField(true);
        }
        private void OnChangeField(bool state)
        {
            b_Save.Visible = state;
            b_Cancel.Visible = state;
        }

        private void tvaInput_TextChanged(object sender, EventArgs e)
        {
            OnChangeField(true);
        }

        private void moneyInput_TextChanged(object sender, EventArgs e)
        {
            bool money = double.TryParse(moneyInput.Text, out double result);

            if (money)
            {
                currentMoney = result;
                OnChangeField(true);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }
        }

        private void internalCodeInput_TextChanged(object sender, EventArgs e)
        {
            OnChangeField(true);
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            _client.Id = internalCodeInput.Text == "" ? 0 : int.Parse(internalCodeInput.Text);
            _client.Name = clientNameInput.Text == "" ? "New client" : clientNameInput.Text;
            _client.TVA = tvaInput.Text == "" ? "None" : tvaInput.Text;
            _client.Money = currentMoney;
            _client.IsCompany = isCompany;
            OnChangeField(false);
        }

        private void rb_Company_CheckedChanged(object sender, EventArgs e)
        {
            isCompany = rb_Company.Checked;
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel ?", "Cancel Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                clientNameInput.Text = _client.Name;
                tvaInput.Text = _client.TVA.ToString();
                moneyInput.Text = _client.Money.ToString();
                internalCodeInput.Text = _client.Id.ToString();
                rb_Company.Checked = _client.IsCompany;
                OnChangeField(false);
            }
        }

        private void b_Create_Click(object sender, EventArgs e)
        {
            if (b_Save.Visible == true)
            {
                b_Save_Click(sender, e);
            }

            _pos.Clients.Add(_client);
            using var db = new PosContext();
            db.Clients.Add(_client);
            db.SaveChanges();
            this.DialogResult = DialogResult.OK;
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK) return;

            if (b_Save.Visible)
            {
                var result = MessageBox.Show("Are you sure you want to quit without saving ?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            else
            {
                var result = MessageBox.Show("Are you sure you want to quit ?", "Close Form", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
