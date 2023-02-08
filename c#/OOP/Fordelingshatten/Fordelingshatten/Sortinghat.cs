using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fordelingshatten
{
    public class Sortinghat
    {
        public enum Colleges { Gryffindor, Hufflepuff, Ravenclaw, Slytherin }

        public Colleges Sorter()
        {
            Random random = new Random();
            Type type = typeof(Colleges);

            Array values = type.GetEnumValues();

            int index = random.Next(values.Length);
            Colleges value = (Colleges)values.GetValue(index);

            return value;
        }
    }
}
