using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCokBicimililik
{
    /*         
     -Oluşturduğum bu sınıfa insan sınıfından kalıtım yapıyorum 
     -Bu kalıtım sayesınde insan sınıfında oluşturduğum metodda geliyor 
      ama ben ne demiştim ?? Bütün özelliklerin hepsini yada aynısı kullanmak istemeyebilirim 
     zaten polym. ozellıgınin amacı da bu.
      - o yüzden override yani ezme işlemi yapıyorum 
     eğer gelen metoddaki bazı özellikleri istiyorsan burada da deklare etmelıyım
    
     */

    class EnglishPeople : insan
    {
        public override void change()
        {
            Console.Title = "Bu Bir Örnektir";
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("HELLO MR AND MSS ......");
        }

    }
}
