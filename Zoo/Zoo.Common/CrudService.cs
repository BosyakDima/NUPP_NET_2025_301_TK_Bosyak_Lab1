using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo.Common
{
    public class CrudService<T> : ICrudService<T> where T : IIdentifiable
    {
        private readonly List<T> _storage; // Замість короткої форми new(), вказуємо тип List<T>

        // Конструктор для ініціалізації _storage
        public CrudService()
        {
            _storage = new List<T>(); // Ініціалізація списку
        }

        // Метод Create
        public void Create(T element)
        {
            _storage.Add(element);
        }

        // Метод Read
        public T Read(Guid id)
        {
            return _storage.FirstOrDefault(e => e.Id == id);
        }

        // Метод ReadAll
        public IEnumerable<T> ReadAll()
        {
            return _storage;
        }

        // Метод Update
        public void Update(T element)
        {
            var index = _storage.FindIndex(e => e.Id == element.Id);
            if (index != -1)
            {
                _storage[index] = element;
            }
        }

        // Метод Remove
        public void Remove(T element)
        {
            _storage.RemoveAll(e => e.Id == element.Id);
        }
    }
}