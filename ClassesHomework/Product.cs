

namespace ClassesHomework
{
    public class Product
    {
        public Product(double height, double lenght, double width, double weight)
        {
            Height = height;
            Lenght = lenght;
            Width = width;
            Weight = weight;
        }

        public double Height { get; }
        public double Lenght { get;  }
        public double Width { get;  }
        public double Weight { get;  }

        public void Specs()
        {
            Console.WriteLine($"Preces augstums ir {Height}, garums {Lenght}, platums {Width} un svars {Weight}.");
        }

    }
}
