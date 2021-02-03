using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  DICTIONARY :
                Standart diziler sabit boyutludur, programlama aşamasında dizinin boyutu belirtilir ve programın çalışması sırasında
            değiştirilemez. Dictionary ise değişken boyutludur. Eleman ekleme ve çıkarma durumuna göre boyutu dinamik olarak değişmektedir.

                TEMEL YAPISI :
                Standart dizilere eklenen elemanlar, belleğe sıralı bir şekilde yerleştirilmektedir. Sıfırdan başlanarak her bir elemana 
            birer index değeri verilip, elemanlara o indexler aracılığıyla erişmemiz sağlanmaktaydı.
                Koleksiyon sınıflarından biri olan "ArrayList" içinde aynı durum söz konusu. "ArrayList"e eklenen her bir elemena index
            numarasıyla erişebilmekteyiz.
                Dictionary koleksiyonunda ise "Anahtar(Key)" ve "Değer(Value)" olmak üzere iki kavram karşımıza çıkmakta.
            Konuyu daha anlaşılır kılmak açısından; standart dizilere eklediğimiz elemanları "Değer(Value)", o elemanlara erişmek 
            için kullandığımız indexleri de "Anahtar(Key)" olarak düşünebiliriz.
                Her bir "Değer(Value)"nin farklı bir "Anahtarı(Key)"ı olmalıdır. Yani koleksiyon içersinde yer alan "Key"ler 
            birbirlerinden farklı olmalıdır.
                Dictionary sınıfından bir nesne oluştururken, anahtar ve değerin veri tiplerini belirtmemiz gerekmekte.

                KULLANIMI :
                Öncelikle sınıfı kullanmak için """ System.Collections.Generic; """ kütüphanesini çağırmamız gerekir.
            
            Methodlar ve Özellikler : 
            1- ContainsKey(Aranan_Key) Methodu:
                Koleksiyon içersinde, parametre olarak girilen değerde bir Anahtar(Key) mevcutsa TRUE değilse FALSE döndürecektir.
            
            2- ContainsValue(Aranan_Value) Methodu : 
                Koleksiyon içerisinde, parametre olarak girilen değerde bir Değer(Value) mevcutsa TRUE değilse FALSE döndürecektir.

            3- Clear() Methodu : 
                Koleksiyon içerisinde yer alan tüm Anahtar-Değer çiftlerini silmektedir.

            4- Count Özelliği :
                Koleksiyon içinde bulunan Anahtar/Değer çiftlerinin sayısını döndürmektedir.
            
            5- Remove(Silinecek_Key) Methodu : 
                Koleksiyo içerisinde, parametre olarak girilen değerde bir Anahtar(Key) mevcutsa; Anahtarı ve anahtarla ilişkili Değeri 
            silip TRUE döndürecektir. Anahtar mevcut değilse FALSE döndürecektir.
            
            6- Keys Özelliği :
                Anahtarları (Keys) içeren bir koleksiyon döndürmektedir.

            7- Values Özelliği :
                Değerleri(Values) içeren bir koleksiyon döndürmektedir.

            8 - KeyValuePair<Key_Tipi, Value_Tipi> Yapısı :
                Bu yapı koleksiyon içerisinded yer alan Anahtar-Değer çiftlerini tutmaktadır.

            9- TryGetValue(a, out b) Methodu : 
                Koleksiyon içerisinde "a" anahtarını mevcutsa"a" anahtarı ile ilişkili Değeri "b" değişkenine aktarığ değeri TRUE 
            döndürmektedir. Anahtar mevcut değilse FALSE döndürecektir.

            */

            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(1994, "Elif PİRGAİP");
            Ogrenci.Add(1071, "Emine EZER");
            Ogrenci.Add(1881, "Haldun EZMEZ");

            Console.WriteLine("Öğrenci No Giriniz : ");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch (Exception)
            {

                Console.WriteLine("Öğrenci Bulunamadı... "); 
            }

            bool varMi1 = Ogrenci.ContainsKey(1071); // Methodlar ve Özellikleri 1.Madde örneği.
            Console.WriteLine("ContainsKey Örneği : " + varMi1);

            bool varMi2 = Ogrenci.ContainsValue("Elif PİRGAİP"); // Methodlar ve Özellikleri 2.Madde örneği. 
            Console.WriteLine("ContainsValue Örneği : " + varMi2);

            //Ogrenci.Clear(); // Methodlar ve Özellikleri 3. Madde örneği.

            int elemanSayisi = Ogrenci.Count; // Methodlar ve Özellikleri 4. Madde örneği.
            Console.WriteLine("Öğrenci Eleman Sayısı : " + elemanSayisi);

            bool silindiMi = Ogrenci.Remove(1071); // Methodlar ve Özellikleri 5. Madde Örneği.
            Console.WriteLine(silindiMi);

            Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys; // Methodlar ve Özellikleri 6. Madde Örneği.

            foreach (int Anahtar in AnahtarListesi)
            {
                Console.WriteLine("Anahtar : " + Anahtar);
            }

            Dictionary<int, string>.ValueCollection DegerList = Ogrenci.Values; //  Methodlar ve Özellikleri 7. Madde Örneği.
            foreach (string Deger in DegerList)
            {
                Console.WriteLine("Değer : " + Deger);
            }

            foreach (KeyValuePair<int, string> veri in Ogrenci) // Merhodlar ve Özellikleri 8. Madde Örneği.
            {
                Console.WriteLine("Numara : {0} - İsim : {1}", veri.Key, veri.Value);
            }

            string isim = " ";
            if (Ogrenci.TryGetValue(No, out isim))
            {
                Console.WriteLine(isim);
            }
            else
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }

            /* 1- Dictionary içinde belirleyeceğimiz bir keye uygun olarak değer saklar.
             * 2- Key türünü belirlememiz şarttır. (key türü: string, integer, float...)
             
             */

            Dictionary<string, int> AdYas = new Dictionary<string, int>();
            // Veri ekleyelim...
            AdYas.Add("Elif", 25);
            AdYas.Add("Ayşe", 24);
            AdYas.Add("Aslı", 23);
            AdYas.Add("Emre", 22);

            foreach (var degerOku in AdYas)
            {
                Console.WriteLine(degerOku);
            }
            // Değer sayma özelliği vardır...

            var eleman = AdYas.Count();
            Console.WriteLine();
            Console.WriteLine("Eleman Sayisi " + eleman);

            // Silme Özelliği vardır...

            AdYas.Remove("Emre");
            Console.WriteLine();
            foreach (var degeroku in AdYas)
            {
                Console.WriteLine(degeroku);
            }
            Console.ReadLine();
        }
    }
}
