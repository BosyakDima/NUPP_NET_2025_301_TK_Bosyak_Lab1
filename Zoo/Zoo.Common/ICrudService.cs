using System;
using System.Collections.Generic;

namespace Zoo.Common
{
    public interface ICrudService<T>
    {
        void Create(T element);               // Додавання нового елементу
        T Read(Guid id);                      // Отримання елементу за ID
        IEnumerable<T> ReadAll();             // Отримання усіх елементів
        void Update(T element);               // Оновлення елементу
        void Remove(T element);               // Видалення елементу
    }
}