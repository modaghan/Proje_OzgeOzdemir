using Proje.Helpers;
using Proje.Models;
using Proje.Properties;
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
    public partial class CompanyList : UserControl
    {
        public event EventHandler CompanyChanged;
        public States Status { get; set; }
        public List<Company> SelectedCompanies { get; private set; }

        public CompanyList()
        {
            InitializeComponent();
        }
        public CompanyList(States status)
        {
            this.Status = status;
            InitializeComponent();
            GetList();
        }

        private void GetList()
        {
            int dayLimit = Settings.Default.RegistrationDayLimit;
            List<Company> allCompanies = Service<Company>.SelectAll();
            List<Company> Companies = allCompanies.Where(x => x.GetState() == this.Status).ToList();
            list.Items.Clear();
            foreach (Company company in Companies.OrderBy(x => x.Title))
            {
                ListViewItem item = new ListViewItem(company.Title);
                item.Tag = company;
                item.SubItems.Add(company.TaxNo);
                item.SubItems.Add(company.ContactAddress);
                item.SubItems.Add(company.Owner);
                item.SubItems.Add(company.Phone);
                item.SubItems.Add(company.NaceCode);
                item.SubItems.Add(company.ProductionStarting.ToString("dd.MM.yyyy"));
                item.SubItems.Add(company.LastCheck.ToString("dd.MM.yyyy, HH:mm"));
                list.Items.Add(item);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCompanies = null;
            SelectedCompanies =
                list
                .CheckedItems
                .Cast<ListViewItem>()
                .Select(x=>x.Tag)
                .Cast<Company>().ToList(); 

            CompanyChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
