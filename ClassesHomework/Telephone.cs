

namespace ClassesHomework
{
    public class Telephone
    {
        public string TelephoneBrand { get; set; }
        public string TelephoneModel { get; set; }
        public int TelephoneLenght { get; set; }
        public int TelephoneWidth { get; set; }
        public int TelephoneHight { get; set; }
        
        public void Call(string phoneNumber)
        {
            Console.WriteLine($"Call form {TelephoneBrand} {TelephoneModel} to {phoneNumber}");

        }

        public void SendSMS(string phoneNumber)
        {
            Console.WriteLine($"Send SMS form {TelephoneBrand} {TelephoneModel} to phone number {phoneNumber}");

        }



    }
}
