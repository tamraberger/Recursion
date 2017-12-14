using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeList
{
    class Employee
    {
        public string employeeID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string title { get; set; }
        public List<Employee> employeesManaged { get; set; } //if a person manages anyone else, they go here
        public Employee directSuperior { get; set; } //particular employee's direct superior
        public string branch { get; set; }
        

        public void GetOrgChart(Employee a)
        {
            Console.WriteLine($"{a.firstName} {a.lastName}:\n{a.title}, working from {a.branch}\n");

            foreach (var personEmployed in a.employeesManaged)
            {
               
                if (personEmployed.employeesManaged == null)
                {
                    Console.WriteLine($"{personEmployed.firstName} {personEmployed.lastName}:\n{personEmployed.title}, working from {personEmployed.branch}\n");
                  
                }

                else if (personEmployed.employeesManaged!=null)
                {
                    
                    GetOrgChart(personEmployed);
                    
                }
            }
            
        }
        }
    }

           
            
       
    
    





