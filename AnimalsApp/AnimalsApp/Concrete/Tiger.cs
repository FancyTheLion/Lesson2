using AnimalsApp.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalsApp.Concrete
{
    public class Tiger : Mammal
    {
        /// <summary>
        /// Количество полосок
        /// </summary>
        private int _stripesCount { get; set; }

        public Tiger
        (
            string name,
            Sex sex,
            Orientation orientation,
            int stripesCount
        ) : base(name, sex, orientation)
        {
            _stripesCount = stripesCount;
        }

        public override void Introduce()
        {
            Console.WriteLine($"Я - тигр. Меня зовут {Name}. На мне {_stripesCount} полосок.");
        }
    }
}
