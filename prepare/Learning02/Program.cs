using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
            {
                Job job1 = new Job();
                job1._jobTitle ="Software Egineer";
                job1._company = "Microsoft";
                job1._startYear =2003;
                job1._endYear = 2023;
               // job1.DisplayJob();

                


                Job job2 = new Job();
                job2._jobTitle ="Developer";
                job2._company = "Apple";
                job2._startYear = 2015;
                job2._endYear = 2053;
                //job2.Display();



                Resume realResume = new Resume();
                realResume._name ="Iga Brigham";
                realResume._jobs.Add(job1);
                realResume._jobs.Add(job2);

                
                realResume.Display();


                












            }
        

       
        
    }
    
}