using System;
using Zoo.Common;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо кілька об'єктів
        var mammal = new Mammal("Leo", 5, "Lion", "Golden", "Savannah");
        var bird = new Bird("Parrot", 2, "Macaw", "Red-Green", "Tropical Zone");

        // Створюємо сервіс для збереження
        ICrudService<Animal> animalService = new CrudService<Animal>();

        // Додаємо тварин до сервісу
        animalService.Create(mammal);
        animalService.Create(bird);

        // Виводимо всіх тварин
        Console.WriteLine("All animals:");
        foreach (var animal in animalService.ReadAll())
        {
            Console.WriteLine(animal.Name);
        }

        // Зчитуємо об'єкт за ID
        var animalToRead = animalService.Read(mammal.Id);
        if (animalToRead != null)
        {
            Console.WriteLine($"Animal with ID {mammal.Id}: {animalToRead.Name}");
        }

        // Оновлюємо тварину
        bird.Name = "Golden Eagle";
        animalService.Update(bird);

        // Виводимо оновлену інформацію
        Console.WriteLine($"Updated Bird: {bird.Name}");

        // Видаляємо тварину
        animalService.Remove(mammal);

        // Виводимо залишкові тварини
        Console.WriteLine("Remaining animals:");
        foreach (var animal in animalService.ReadAll())
        {
            Console.WriteLine(animal.Name);
        }
    }
}