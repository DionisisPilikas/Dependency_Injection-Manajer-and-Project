using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
This project is about Dependency Injection between two classes which are connected by aggregation.
In the first commit the(class) Manager has a(class) Project as a Property.
Manager success depends upon its project value.(if the project value is greater than a zero Manager is successful).
In the second commit, making Dependency Injection, we don't need aggregation between classes.
*/

namespace Dependency_Injection
{
    class Program
    {
        interface IEvaluation 
        {
            //Evaluation Method (void)
            void ManagerEvaluation();
            //Get value Method (return the value typed double)
            double GetProjectValue();
        }
        class Manager : IEvaluation
        {
            public string Name { get; set; }
            public IEvaluation _ievaluation;

            //Constructor - Dependency_Injection (interface IEvaluation)
            public Manager(string name, IEvaluation ievaluation)
            {
                Name = name;
                this._ievaluation = ievaluation;
            }
            //Evaluation Method (void)
            public void ManagerEvaluation()
            {
                if (this._ievaluation.GetProjectValue() > 0)
                {
                    Console.WriteLine(this.Name + " is successful");
                }
                else
                {
                    Console.WriteLine(this.Name + " is not successful");
                }
            }
            //Get value Method (return the value typed double)
            public double GetProjectValue()
            {
                return this._ievaluation.GetProjectValue();
            }
        }
        class Project :IEvaluation
        {
            public string Title { get; set; }
            public double ValueOfProject { get; set; }
            public Project(string title, double valueOfProject)
            {
                Title = title;
                ValueOfProject = valueOfProject;
            }
            public void ManagerEvaluation()
            {
                throw new NotImplementedException();
            }
            //Get value Method (return the value typed double)
            public double GetProjectValue()
            {
                return this.ValueOfProject;
            }
        }
        static void Main(string[] args)
        {
            IEvaluation p1 = new Project("JAVA_Project", 2.3D); //value is 2.3, so Manager is successful
            Manager m1 = new Manager("Manos", p1);
            m1.ManagerEvaluation();
            Console.ReadKey();
        }
    }
}
