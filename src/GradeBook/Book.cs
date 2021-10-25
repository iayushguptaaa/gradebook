namespace GradeBook {
    using System;
    using System.Collections.Generic;
    public class Book{

        private List<double> grades;
        public string Name;

        public Book(string name){

            grades = new List<double>();

            Name = name;
        }

        public void AddLetterGrade(char letter){

          switch(letter){

             case 'A':
                  AddGrade(90);
                  break;

             case 'B':
                  AddGrade(80);
                  break;

             case 'C':
                  AddGrade(70);
                  break;

             case 'D':
                  AddGrade(60);
                  break;
             case 'E':
                  AddGrade(50);
                  break;     

             default:
                AddGrade(40);
                break;     

          }
        }
         public void AddGrade(double grade){
            
            if(grade <= 100 && grade >= 0)
              grades.Add(grade);

            else{

              throw new ArgumentException($"Invalid {nameof(grade)}"); // this exception will be used over argument and throws an exception is invalid

            }  
        }

        public Statistics GetStatistics()
        {

          var result = new Statistics();

          result.Average = 0.0;
          result.High = double.MinValue;
          result.Low = double.MaxValue;

           
           foreach (var item in grades)
           {
              Console.WriteLine($"List Item:{item}");
              result.Average += item;
              result.High = Math.Max(item,result.High);
              result.Low = Math.Min(item,result.Low);
            
           }

           result.Average /= grades.Count;

           switch(result.Average){

             case var d when d >= 90.0:
               result.Letter = 'A';
               break;

             case var d when d >= 80.0:
               result.Letter = 'B';
               break;

             case var d when d >= 70.0:
               result.Letter = 'C';
               break;

             case var d when d >= 60.0:
               result.Letter = 'D';
               break;

             case var d when d >= 50.0:
               result.Letter = 'E';
               break;

             default :
               result.Letter = 'F';
               break;           
           }
          
           return result;
        
        }
    }
}