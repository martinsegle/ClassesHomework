

namespace ClassesHomework
{
    public class Telephone
    {
        public Telephone (string telephoneBrand)
        {
            TelephoneBrand = telephoneBrand;
            Console.WriteLine($"Telephone Brand is: {TelephoneBrand}");
        }

        public string TelephoneBrand { get; set; }
        public string TelephoneModel { get; set; }
        public double TelephoneLenght { get; set; }
        public double TelephoneWidth { get; set; }
        public double TelephoneHight { get; set; }
        
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call from {TelephoneBrand} {TelephoneModel} to {phoneNumber}");

        }

        public void SendSMS(string phoneNumber)
        {
            Console.WriteLine($"Send SMS form {TelephoneBrand} {TelephoneModel} to phone number {phoneNumber}");

        }



    }
}
