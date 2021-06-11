using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    interface ICustomerModel : IAccountModel
    {
        public int CustomerID { get; set; }
    }
}
