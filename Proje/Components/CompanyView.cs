using Proje.Helpers;
using Proje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje.Components
{
    public partial class CompanyView : Form
    {
        public Company Company { get; set; }
        public CompanyView(Company company = null)
        {
            Company = company;
            InitializeComponent();
            Text = "Yeni Firma Ekleme";
            if(company != null )
            {
                txtTitle.Text = company.Title;
                txtTaxNo.Text = company.TaxNo;
                txtAddress.Text = company.ContactAddress;
                txtOwner.Text = company.Owner;
                txtPhone.Text = company.Phone;
                cmbNace.Text = company.NaceCode;
                dtProductionStart.Value = company.ProductionStarting;
                chkIsRegistered.Checked = company.IsRegistered;
                Text = txtTitle.Text + " Firması Düzenleme Ekleme";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.Text == null)
                    throw new Exception(lblTitle.Text + " giriniz!");
                if (txtTaxNo.Text == null)
                    throw new Exception(lblTaxNo.Text + " giriniz!");
                if (txtAddress.Text == null)
                    throw new Exception(lblAddress.Text + " giriniz!");
                if (txtOwner.Text == null)
                    throw new Exception(lblOwner.Text + " giriniz!");
                if (txtPhone.Text == null)
                    throw new Exception(lblPhone.Text + " giriniz!");
                if (cmbNace.SelectedIndex < 0)
                    throw new Exception(lblNace.Text + " giriniz!");
                if (dtProductionStart.Value == null)
                    throw new Exception(lblProductionStart.Text + " giriniz!");
                if (Company == null)
                    Company = new Company();
                Company.Title = txtTitle.Text;
                Company.TaxNo = txtTaxNo.Text;
                Company.ContactAddress = txtAddress.Text;   
                Company.Owner = txtOwner.Text;
                Company.Phone = txtPhone.Text;
                Company.NaceCode = cmbNace.Text;
                Company.ProductionStarting = dtProductionStart.Value;
                Company.IsRegistered = chkIsRegistered.Checked;

                Service<Company>.AddOrUpdate(Company);  
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
