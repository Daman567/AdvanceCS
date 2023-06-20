using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Repository<Data>
    {
        public List<Data> Container { get; set; }  

        public Repository() { 
            Container = new List<Data>();
        }

        public string Add(Data item)
        {
            Container.Add(item);

            return "Add";
        }

        public string Delete(Data item)
        {
            if (Container.Contains(item))
            {
                Container.Remove(item);
            }
           
            return "Delete";
        }

        public string Update(Data newItem, Data oldItem)
        {
            for (int i = 0; i < Container.Count; i++)
            {
                if (Container[i] != null && Container[i].Equals(oldItem))
                {
                    Container[i] = newItem;
                }
            }
           
            return "Update";
        }

        public string GetAll()
        {
            return "GetAll";
        }

        public Data CreateNew()
        {
            var newD = default(Data);
            Container.Add(newD);
            return newD;
        }
    }
}
