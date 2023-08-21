namespace CarsApp.Abstractions
{
    /// <summary>
    /// Интерфейс, описывающий методы для всех машин
    /// </summary>
    public interface ICar
    {
        /// <summary>
        /// Завести машину
        /// </summary>
        void StartEngine();

        /// <summary>
        /// Заглушить машину
        /// </summary>
        void StopEngine();

        /// <summary>
        /// Движение куда-либо
        /// </summary>
        /// <param name="destination">Место назначения</param>
        void DriveTo(string destination);
    }
}
