using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoHenranca.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {

        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name} ${Price + CustomFee} (Custom fee: ${CustomFee})";
        }
    }
}
