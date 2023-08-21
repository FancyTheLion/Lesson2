using AnimalsApp.Enumerations;

namespace AnimalsApp.Concrete
{
    public class Lion : Mammal
    {
        /// <summary>
        /// Цвет гривы этого льва
        /// </summary>
        private ManeColor _maneColor { get; set; } // это свойство приватное, только для льва

        public Lion 
        (
            string name,
            Sex sex,
            Orientation orientation,
            ManeColor maneColor
        ) : base(name, sex, orientation)
        {
            _maneColor = maneColor; // Здесь оно задается чтобы где то быть
        }

        /// <summary>
        /// Это перегруженный метод "Представься". Слово "override" означает "я вызываюсь вместо метода предка"
        /// </summary>
        public override void Introduce()
        {
            Console.WriteLine($"Я - лев. Меня зовут { Name }. Моя грива { GetManeColorDescription() }");
        }

        private string GetManeColorDescription()
        {
            switch(_maneColor)
            {
                case ManeColor.Gold:
                    return "Золотая";

                case ManeColor.Blue:
                    return "Синяя";

                case ManeColor.White:
                    return "Белая";

                default:
                    throw new ArgumentException("Неизвестный цвет гривы!");
            }
        }
    }
}
