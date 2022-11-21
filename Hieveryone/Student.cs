using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hieveryone
{
    internal class Student
    {

        public string Name;
        public string Surname;
        public byte Group;
        public byte Point;
        public bool IsGreated;


     
        public Student(string name, string surname,byte group,byte point,bool isgreated)
        {
            Name=name;
            Surname=surname;
            Group=group;
            Point=point;
            IsGreated=isgreated;
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            Console.WriteLine(Group);
            Console.WriteLine(Point);

            Greated();
            StudentPoint();

            Console.WriteLine("-----------------------");
               

        }

        public string StudentAd()
        {
            Name + ' ' + Surname;
            
        }


        public void Greated()
        {
            if (IsGreated)
            {
                Console.WriteLine("Artiq mezun olub");
            }
            else
            {
                Console.WriteLine("Hal hazirda Tehsil alir");   
            }
        }


        public void StudentPoint()
        {
            if (Point>80)
            {
                Console.WriteLine("Siz novbeti merheleye ugurla kecdiniz");
            }
            else
            {
                Console.WriteLine("Teesufler olsunki siz merheleni kece bilmediniz");
               
               
            }
        }

       
    }
}

