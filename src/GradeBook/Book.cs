using System.Collections.Generic;

namespace GradeBook {

    class Book 
    {
        // constructor - doesn't seem to work?
        // public Book() 
        // {
        //     List<double> grades = new List<double>();
        // }        
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
// 
        List<double> grades = new List<double>();
    }
}