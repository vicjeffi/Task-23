using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрактическаяРабота23.Models
{
    public class Owner : IWithID
    {
        private string _surname;
        private string _firstname;
        private string _lastname;
        private string adress;
        private DriversLicenseType _licenseType;
        private string _id;
        public string ID { get { if (string.IsNullOrEmpty(_id)) Guid.NewGuid().ToString("N"); return _id; } }
        public string Surname { get { return _surname; } set { _surname = value; } }
        public string Firstname { get { return _firstname;} set { _firstname = value; } }
        public string Lastname { get { return _lastname; } set { _lastname = value; } } 
        public string Adress { get { return adress; } set { adress = value; } }
        public DriversLicenseType DriversLicense { get { return _licenseType; } set { _licenseType = value; } }

        public override string ToString()
        {
            return ID + ": " + string.Join("; ", DriversLicense, Surname, Firstname, Lastname);
        }
    }
}
