using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    interface IMenuController
    {
        void Index(int CustID);
        void Index(int CustID, string Option);
    }
}
