﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace super_vizor
{
    internal class CompanyViewModel
    {
        private Company _oldCompany;
        private Groups _oldGroup;
        private Persones _oldPersone;
        private Azure _oldAzure;

        public ObservableCollection<Company> companys { get; set; }

        public ObservableCollection<Groups> groups{ get; set; }

        public ObservableCollection<Persones> persones { get; set; }

        public ObservableCollection<Azure> azures { get; set; }

        public CompanyViewModel()
        {
            Random k = new Random();
            string[] firstNames = { "Ivan", "Roman", "Simon", "Ali", "Ignat", "Dari", "Rivan" };
            string[] lastNames = { "Fedorov", "Limanov", "Malinovskiy", "Babanov", "Serov", "Magnatov", "Abdulov" };
            string[] positions = { "Junior", "Middle", "Senior" };



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

            groups = new ObservableCollection<Groups>
            {
                new Groups
                {
                    Name = "Users",
                    IsVisible = false,
                },
                new Groups
                {
                    Name = "Testers",
                    IsVisible = false,
                },
                new Groups
                {
                    Name = "Mailing",
                    IsVisible = false,
                },
                new Groups
                {
                    Name = "Developers",
                    IsVisible = false,
                }
            };

            persones = new ObservableCollection<Persones>
            {
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
                new Persones
                {
                    Age = k.Next(21, 75),
                    Experience = k.Next(3, 15),
                    FirstName = firstNames[k.Next(0, 7)],
                    LastName = lastNames[k.Next(0, 7)],
                    Salary = k.Next(30000, 120000),
                    Position = positions[k.Next(0, 3)],
                    IsVisible = false,
                },
            };

            azures = new ObservableCollection<Azure>
            {
                new Azure
                {
                    ID = "MS-AZR-0063P",
                    IsVisible = false,
                },
                new Azure
                {
                    ID = "MC-AZR-3651P",
                    IsVisible = false,
                },
                new Azure
                {
                    ID = "DS-AZR-1105P",
                    IsVisible = false,
                },
                new Azure
                {
                    ID = "MS-AZR-7851S",
                    IsVisible = false,
                },
                new Azure
                {
                    ID = "MS-AZR-0101P",
                    IsVisible = false,
                },
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

        public void HideOrShowGroups(Groups group)
        {
            if (_oldGroup == group)
            {
                group.IsVisible = !group.IsVisible;
                UpdateGroups(group);
            }
            else
            {
                if (_oldGroup != null)
                {
                    _oldGroup.IsVisible = false;
                    UpdateGroups(_oldGroup);
                }
                group.IsVisible = true;
                UpdateGroups(group);
            }

            _oldGroup = group;
        }

        public void HideOrShowPersones(Persones persone)
        {
            if (_oldPersone == persone)
            {
                persone.IsVisible = !persone.IsVisible;
                UpdatePersone(persone);
            }
            else
            {
                if (_oldPersone != null)
                {
                    _oldPersone.IsVisible = false;
                    UpdatePersone(_oldPersone);
                }
                persone.IsVisible = true;
                UpdatePersone(persone);
            }

            _oldPersone = persone;
        }

        public void HideOrShowAzure(Azure azure)
        {
            if (_oldAzure == azure)
            {
                azure.IsVisible = !azure.IsVisible;
                UpdateAzure(azure);
            }
            else
            {
                if (_oldAzure != null)
                {
                    _oldAzure.IsVisible = false;
                    UpdateAzure(_oldAzure);
                }
                azure.IsVisible = true;
                UpdateAzure(azure);
            }

            _oldAzure = azure;
        }

        private void UpdateCompany (Company company)
        {
            var index = companys.IndexOf(company);

            companys.Remove(company);
            companys.Insert(index, company);
        }

        private void UpdateGroups (Groups group)
        {
            var index = groups.IndexOf(group);

            groups.Remove(group);
            groups.Insert(index, group);
        }

        private void UpdatePersone(Persones persone)
        {
            var index = persones.IndexOf(persone);

            persones.Remove(persone);
            persones.Insert(index, persone);
        }

        private void UpdateAzure(Azure azure)
        {
            var index = azures.IndexOf(azure);

            azures.Remove(azure);
            azures.Insert(index, azure);
        }

        public void RemoveCompany (Company company)
        {
            var index = companys.IndexOf(company);
            companys.RemoveAt(index);
            _oldCompany = null;
        }

        public void RemoveGroup(Groups group)
        {
            var index = groups.IndexOf(group);
            groups.RemoveAt(index);
            _oldGroup = null;
        }

        public void RemovePersone(Persones persone)
        {
            var index = persones.IndexOf(persone);
            persones.RemoveAt(index);
            _oldPersone = null;
        }

        public void RemoveAzure (Azure azure)
        {
            var index = azures.IndexOf(azure);
            azures.RemoveAt(index);
            _oldAzure = null;
        }

        public void ChangePerson (Persones oldPersone, Persones persone)
        {
            var index = persones.IndexOf(oldPersone);

            persones.Remove(oldPersone);
            persones.Insert(index, persone);

            _oldPersone = null;
        }

        public void AddPersone(Persones persone)
        {
            persones.Add(persone);
            _oldPersone = persone;
            HideOrShowPersones(persone);

        }
    }
}
