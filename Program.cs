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
        class Manager
        {
            public string Name { get; set; }
            public Project project;

            public Manager(string name, Project prj)
            {
                Name = name;
                project = prj;
            }
            public void ManagerEvaluation()
            {
                Console.WriteLine(this.project.ValueOfProject > 0 ? this.Name + " is successful" : this.Name + " is not successful");
                //if (this.project.ValueOfProject > 0)
                //{
                //    Console.WriteLine(this.Name + " is successful");
                //}
                //else
                //{
                //    Console.WriteLine(this.Name + " is not successful");
                //}
            }
        }
        class Project
        {
            public string Title { get; set; }
            public double ValueOfProject { get; set; }
            public Project(string title, double valueOfProject)
            {
                Title = title;
                ValueOfProject = valueOfProject;
            }
        }
        static void Main(string[] args)
        {
            Project p1 = new Project("JAVA_Project", 2.3D);  //value is 2.3, so Manager is successful
            Manager m1 = new Manager("Panos", p1);
            m1.ManagerEvaluation();
            Console.ReadKey();
        }
    }
}
