using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Common.Extensions
{
    public static class AnimalExtensions
    {
        public static string GetInfo(this Animal animal)
        {
            return $"Name: {animal.Name}, Location: {animal.Location}";
        }
    }
}