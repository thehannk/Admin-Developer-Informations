using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin_Developer_Informations
{
    public class Calisan
    {
        private int id;
        private string isim;
        private string soyisim;

        public Calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;     
        }

        public int getID()
        {
            return this.id; 
        }
        public void setID(int id)   
        {
            this.id = id;
        }

        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim(string isim)
        {
            this.isim = isim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setSoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }

        public void bilgileriGoster()
        {
            Console.WriteLine("id :" + this.id);
            Console.WriteLine("isim :" + this.isim);
            Console.WriteLine("soyisim :" + this.soyisim);
        }



    }
}
