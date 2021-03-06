﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string nickName;
        private string foto;
        private string title;
        private string company = "";
        private string contactAddress1;
        private string phoneHome;
        private string phoneMobile;
        private string phoneWork = "";
        private string fax = "";
        private string eMail1 = "";
        private string eMail2 = "";
        private string eMail3 = "";
        private string homePage = "";
        private string birthDay;
        private string birthMonth;
        private string birthYear;
        private string annivDay;
        private string annivMonth;
        private string annivYear;
        private string contactGroup;
        private string contactAddress2;
        private string phone2;
        private string contactNotes;


        public ContactData(string firstName)
        {
            this.firstName = firstName;
        }


        public ContactData(string firstName, string middleName, string lastName,
                            string nickName, string foto, string title, 
                            string company, string contactAddress1, string phoneHome,
                            string phoneMobile, string phoneWork, string fax,
                            string eMail1, string eMail2, string eMail3, string homePage,
                            string birthDay, string birthMonth, string birthYear,
                            string annivDay, string annivMonth, string annivYear, 
                            string contactGroup, string contactAddress2, string phone2, string contactNotes)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.nickName = nickName;
            this.foto = foto;
            this.title = title;
            this.company = company;
            this.contactAddress1 = contactAddress1;
            this.phoneHome = phoneHome;
            this.phoneMobile = phoneMobile;
            this.phoneWork = phoneWork;
            this.fax = fax;
            this.eMail1 = eMail1;
            this.eMail2 = eMail2;
            this.eMail3 = eMail3;
            this.homePage = homePage;
            this.birthDay = birthDay;
            this.birthMonth = birthMonth;
            this.birthYear = birthYear;
            this.annivDay = annivDay;
            this.annivMonth = annivMonth;
            this.annivYear = annivYear;
            this.contactGroup = contactGroup;
            this.contactAddress2 = contactAddress2;
            this.phone2 = phone2;
            this.contactNotes = contactNotes;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middleName;
            }
            set
            {
                middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string NickName
        {
            get
            {
                return nickName;
            }
            set
            {
                nickName = value;
            }
        }

        public string Foto
        {
            get
            {
                return foto;
            }
            set
            {
                foto = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }


        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }


        public string Address
        {
            get
            {
                return contactAddress1;
            }
            set
            {
                contactAddress1 = value;
            }
        }


        public string PhoneHome
        {
            get
            {
                return phoneHome;
            }
            set
            {
                phoneHome = value;
            }
        }


        public string PhoneMobile
        {
            get
            {
                return phoneMobile;
            }
            set
            {
                phoneMobile = value;
            }
        }


        public string PhoneWork
        {
            get
            {
                return phoneWork;
            }
            set
            {
                phoneWork = value;
            }
        }


        public string Fax
        {
            get
            {
                return fax;
            }
            set
            {
                fax = value;
            }
        }

        public string EMail1
        {
            get
            {
                return eMail1;
            }
            set
            {
                eMail1 = value;
            }
        }

        public string EMail2
        {
            get
            {
                return eMail2;
            }
            set
            {
                eMail2 = value;
            }
        }

        public string EMail3
        {
            get
            {
                return eMail3;
            }
            set
            {
                eMail3 = value;
            }
        }


        public string HomePage
        {
            get
            {
                return homePage;
            }
            set
            {
                homePage = value;
            }
        }


        public string BirthDay
        {
            get
            {
                return birthDay;
            }
            set
            {
                birthDay = value;
            }
        }


        public string BirthMonth
        {
            get
            {
                return birthMonth;
            }
            set
            {
                birthMonth = value;
            }
        }

        public string BirthYear
        {
            get
            {
                return birthYear;
            }
            set
            {
                birthYear = value;
            }
        }


        public string AnnivDay
        {
            get
            {
                return annivDay;
            }
            set
            {
                annivDay = value;
            }
        }

        public string AnnivMonth
        {
            get
            {
                return annivMonth;
            }
            set
            {
                annivMonth = value;
            }
        }

        public string AnnivYear
        {
            get
            {
                return annivYear;
            }
            set
            {
                annivYear = value;
            }
        }

        public string ContactGroup
        {
            get
            {
                return contactGroup;
            }
            set
            {
                contactGroup = value;
            }
        }

        public string Address2
        {
            get
            {
                return contactAddress2;
            }
            set
            {
                contactAddress2 = value;
            }
        }

        public string Phone2
        {
            get
            {
                return phone2;
            }
            set
            {
                phone2 = value;
            }
        }

        public string ContactNotes
        {
            get
            {
                return contactNotes;
            }
            set
            {
                contactNotes = value;
            }
        }


    }
}
