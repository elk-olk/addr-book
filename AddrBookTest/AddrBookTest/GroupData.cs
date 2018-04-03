using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
     public class GroupData
    {
        private string grName;
        private string grHeader="";
        private string grFooter="";

        public GroupData(string grName)
        {
            this.grName = grName;
        }


        public GroupData(string grName, string grHeader, string grFooter)
        {
            this.grName = grName;
            this.grHeader = grHeader;
            this.grFooter = grFooter;
        }


        public string GrName
        {
            get
            {
                return grName;
            }
            set
            {
                grName = value;
            }
        }

        public string GrHeader
        {
            get
            {
                return grHeader;
            }
            set
            {
                grHeader = value;
            }
        }

        public string GrFooter
        {
            get
            {
                return grFooter;
            }
            set
            {
                grFooter = value;
            }
        }

    }
}
