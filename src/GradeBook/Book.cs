using System.Collections.Generic;

namespace GradeBook {

    class Book 
    {
        private List<double> grades;
        private string name;

        public Book(string name) 
        {
            this.name = name;
            grades = new List<double>();
        }        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

    }
}