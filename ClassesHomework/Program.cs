using ClassesHomework;

Console.WriteLine("Ievadi sava telefona marku!");
string telephoneBrand = Console.ReadLine();

Console.WriteLine("Ievadi sava telefona modeli!");
string telephoneModel = Console.ReadLine();

Console.WriteLine("Ievadi sava telefona garumu!");
string telephoneLenghtText = Console.ReadLine();
double telephoneLenght = double.Parse(telephoneLenghtText);

Console.WriteLine("Ievadi sava telefona platumu!");
string telephoneWidthText = Console.ReadLine();
double telephoneWidth = double.Parse(telephoneWidthText);

Console.WriteLine("Ievadi sava telefona augstumu!");
string telephoneHightText = Console.ReadLine();
double telephoneHight = double.Parse(telephoneHightText);

Console.WriteLine("Kam Tu vēlies piezvanīt (ievadi tālr.nr.)?");
string phoneNumber = Console.ReadLine();


Telephone telephone = new Telephone(telephoneBrand);

telephone.TelephoneBrand = telephoneBrand;
telephone.TelephoneModel = telephoneModel;
telephone.TelephoneLenght = telephoneLenght;
telephone.TelephoneWidth = telephoneWidth;
telephone.TelephoneHight = telephoneHight;

telephone.Call(phoneNumber);

telephone.SendSMS(phoneNumber);

Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();

Console.WriteLine("Ievadi automašīnas marku!");
string carBrand = Console.ReadLine();

Console.WriteLine("Ievadi automašīnas numurzīmi!");
string carLicensePlate = Console.ReadLine();

Console.WriteLine("Ievadi automašīnas ātrumu!");
string carSpeedText = Console.ReadLine();
double carSpeed = double.Parse(carSpeedText);

bool isSpeed = carSpeed > 0;

Car car = new Car();

car.CarBrand = carBrand;
car.CarLicensePlate = carLicensePlate;
car.CarSpeed = carSpeed;
car.IsSpeed = isSpeed;

car.StartToDrive();
car.IncreaseSpeed();
car.DecreaseSpeed();
car.StopToDrive();
car.Horn();

Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();

Console.WriteLine("Ievadi produkta augstumu!");
double height = double.Parse(Console.ReadLine());

Product product = new Product(height, 5, 2, 20);

product.Specs();

Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();

Person person = new Person();

Console.WriteLine("Enter your name!");
string name = Console.ReadLine();

Console.WriteLine("Enter your surname!");
string surname = Console.ReadLine();

Console.WriteLine("Enter your birth date in following format dd.mm.yyyy!");
string birthDateText = Console.ReadLine();
DateTime birthDate = DateTime.Parse(birthDateText);

Console.WriteLine("What is your hobby!");
string hobby = Console.ReadLine();

Console.WriteLine("What is your gender - male or female?");
bool gender = Console.ReadLine().StartsWith('m');


person.Name = name;
person.Surname = surname;
person.BirthDate = birthDate;
person.Hobby = hobby;
person.Gender = gender;

person.GetAge();

person.Greeting();





