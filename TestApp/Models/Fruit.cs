using System;
namespace TestApp.Models
{
    public class Fruit
    {
        public string Description { get; set; }
        public string Name { get; set; }
    }

    public class Root
    {
        public List<Fruit> Fruits { get; set; }
    }
}

