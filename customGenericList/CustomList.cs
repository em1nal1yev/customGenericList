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
            customList = new T[0];

        }
        static int _count ;  
        static int _capacity;
        public void Add(T? t)
        {
            if(Count == Capacity && Capacity > 0)
            {
                Capacity *= 2;
                Array.Resize(ref customList, Capacity);
                customList[Count] = t;
                Count++;
                
            }else if(Count == 0)
            {
                Capacity = 4;
                Array.Resize(ref customList, Capacity);
                customList[Count ] = t;
                Count++;
            }
            else if(Count > 0 && Count <4)
            {
                Array.Resize(ref customList, Capacity);
                customList[Count ] = t;
                Count++;
            }
        }

        public T? Find(Predicate<T?> eger) 
        {
            for(int i=0;i<customList.Length;i++)
            {
                if (eger(customList[i]))
                {
                    return customList[i];
                }
            }
            return default;
        }


        //Ugursuz cehd Find ucun
        //public bool reqemdimi(string x) //Bunu Findin icinde yaziriqmis)) Sora qamma nedise onnan alasiyiq. Onnan sert alasiyiq hemen serte uygun elementi cixardasiyiq bizde
        //{
        //    decimal dec;
        //    if(decimal.TryParse(x, out dec))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        public T?[] FindAll(Predicate<T?> eger) //NullReferanceException aliram
        {
            T[] returnList = new T[0];
            for (int i = 0; i < customList.Length; i++)
            {
                if (eger(customList[i]))
                {
                    Array.Resize(ref returnList, returnList.Length + 1);
                    returnList[^1] = customList[i];
                }
            }
            return returnList;
        }


    }
}
