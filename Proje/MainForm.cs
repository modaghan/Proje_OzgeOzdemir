using Proje.Components;
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

namespace Proje
{
    public partial class MainForm : Form
    {
        public States ActiveState { get; set; }
        public Company FocusedCompany { get; set; }
        public List<Company> SelectedCompanies { get; set; }
        public MainForm()
        {
            InitializeComponent();
            tabMain_SelectedIndexChanged(null, null);
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabMain.SelectedIndex == 0)
                RefreshList(tabContinue, ActiveState = States.Continue);
            else if (tabMain.SelectedIndex == 1)
                RefreshList(tabInPenalty, ActiveState = States.InPenalty);
            else if (tabMain.SelectedIndex == 2)
                RefreshList(tabCompleted, ActiveState = States.Completed);
        }

        private void RefreshList(TabPage tabCompleted, States state)
        {
            CompanyList companyList = new CompanyList(state);
            companyList.CompanyChanged += CompanyList_CompanyChanged;
            companyList.Dock= DockStyle.Fill;
            tabCompleted.Controls.Clear();
            tabCompleted.Controls.Add(companyList);
        }

        private void CompanyList_CompanyChanged(object sender, EventArgs e)
        {
            FocusedCompany = null;
            SelectedCompanies = null;
            CompanyList companyList = sender as CompanyList;
            if(companyList != null)
            {
                SelectedCompanies = companyList.SelectedCompanies;
                btnEdit.Enabled = companyList.SelectedCompanies != null &&
                    companyList.SelectedCompanies.Count == 1;
                if(btnEdit.Enabled)
                    FocusedCompany = companyList.SelectedCompanies[0];
                btnDelete.Enabled = companyList.SelectedCompanies != null &&
                    companyList.SelectedCompanies.Count > 0;
                btnControl.Enabled = companyList.SelectedCompanies != null &&
                    companyList.SelectedCompanies.Count > 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CompanyView companyView = new CompanyView();
            if(companyView.ShowDialog() == DialogResult.OK)
            {
                tabMain_SelectedIndexChanged(null, null);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(FocusedCompany != null)
            {
                CompanyView companyView = new CompanyView(FocusedCompany);
                if (companyView.ShowDialog() == DialogResult.OK)
                {
                    tabMain_SelectedIndexChanged(null, null);
                }
            }
        }

        private void SetView(CompanyView companyView)
        {
            if (companyView.Company == null)
                return;
            if (companyView.Company.GetState() == States.Continue)
                tabMain.SelectedIndex = 0;
            else if (companyView.Company.GetState() == States.InPenalty)
                tabMain.SelectedIndex = 1;
            else if (companyView.Company.GetState() == States.Completed)
                tabMain.SelectedIndex = 2;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(SelectedCompanies != null &&
                SelectedCompanies.Count > 0)
            {
                var questionResult = MessageBox.Show(
                    $"Seçili {SelectedCompanies.Count} adet firmayı silmek istediğinizden emin misiniz?",
                    "Onaylayınız",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(questionResult == DialogResult.Yes)
                {
                    foreach (var company in SelectedCompanies)
                    {
                        Service<Company>.Delete(company);
                    }
                    tabMain_SelectedIndexChanged(null, null);
                }
            }
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            if(SelectedCompanies != null &&
                SelectedCompanies.Count > 0)
            {

            }
        }
    }
}
