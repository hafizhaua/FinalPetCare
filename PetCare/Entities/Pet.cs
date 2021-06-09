using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetCare.Entities
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }
        public string Animal { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public double Weight { get; set; }
        public int CustomerID { get; set; }

        public void ShowPetDetail()
        {
            Console.WriteLine($"\nAnimal\t: {Animal}");
            Console.WriteLine($"Name\t: {Name}");
            Console.WriteLine($"ID\t: {PetID}");
            Console.WriteLine($"Sex\t: {Sex}");
            Console.WriteLine($"Weight\t: {Weight} kg\n");
        }
    }
}
