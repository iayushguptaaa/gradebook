namespace GradeBook{

    using System;

    public class check{

        public check(){

            Ans = new int();
        }

      public Datatypes CheckDataTypes(){


          Datatypes datatypes = new Datatypes();

          Console.WriteLine((Datatypes.product)Datatypes.product.milk);
          
          return datatypes;
      }        

      private int ans;

      public int Ans{
          get;
          set;
        }

    }
}