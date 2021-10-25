using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {

           var book = new Book("Ayush Grade Book");

           var done = false;

           while(!done){

               Console.WriteLine("Please Enter the input or 'q to quit ");
               var input = Console.ReadLine();

               if(input == "q")
                 break;

               try{

                   var grade = double.Parse(input);
                   book.AddGrade(grade);
               
               }catch(ArgumentException ex){

                   Console.WriteLine(ex.Message);

               }catch(FormatException ex){

                   Console.WriteLine(ex.Message);

               }finally{
                   Console.WriteLine("***");
               }
               

           }
           
          // var grade = double.Parse(input);

           var stats = book.GetStatistics();

           Console.WriteLine($"Average : {stats.Average:N2}");
           Console.WriteLine($"Max in List : {stats.High}");
           Console.WriteLine($"Min in List : {stats.Low}");     
           Console.WriteLine($"Student Grade: {stats.Letter}");      
            
        }
    }
}


