using System.Collections.Generic;

namespace GradeBook  
{
    class Book
    {
        public Book(string name)
        {
            listAgrade = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade > 0)
            {                
                listAgrade.Add(grade);
            }
        }
        private  List<double> listAgrade;
        private string name;

    }

}