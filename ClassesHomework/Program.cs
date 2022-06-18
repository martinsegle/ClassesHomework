using ClassesHomework;

Console.WriteLine("Ievadi sava telefona marku!");
string telephoneBrand = Console.ReadLine();

Console.WriteLine("Ievadi sava telefona modeli!");
string telephoneModel = Console.ReadLine();

Console.WriteLine("Ievadi sava telefona garumu!");
string telephoneLenghtText = Console.ReadLine();
int telephoneLenght = int.Parse(telephoneLenghtText);

Console.WriteLine("Ievadi sava telefona platumu!");
string telephoneWidthText = Console.ReadLine();
int telephoneWidth = int.Parse(telephoneWidthText);

Console.WriteLine("Ievadi sava telefona augstumu!");
string telephoneHightText = Console.ReadLine();
int telephoneHight = int.Parse(telephoneHightText);

Telephone telephone = new Telephone();

telephone.TelephoneBrand = telephoneBrand;
telephone.TelephoneModel = telephoneModel;
telephone.TelephoneLenght = telephoneLenght;
telephone.TelephoneWidth = telephoneWidth;
telephone.TelephoneHight = telephoneHight;

telephone.Call("12345678");

telephone.SendSMS("12345678");

Console.WriteLine();
Console.WriteLine("=============================");
Console.WriteLine();



