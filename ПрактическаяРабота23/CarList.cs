using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПрактическаяРабота23.Models;

namespace ПрактическаяРабота23
{
    class CarList : SearchableList<Car>
    {
        public Car Find(string carId)
        {
            Car car = FindById(carId);
            if (car != null)
            {
                return car;
            }
            return null;
        }
        public bool TryFind(string carId, out Car car)
        {
            car = FindById(carId);
            if (car != null)
            {
                return true;
            }
            return false;
        }
        public void SortByNumber()
        {
            int size = Capacity;
            for (int i = 1; i < size; i++)
            {
                for (int j = 0; j < (size - i); j++)
                {
                    if (this[j].Plate.Number > this[j + 1].Plate.Number)
                    {
                        int temp = this[j].Plate.Number;
                        this[j].Plate.Number = this[j + 1].Plate.Number;
                        this[j + 1].Plate.Number = temp;

                        // Нифига что можно >>>
                        // (this[j + 1].Number.Number, this[j].Number.Number) = (this[j].Number.Number, this[j + 1].Number.Number);
                    }
                }
            }
        }
    }
}
