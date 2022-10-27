using System;
using System.Collections.Generic;
using System.Text;

namespace pr_oop
{
    public class TeachMeSkills
    {
        public int AmountOfStudents;

        public TeachMeSkills(int amountOfStudents)
        {
            AmountOfStudents = amountOfStudents;
        }

        public void Start()
        {
            Console.WriteLine($"hp { AmountOfStudents}");
        }
        public void AddNewStudents()
        {
            AmountOfStudents += 1;
        }

       
    }   
}

        
              
        
    

