using System;
using WFA_DesignPatterns.DATA;

namespace WFA_DesignPatterns.RepositoryPattern
{
    class Program
    {
        private static object console;

        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork();
            //var musteri = new Musteri() { Ad = "murat", Soyad = "vuranok", Bakiye = 1.000M };


            //unitOfWork.MusteriRepository.Insert(musteri);
            //unitOfWork.Save();

            var musteri = unitOfWork.MusteriRepository.FindSingle(1);
            unitOfWork.MusteriRepository.ParaEkle(musteri, 80.000M);
            unitOfWork.Save();


            Console.WriteLine($"Müşteri Adı : {musteri.Ad}\nMüşteri Soyadı : {musteri.Soyad}\nMüşteri Bakiye :{musteri.Bakiye}");
            Console.ReadKey();
        }
    }
}
