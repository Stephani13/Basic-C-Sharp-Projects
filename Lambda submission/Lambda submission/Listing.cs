using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda_submission
{
    class Listing
    {
        public Listing()
        {

            //Creates a list of employees
            Employees = new List<Employee>();
            List<string> FirstName = new List<string>() { "Joe", "Lewis", "Mia", "Santiago", "Miguel", "Daniel", "Zoey", "Carla", "Joe", "Tatiana" };
            List<string> LastName = new List<string>() { " Smith", " Logan", " Fillips", " Perez", " Hernandez", " Rodriguez", " Stirling", " Whitemore", " Clove", " Mendez" };
            List<int> Id = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < FirstName.Count; i++)
            {
                Employee employee = new Employee();
                employee.FirstName = FirstName[i];
                employee.LastName = LastName[i];
                employee.Id = Id[i];
                Employees.Add(employee);
            }
            
            
        }
        public List<Employee> Employees { get; set; }
    }
}
