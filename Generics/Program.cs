using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            sehirler.Add("İstanbul");
            // "List" diye halihazırda bir class vardır. Ve bu class generic yapısındadır.
            // Generic yapılar, aşağıda oluşturduğumuz "MyList" isimli class'ımıza "<T>" yazdığımızda tipimizi daha sonradan isteğimize göre
            // değiştirebilmemiz için vardırlar. Buradaki "<T>" Type'ın T'sidir. İstediğimiz şekilde isimlendirebiliriz.

            Console.WriteLine(sehirler.Count);

            MyList<int> sehirler2 = new MyList<int>();
            sehirler2.Add(34);
            sehirler2.Add(34);
            sehirler2.Add(34);
            sehirler2.Add(34);
            sehirler2.Add(34);
            sehirler2.Add(34);
            Console.WriteLine(sehirler2.Count);
            
        }
    }
    class MyList<T> // Generic Class
    {
        T[] _array;
        T[] _tempArray; // geçici anlamında. 
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
