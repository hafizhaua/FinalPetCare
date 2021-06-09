using PetCare.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetCare.View.PetView;

namespace PetCare
{
    public class PetController
    {
		public static void Index(int CustID)
        {
			using (var db = new AppPetCareContext())
			{
				var list = db.Pet
						.Where(pet => pet.CustomerID == CustID);
				IndexView.Show(list);
			}
        }

        public static void Add(int CustID)
        {
            AddView.Show(CustID);
        }

        public static void Add(Pet pet, bool isValid)
        {
            using (var context = new AppPetCareContext())
            {
				if(isValid)
                {
					context.Pet.Add(pet);
					context.SaveChanges();
					AddView.Success();
				}
                else
                {
					AddView.Failed();
                }
            }
        }

		public static void Delete(int CustID)
        {
			using (var db = new AppPetCareContext())
			{
				var list = db.Pet
						.Where(pet => pet.CustomerID == CustID);
				int count = list.Count();
				DeleteView.Show(CustID, count);
			}
        }

        public static void Delete(int CustID, int PetRemoveID)
        {
			using (var db = new AppPetCareContext())
			{
				var pet = db.Pet.SingleOrDefault(pet => pet.PetID == PetRemoveID && pet.CustomerID == CustID);
				if (pet != default)
				{
					DeleteView.Success(pet.Name);
					db.Remove(pet);

					var rsv = db.Reservations.SingleOrDefault(res => res.PetID == PetRemoveID);
					if (rsv != default)
					{
						db.Remove(rsv);

					}
					db.SaveChanges();
				}
				else
				{
					DeleteView.Failed();
				}
			}
		}

		public static void Detail(int CustID)
        {
			using (var db = new AppPetCareContext())
            {
				var list = db.Pet
						.Where(pet => pet.CustomerID == CustID);
				int count = list.Count();

				DetailView.Show(CustID, count);
			}
				
        }

		public static void Detail(int CustID, int PetDetailID)
        {
			using (var db = new AppPetCareContext())
            {
				var pet = db.Pet.SingleOrDefault(pet => pet.PetID == PetDetailID && pet.CustomerID == CustID);
				if (pet != default)
				{
					DetailView.Success(pet);
				}
				else
				{
					DetailView.Failed();
				}
			}
		}
    }
}
