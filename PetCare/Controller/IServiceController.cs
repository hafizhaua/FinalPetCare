using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare
{
    interface IServiceController
    {
        void Index(Pet pet);
        void ValidateUser(bool accept, Reservation rsv);

    }
}
