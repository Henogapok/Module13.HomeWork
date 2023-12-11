using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13.HomeWork
{
    public class Client
    {
        public int ClientId { get; set; }
        public DateTime RegistrationDate { get; set; }

        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public string IIN { get; set; }
        public int ServiceID { get; set; }

        public string ShortName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(LastName))
                {
                    return string.Format("{0} {1}.{2}.", FirstName, SecondName[0], LastName);
                }
                else
                {
                    return string.Format("{0} {1}.", FirstName, SecondName[0]);
                }
            }
        }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get
            {
                return (DateTime.Now.Year - BirthDate.Year);
            }
        }


      

      
    }

}
