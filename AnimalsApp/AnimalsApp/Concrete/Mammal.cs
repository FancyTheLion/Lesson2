using AnimalsApp.Abstractions;
using AnimalsApp.Enumerations;

namespace AnimalsApp.Concrete
{
    /// <summary>
    /// Предок всех млекопитающих
    /// </summary>
    public class Mammal : IMammal
    {
        /// <summary>
        /// Имя животного
        /// </summary>
        protected string Name { get; set; }

        /// <summary>
        /// Пол животного
        /// </summary>
        protected Sex Sex { get; set; }

        /// <summary>
        /// Ориентация
        /// </summary>
        protected Orientation Orientation { get; set; }

        public Mammal // Это конструктор
        (
            string name,
            Sex sex,
            Orientation orientation
        )
        {
            Name = name; // Что здесь происходит? У него же есть эти параметры, зачем это делать
            Sex = sex;
            Orientation = orientation;
        }

        public Orientation GetOrientation() // Это ведь называется методом?
        {
            return Orientation;
        }

        public Sex GetSex()
        {
            return Sex;
        }

        /// <summary>
        /// virtual = способный меняться = означает, что потомки могут изменить поведение этого метода
        /// </summary>
        public virtual void Introduce()
        {
            Console.WriteLine($"Я - млекопитающее. Меня зовут { Name }");
        }

        public bool IsCanYiff(IMammal partner)
        {
            switch (Orientation)
            {
                // Это животное - гетеро, оно требует не свой пол
                case Orientation.Straight:
                    return Sex != partner.GetSex();

                // Это животное - би, ему годится любой пол
                case Orientation.Bi:
                    return true;

                // Это животное - гомо, оно требует свой пол
                case Orientation.Gay:
                    return Sex == partner.GetSex();

                default:
                    throw new ArgumentException("Неизвестная ориентация!");
            }
        }

        public void Yiff(IMammal partner)
        {
            Console.WriteLine("Предполагается йифф между:");
            Introduce(); // Представляемся сами
            partner.Introduce(); // Представляется партнёр

            // Хотим-ли мы йиффаться с партнёром?
            bool isWantToYiff = IsCanYiff(partner);

            if (!isWantToYiff)
            {
                Console.WriteLine("Нам не нравится партнёр!");
                return;
            }

            // Хочет-ли партнёр йиффаться с нами?
            bool isPartnerWantsUs = partner.IsCanYiff(this); // this - это мы сами (объект того класса,
            // с которым мы сейчас работаем)

            if (!isPartnerWantsUs)
            {
                Console.WriteLine("Мы не нравимся партнёру!");
                return;
            }

            Console.WriteLine("Мы успешно пойиффались!");
        }
    }
}
