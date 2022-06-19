using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Car
    {
        public string CarBrand { get; set; }
        public string CarLicensePlate { get; set; }
        public double CarSpeed { get; set; }
        public bool IsSpeed { get; set; }
        public void StartToDrive()
        {
            Console.WriteLine($"Ātrums ir {CarSpeed}, automašīna ir uzsākusi braukt {IsSpeed}");
        }

        public double IncreaseSpeed()
        {
            CarSpeed += 10;
            Console.WriteLine($"Automašīna paātrinās, jo ātrums ir {CarSpeed}");
            return CarSpeed;
        }

        public double DecreaseSpeed()
        {
            CarSpeed -= 10;
            Console.WriteLine($"Automašīna palēninās, jo ātrums ir {CarSpeed}");
            return CarSpeed;
        }

        public double StopToDrive()
        {
            CarSpeed = 0;
            Console.WriteLine($"Automašīna ir apstājusies, jo ātrums ir {CarSpeed}");
            return CarSpeed;
        }

        public void Horn()
        {
            Console.WriteLine($"Beep beep");
        }
    }
}
