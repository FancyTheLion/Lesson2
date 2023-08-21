using AnimalsApp.Abstractions;
using AnimalsApp.Enumerations;

namespace AnimalsApp.Concrete
{
    public class Zebra : Mammal, IAnimalsWithStripes
    {
        /// <summary>
        /// Количество полосок у зебры
        /// </summary>
        private int _stripesCount { get; set; }

        public Zebra
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
            Console.WriteLine($"Я - зебра. Меня зовут {Name}");
        }

        public void TellAboutStripse()
        {
            Console.WriteLine($"Я полосатая зебра. На мне {_stripesCount} полосок");
        }
    }
}
