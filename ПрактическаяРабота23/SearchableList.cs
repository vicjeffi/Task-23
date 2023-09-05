using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ПрактическаяРабота23.Models;

namespace ПрактическаяРабота23
{
    abstract class SearchableList<T>: List<T> where T : IWithID
    {
        public T FindById(string id)
        {
            foreach( var item in this)
            {
                if (item != null)
                {
                    if (item.ID == id)
                        return item;
                }
            }
            return default(T);
        }
    }
}
