
namespace BankBuisnessTier
{
    public abstract class clsPerson
    {      
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Phone {get; set; }
        public string Address { get; set;}

        protected clsPerson(string FirstName, string MiddleName, string LastName, string Phone, string Address) 
        {                      
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Address = Address;
        }

        public string FullName()
        {
            if (MiddleName == "")
                return FirstName + " " + LastName;
            else
                return FirstName + " " + MiddleName + " " + LastName;
        }
    }
}
