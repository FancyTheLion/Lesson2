using AnimalsApp.Enumerations;

namespace AnimalsApp.Abstractions
{
    /// <summary>
    /// Это интерфейс, описывающий общие методы любого млекопитающего
    /// </summary>
    public interface IMammal //ЭТО ЧЕРТЁЖ!
    {
        /// <summary>
        /// Каждое млекопитающее умеет представляться
        /// </summary>
        void Introduce();

        /// <summary>
        /// Каждое млекопитающее имеет право сказать, хочет оно йиффаться с партнёром таким-то или нет
        /// </summary>
        /// <param name="partner">Партнёр, с коим предлагается йифф</param>
        /// <returns>true, если хочет, false, если не хочет</returns>
        bool IsCanYiff(IMammal partner);

        /// <summary>
        /// Йиффаться с указанным партнёром
        /// </summary>
        void Yiff(IMammal partner);

        /// <summary>
        /// Каждое млекопитающее сообщает о своём поле внешнему миру
        /// </summary>
        /// <returns>Пол</returns>
        Sex GetSex();

        /// <summary>
        /// Каждое млекопитающее сообщает о своей ориентации внешнему миру
        /// </summary>
        /// <returns>Ориентация</returns>
        Orientation GetOrientation();
    }
}
