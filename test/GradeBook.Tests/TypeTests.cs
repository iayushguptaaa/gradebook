using System;
using Xunit;

 using System;
 using Xunit;
    
namespace GradeBook.Tests
{
   
        public class TypeTests
        {
          [Fact]
          public void GetBookReturnsDifferentObjects()
          {
              //arranging the values
              
              var book1 = GetBook("Book 1");
              var book2 = GetBook("Book 2");
              // actual result
                     

              //Assert section

              Assert.Equal("Book 1",book1.Name);
              Assert.Equal("Book 2",book2.Name);

              Assert.NotSame(book1,book2);
          }

          [Fact]
          public void TwoVarHavingSameReferrence(){

            var book1 = GetBook("book 1");
            var book2 = book1;//book 2 storing a referrence stored in book1

            Assert.Same(book1,book2);
            Assert.False(Object.ReferenceEquals(book1,book2));
          }

          [Fact]
          public void CanSetName(){

            var book1 = GetBook("book 1");
            SetName(book1,"New Name"); //passing an obj and value in setname method

            Assert.Equal("New Name",book1.Name);
        
          }


          [Fact]
          public void MyPassByValue(){

            var book1 = GetBook("book 1");
            GetbookSetName(book1,"New Name"); //passing an obj and value in setname method

            Assert.Equal("New Name",book1.Name);//checks whether the code book1 will be updated to "New Name" or remain unchanged
        
          }

          [Fact]
          public void MyPassByRef(){

            var book1 = GetBook("book 1");
            GetbookSetNameByRef(ref book1,"New Name"); //by passing through referrence using keyword "ref" 

            Assert.Equal("New Name",book1.Name);//checks whether the code book1 will be updated to "New Name" or remain unchanged
        
          }

          [Fact]
          public void StringBehaveLikeValueTypes(){

            String name = "Ayush"; //String is created and initialized
            var upper  = MakeUpperCase(name); //method is called by passing the string name

            Assert.Equal("AYUSH",upper);//checking whether the following is equal or not
          }

        private string MakeUpperCase(string parameter) // parameter of type string is storing the value of name
        {
            //using parameter.ToUpper() using inbuilt method changes to uppercase but it changes the value of parameter not name

            return parameter.ToUpper(); //therefore the changes made in this method reflects in the parameter and by returning
                                        // the string behaves like call by value sometimes
        }

        private void GetbookSetNameByRef(ref Book book, string name)//using ref we tell the compiler that the value is passed by ref
                                                                    //therefore on creating new obj it makes the changes at the address value
        {
           book = new Book(name); //book will store a value through a new Book obj 
        }

        private void GetbookSetName(Book book, string name)//book will get a copy of book1 
        {
           book = new Book(name); //book will store a value through a new Book obj 
        }

        private void SetName(Book book, string name)
        {
          book.Name = name;

        }

        Book GetBook(string name)
        {

          return new Book(name);
            
        }
    }


    }
    
