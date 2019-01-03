using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace super_vizor
{
    class CompanyViewModel
    {
        private Company _oldCompany;
        public ObservableCollection<Company> companys { get; set; }

        public CompanyViewModel()
        {
            companys = new ObservableCollection<Company>
            {
                new Company
                {
                    name = "Google",
                    IsVisibleDetail = false,
                },
                new Company
                {
                    name = "Akvelon",
                    IsVisibleDetail = false,
                },
                new Company
                {
                    name = "Ubisoft",
                    IsVisibleDetail = false,
                },
                new Company
                {
                    name = "Microsoft",
                    IsVisibleDetail = false,
                }
            };
        }

        public void HideOrShowCompany(Company company)
        {
            if (_oldCompany == company)
            {
                company.IsVisibleDetail = !company.IsVisibleDetail;
                UpdateCompany(company);
            }
            else
            {
                if (_oldCompany != null)
                {
                    _oldCompany.IsVisibleDetail = false;
                    UpdateCompany(_oldCompany);
                }
                company.IsVisibleDetail = true;
                UpdateCompany(company);
            }

            _oldCompany = company;
        }

        public void UpdateCompany (Company company)
        {
            var index = companys.IndexOf(company);

            companys.Remove(company);
            companys.Insert(index, company);
        }

        public void RemoveItem (Company company)
        {
            var index = companys.IndexOf(company);
            companys.RemoveAt(index);
            _oldCompany = null;
        }

    }
}
