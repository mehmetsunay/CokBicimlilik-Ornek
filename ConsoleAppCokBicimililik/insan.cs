using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCokBicimililik
{
    class insan
    {
        /*
         -Çok biçimlilikte(polym) amacım  kalıtım yaptığım sınıftan bazı değerleri alıp kullanmak(hepsini değil)
         -Bunu yaparkende override yani ezme işlemi gerçekleştiriyorum.
         -Örnekte görüldüğü gibi insan isimli bir sınıfım ve bu sınıfımın içinde tanımlı sanal bır metodum var
         Bu metodumun içerisinde de arka planı rengı değistırıyorum
          
         
         */

        public virtual void change()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Title = "Bu Bir Örnektir";
            Console.WriteLine("");
            Console.WriteLine("BU YAZI RENK DEĞİŞTİREREK OLUŞTURULMUŞTUR ...");

        }


    }
}
