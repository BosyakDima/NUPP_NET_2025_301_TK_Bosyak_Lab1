using System;

namespace Zoo.Common
{
    public class Animal : IIdentifiable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Location { get; set; }
    }

    public class Mammal : Animal
    {
        public string FurColor { get; set; }

        // Конструктор
        public Mammal(string name, int age, string species, string furColor, string location)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Species = species;
            FurColor = furColor;
            Location = location;
        }
    }

    public class Bird : Animal // Клас Bird, який наслідується від Animal
    {
        public string FFeatherColor { get; set; }

        public Bird(string name, int age, string species, string ffeatherColor, string location)
        {
            Id = Guid.NewGuid();
            Name = name;
            Age = age;
            Species = species;
            FFeatherColor = ffeatherColor;
            Location = location;
        }
    }
}
