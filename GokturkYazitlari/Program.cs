using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GokturkYazitlari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** Geçmişe ve Geleceğe ışık tutan 552-744 yılları arasında Orta ve İç Asya'da hükümdarlık sürdürmüş bir Türk İmparatorluğu olan şanlı Göktürk Kağanlığının Orhun Yazıtlarına Hoş Geldiniz ********");

            Console.WriteLine("\n Lütfen aramak istediğiniz Orhun Yazıtının İsmini Giriniz");

            string girilen_Metin = Console.ReadLine();
            Urun[] urunler = new Urun[3];
            Urun u = new Urun();
            u.urunno = "1";
            u.isim = "Kül Tigin Yazıtı";
            u.yazar = "Yollug Tigin";
            u.basimYili = "552-744 yılları arasında";
            u.dil = "Orhun alfabesi";
            u.konum = " Moğolistan’da Orhun Vadisi'nde";

            Urun u1 = new Urun();
            u1.urunno = "2";
            u1.isim = "Bilge Kağan Yazıtı";
            u1.yazar = "Yollug Tigin";
            u1.basimYili = "552-744 yılları arasında";
            u1.dil = "Orhun alfabesi";
            u1.konum = " Moğolistan’da Orhun Vadisi'nde";

            Urun u2 = new Urun();
            u2.urunno = "3";
            u2.isim = "Tonyukuk Yazısı";
            u2.yazar = "Tonyukuk";
            u2.basimYili = "552-744 yılları arasında";
            u2.dil = "Orhun alfabesi";
            u2.konum = " Moğolistan’da Orhun Vadisi'nde";

           
            urunler[0] = u;
            urunler[1] = u1;
            urunler[2] = u2;

            if (girilen_Metin == "Kül Tigin Yazıtı")
            {
                Urun uu = urunler[0];
                Console.WriteLine("Ürün nu: " + uu.urunno + " " + " Yazıt İsmi: "+ uu.isim + " "+ " Yazar: "+ uu.yazar + " "+ " Basım Yılı: " + uu.basimYili + " " + "Kullanılan dil: " + uu.dil+ " " + "Yazıtın konumu: " + uu.konum);
            }
            else if (girilen_Metin == "Bilge Kağan Yazıtı")
            {
                Console.WriteLine("Ürün nu: " + urunler[1].urunno + " " + " Yazıt İsmi: " + urunler[1].isim + " " + " Yazar: " + urunler[1].yazar + " " + " Basım Yılı: " + urunler[1].basimYili + " " + "Kullanılan dil: " + urunler[1].dil + " " + "Yazıtın konumu: " + urunler[1].konum);
            }
            else if (girilen_Metin == "Tonyukuk Yazıtı")
            {
                Console.WriteLine("Ürün nu: " + urunler[2].urunno + " " + " Yazıt İsmi: " + urunler[2].isim + " " + " Yazar: " + urunler[2].yazar + " " + " Basım Yılı: " + urunler[2].basimYili + " " + "Kullanılan dil: " + urunler[2].dil + " " + "Yazıtın konumu: " + urunler[2].konum);
            }
            else 
            {
                Console.WriteLine("Lütfen tekrar deneyiniz!");
            }
        }
    }
    class Urun
    {
        public string urunno;
        public string isim;
        public string yazar;
        public string basimYili;//Türkçe Karakter Kullanmamalısın
        public string dil;
        public string konum;
    }
}
