using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПрактическаяРабота23.Models
{
    public class RegistrationPlate
    {
        public static int SeriesLenghtValue { get; set; } = 3;
        public static int NumberLenghtValue { get; set; } = 3;

        private string _series;
        private int _number;
        private int _regionСode;
        private string _country;

        public RegistrationPlate() { }
        public RegistrationPlate(string plate, string country)
        {
            if (plate.Length == 8)
            {
                Series = string.Concat(plate[0], plate[4], plate[5]);
                Number = int.Parse(string.Concat(plate[1], plate[2], plate[3]));
                Region = int.Parse(string.Concat(plate[6], plate[7]));
                Country = country;
            }
            else throw new NotPlateException(plate);
        }
        public RegistrationPlate(string plate)
        {
            Series = string.Concat(plate[0], plate[4], plate[5]);
            Number = int.Parse(string.Concat(plate[1], plate[2], plate[3]));
            Region = int.Parse(string.Concat(plate[6], plate[7]));
            string country = "";
            for (int i = 8; i < plate.Length; i++)
                country += plate[i];
            Country = country;
        }
        public string Series { get { return _series; } set { if (value.Length == 3) _series = value; else throw new NotSeriesException(value); } }
        public int Number { get { return _number; } set { if (value > 99 && value <= 999) _number = value; else throw new NotNumberException(value); } }
        public int Region { get { return _regionСode; } set { _regionСode = value; } }
        public string Country { get { return _country; } set { _country = value; } }

        public override string ToString()
        {
            return string.Join("; ", Series[0] + Number.ToString() + Series[1] + Series[2], Region, Country);
        }
    }
    public class NotSeriesException : Exception
    {
        private string notASeries;
        protected NotSeriesException()
           : base() { }

        public NotSeriesException(string value) :
           base(String.Format("{0} не допустимый формат серри автомобиля, он должен влючать в себя {1} символа, а не " + value.Length, value, RegistrationPlate.SeriesLenghtValue))
        {
            notASeries = value;
        }
        public string Value
        { get { return notASeries; } }
    }
    public class NotNumberException : Exception
    {
        private int notANumber;
        protected NotNumberException()
           : base() { }

        public NotNumberException(int value) :
           base(String.Format("{0} не допустимый формат номера автомобиля, он должен влючать в себя {1} символа, а не " + value.ToString().Length, value, RegistrationPlate.NumberLenghtValue))
        {
            notANumber = value;
        }
        public int Value
        { get { return notANumber; } }
    }
    public class NotPlateException : Exception
    {
        private string notASeries;
        protected NotPlateException()
           : base() { }

        public NotPlateException(string value) :
           base(String.Format("{0} не допустимый формат номерного знака автомобиля", value))
        {
            notASeries = value;
        }
        public string Value
        { get { return notASeries; } }
    }
}
