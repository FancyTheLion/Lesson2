using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsApp.Abstractions
{
    /// <summary>
    /// Действия, которые может совершить грузовик
    /// </summary>
    public interface ITruck
    {
        /// <summary>
        /// Сообщить вес груза, который он может перевозить
        /// </summary>
        void PrintCargeSize();
    }
}
