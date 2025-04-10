using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customGenericList
{
    class CustomList<T>
    {

        public int Count { get; set; }
        public int Capacity { get; set; }

        T[] customList;
        public CustomList()
        {
            Count = _count;
            Capacity = _capacity;
            customList = new T[Capacity];

        }
        static int _count = 1;  
        static int _capacity;
        public void Add(T t)
        {
            if(Count == Capacity)
            {
                Capacity *= 2;
                customList[Count - 1] = t;
                Count++;
            }else if(Count == 0)
            {
                Capacity = 4;
                customList[Count - 1] = t;
                Count++;
            }
            else
            {
                customList[Count - 1] = t;
                Count++;
            }
        }

        public T Find(Predicate<T> condition) 
        {
            
        }

        public bool reqemdimi(string x) //Bunu Findin icinde yaziriqmis)) Sora qamma nedise onnan alasiyiq. Onnan sert alasiyiq hemen serte uygun elementi cixardasiyiq bizde
        {
            decimal dec;
            if(decimal.TryParse(x, out dec))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
