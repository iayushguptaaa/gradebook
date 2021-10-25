using System;
using Xunit;

 using System;
 using Xunit;
    
namespace GradeBook.Tests
{
   
        public class BookTests
        {
          [Fact]
          public void BookCalculatesAnAverageGrades()
          {
              //arranging the values
              var book = new Book("");
              book.AddGrade(89.31);
              book.AddGrade(23);
              book.AddGrade(55.55);

              // actual result
              var result = book.GetStatistics();
              

              //Assert section
              Assert.Equal(55.95,result.Average,2);
              // Assert.Equal(90.5,result.High);
              // Assert.Equal(20.5,result.Low);
          }
        }


    }
    
