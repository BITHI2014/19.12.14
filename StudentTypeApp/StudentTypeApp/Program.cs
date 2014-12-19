using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTypeApp
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Student [] students=new Student[3];
            Student student1=new Student();
            Student student2=new Student();
            Student student3=new Student();

            student1.regNo = "987";
            student1.firstName = "Hasan";
            student1.lastName = "Mukit";
            student2.regNo = "777";
            student2.firstName = "Orthi";
            student2.lastName = "Afroza";
            student3.regNo = "888";
            student3.firstName = "Atik";
            student3.lastName = "Ali";
            students[0] = student1;
            students[1] = student2;
            students[2] = student3;
            foreach (Student aStudent in students )
            {
                Console.WriteLine(aStudent.GetFullName()+" your regno is :"+aStudent.regNo);
            }
            Console.ReadKey();


        }
    }
}
