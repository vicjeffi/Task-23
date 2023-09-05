using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрактическаяРабота23.Models
{
    public class Car : IWithID, IOwned
    {
        private RegistrationPlate _number;
        private string _model;
        private string _color;
        private DateTime _date;
        private Owner _owner;

        public string _id;
        public string ID { get { if (_id == null) Guid.NewGuid().ToString("N"); return _id; } }
        public RegistrationPlate Plate { get { return _number; } set { _number = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public string Color { get { return _color; } set { _color = value; } }
        public DateTime RegistrationDate { get { return _date; } set { _date = value; } }
        public Owner Owner { get { return _owner; } set { _owner = value; } }
        public override string ToString()
        {
            return ID + ": " + string.Join(" ;", Plate, Owner, Model, Color, RegistrationDate);
        }
    }
}
