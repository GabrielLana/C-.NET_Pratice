using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoVetores01
{
    internal class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte Room { get; set; }

        public override string ToString()
        {
            if (Name == String.Empty && Email == String.Empty)
                return null;
            return $"{Room}: {Name}, {Email}";
        }
    }
}
