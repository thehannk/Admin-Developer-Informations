using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Developer_Informations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışan uygulamasına hoşgeldiniz...");


            while (true)
            {
                Console.WriteLine("1- Yazılımcı işlemleri ");
                Console.WriteLine("2- Yönetici işlemleri ");
                Console.WriteLine("3- Çıkış için q'ya basın. ");

                string secilenİslem = Console.ReadLine();   

                if (secilenİslem == q)
                {
                    Console.WriteLine("Programdan çıkılıyor. ");
                    break;
                }
                else if (secilenİslem == "1")   
                {
                    Yazilimci yazilimci = new Yazilimci(1, "Hakan", "Ulusöver", "Java, C#, C++");    

                    while (true)
                    {

                        Console.WriteLine("Yazılımcı işlemi seçiniz :");
                        Console.WriteLine("1-Format At");
                        Console.WriteLine("2-Yazılımcının Bilgilerini Göster");
                        Console.WriteLine("3-Çıkış İçin q'ya Basınız.");
                        string yazilimciIslem = Console.ReadLine();

                        if (yazilimciIslem == "q")  
                        {
                            Console.WriteLine("Yazılımcı işlemlerinden çıkış yapılıyor.");
                            break;
                            
                        }
                        else if (yazilimciIslem == "1")
                        {
                            Console.Write("İşletim sistemi giriniz :");
                            string isletimSistemi = Console.ReadLine(); 
                            yazilimci.formatAt(isletimSistemi); 
                        }
                        else if (yazilimciIslem == "2")
                        {
                            yazilimci.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz!");
                        }
                    }
                }

                else if (secilenİslem == "2")
                {
                    Yonetici yonetici = new Yonetici(2, "Enes", "Bayram", 15);


                    while (true)
                    {
                        Console.WriteLine("Yönetici işlemi seçiniz :");
                        Console.WriteLine("1-Zam Yap");
                        Console.WriteLine("2-Yöneticinin Bilgilerini Göster");
                        Console.WriteLine("3-Çıkış İçin q'ya Basınız.");
                        string yoneticiIslem = Console.ReadLine();

                        if (yoneticiIslem == "q")
                        {
                            Console.WriteLine("Yönetici işlemlerinden çıkış yapılıyor.");
                            break;
                        }
                        else if (yoneticiIslem == "1")
                        {
                            Console.Write("Zamn miktarını giriniz :");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yonetici.zamYap(zamMiktari);    
                        }
                        else if (yoneticiIslem == "2")
                        {
                            yonetici.bilgileriGoster();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem giriniz.");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Lütfen çalışan uygulaması için geçerli bir işlem giriniz.");
                }
            }
        }
    }
}
