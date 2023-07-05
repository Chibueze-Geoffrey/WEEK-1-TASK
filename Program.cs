using System;
using System.Collections.Generic;
using System.Data;
class getTable
{
    new getTable gt = new getTable();
}
class Program
  {
    static void Main(string[] args)
      {

        PrintTable table = new PrintTable();
         DataTable dt1 = new DataTable();
        table.getTable();

      }
  }


      public class studentnewDetails 
          {
             public List<string>courseName = new List<string>{}; 
             public List<int>courseUnit = new List<int>{};
             public List<int>courseScore = new List<int>{};
          }
             public class PrintTable

               {
                public void getTable()
                
                  {
                    decimal gpa = 0;
                    decimal totalweightpoint = 0;
                    decimal totalcourseunitpassed = 0;
                    string name;
                    string Columns;
                    string getTable;
                    string Course;
                    int Unit;
                    int Score;
                    string Calculate;
                    studentnewDetails details =new studentnewDetails();
                    DataTable dt1 = new DataTable();
                    
                   
                    
                        do
                     { 
                       
                       Console.Write("Course code:" );
                       Course = Console.ReadLine();
                       details.courseName.Add(Course);
                       Console.Write("Course unit:" );
                       Unit =int.Parse(Console.ReadLine());
                       details.courseUnit.Add(Unit);
                       Console.Write("Course score:" );
                       Score =int.Parse(Console.ReadLine());
                       details.courseUnit.Add(Score);  
                       Console.WriteLine("Calcuate? y/n");
                       Calculate = Console.ReadLine();

                     }
                         while ( Calculate != "y");
                  }
                         public class DataTable
                    {

                    }
               }