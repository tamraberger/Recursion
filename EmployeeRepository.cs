using System;
using System.Collections.Generic;
using System.Text;
using static EmployeeList.Employee;

namespace EmployeeList
{
    class EmployeeRepository
    {

    public EmployeeRepository()
        {
            Employee Wallace_David = new Employee();

                Wallace_David.employeeID = "a1";
                Wallace_David.firstName = "David";
                Wallace_David.lastName = "Wallace";
                Wallace_David.title = "CFO";
                Wallace_David.branch = "Dunder Mifflin Corporate Headquarters";



            Employee Levinson_Jan = new Employee();

                Levinson_Jan.employeeID = "a2";
                Levinson_Jan.firstName = "Jan";
                Levinson_Jan.lastName = "Levinson";
                Levinson_Jan.title = "VP of Northeastern Sales";
                Levinson_Jan.directSuperior = Wallace_David;
                Levinson_Jan.branch = "Dunder Mifflin Corporate Headquarters";
                Wallace_David.employeesManaged = new List<Employee>();
                Wallace_David.employeesManaged.Add(Levinson_Jan);

            Employee Raymond_Hunter = new Employee();

                Raymond_Hunter.employeeID = "a3";
                Raymond_Hunter.firstName = "Hunter";
                Raymond_Hunter.lastName = "Raymond";
                Raymond_Hunter.title = "Assistant to Jan Levinson";
                Raymond_Hunter.branch = "Dunder Mifflin Corporate Headquarters";
                Raymond_Hunter.directSuperior = Levinson_Jan;
                Levinson_Jan.employeesManaged = new List<Employee>();
                Levinson_Jan.employeesManaged.Add(Raymond_Hunter);
        

            Employee Scott_Michael = new Employee();

                Scott_Michael.employeeID = "b1";
                Scott_Michael.firstName = "Michael";
                Scott_Michael.lastName = "Scott";
                Scott_Michael.title = "Regional Manager";
                Scott_Michael.branch = "Scranton Branch";
                Scott_Michael.directSuperior = Levinson_Jan;
                
                Levinson_Jan.employeesManaged.Add(Scott_Michael);

            Employee Schrute_Dwight = new Employee();
            
                Schrute_Dwight.employeeID = "b2";
                Schrute_Dwight.firstName = "Dwight";
                Schrute_Dwight.lastName = "Schrute";
                Schrute_Dwight.title = "Assistant to the Regional Manager";
                Schrute_Dwight.branch = "Scranton Branch";
                Schrute_Dwight.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged = new System.Collections.Generic.List<Employee>();
                Scott_Michael.employeesManaged.Add(Schrute_Dwight);
            



            Employee Beesly_Pamela = new Employee();
            
                Beesly_Pamela.employeeID = "b3";
                Beesly_Pamela.firstName = "Pam";
                Beesly_Pamela.lastName = "Halpert";
                Beesly_Pamela.title = "Receptionist";
                Beesly_Pamela.branch = "Scranton Branch";
                Beesly_Pamela.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Beesly_Pamela);
            

            Employee Flenderson_Toby = new Employee();
            
                Flenderson_Toby.employeeID = "b4";
                Flenderson_Toby.firstName = "Toby";
                Flenderson_Toby.lastName = "Flenderson";
                Flenderson_Toby.title = "Human Resources";
                Flenderson_Toby.branch = "Scranton Branch";
                Flenderson_Toby.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Flenderson_Toby);
            

            Employee Halpert_Jim = new Employee();
            
                Halpert_Jim.employeeID = "b5";
                Halpert_Jim.firstName = "Jim";
                Halpert_Jim.lastName = "Halpert";
                Halpert_Jim.title = "Paper salesman";
                Halpert_Jim.branch = "Scranton Branch";
                Halpert_Jim.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Halpert_Jim);
            

            Employee Hudson_Stanley = new Employee();
            
                Hudson_Stanley.employeeID = "b6";
                Hudson_Stanley.firstName = "Stanley";
                Hudson_Stanley.lastName = "Hudson";
                Hudson_Stanley.title = "Paper Salesman";
                Hudson_Stanley.branch = "Scranton Branch";
                Hudson_Stanley.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Hudson_Stanley);
            

            Employee Martinez_Oscar = new Employee();
            
                Martinez_Oscar.employeeID = "b7";
                Martinez_Oscar.firstName = "Oscar";
                Martinez_Oscar.lastName = "Martinez";
                Martinez_Oscar.title = "Accountant";
                Martinez_Oscar.branch = "Scranton Branch";
                Martinez_Oscar.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Martinez_Oscar);
            

            Employee Martin_Angela = new Employee();
            
                Martin_Angela.employeeID = "b8";
                Martin_Angela.firstName = "Angela";
                Martin_Angela.lastName = "Martin";
                Martin_Angela.title = "Accountant";
                Martin_Angela.branch = "Scranton Branch";
                Martin_Angela.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Martin_Angela);
            

            Employee Malone_Kevin = new Employee();
            
                Malone_Kevin.employeeID = "b9";
                Malone_Kevin.firstName = "Kevin";
                Malone_Kevin.lastName = "Malone";
                Malone_Kevin.title = "Accountant";
                Malone_Kevin.branch = "Scranton Branch";
                Malone_Kevin.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Malone_Kevin);
            

            Employee Palmer_Meredith = new Employee();
            
                Palmer_Meredith.employeeID = "b10";
                Palmer_Meredith.firstName = "Meredith";
                Palmer_Meredith.lastName = "Palmer";
                Palmer_Meredith.title = "Quality Assurance Associate";
                Palmer_Meredith.branch = "Scranton Branch";
                Palmer_Meredith.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Palmer_Meredith);
            

            Employee Bratton_Creed = new Employee();
            
                Bratton_Creed.employeeID = "b11";
                Bratton_Creed.firstName = "Creed";
                Bratton_Creed.lastName = "Bratton";
                Bratton_Creed.title = "Quabity Ashwood";
                Bratton_Creed.branch = "Scranton Branch";
                Bratton_Creed.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Bratton_Creed);
            

            Employee Kapoor_Kelly = new Employee();
            
                Kapoor_Kelly.employeeID = "b12";
                Kapoor_Kelly.firstName = "Kelly";
                Kapoor_Kelly.lastName = "Kapoor";
                Kapoor_Kelly.title = "Customer Relations Specialist";
                Kapoor_Kelly.branch = "Scranton Branch";
                Kapoor_Kelly.directSuperior = Scott_Michael;
                Scott_Michael.employeesManaged.Add(Kapoor_Kelly);

            Console.WriteLine("You are viewing Dunder Mifflin's employee files." +
                " Which organization chart would you like to use?" +
                "?\nPress 1 for Corporate \nPress 2 for Scranton Branch");
            bool validReply = false;
            

            do
            {
                Console.Write("Selection:");
                var reply = Console.ReadLine();

                if (reply == "1")
                {
                    Wallace_David.GetOrgChart(Wallace_David);
                    validReply = true;
                }
                else if (reply == "2")
                {
                    Scott_Michael.GetOrgChart(Scott_Michael);
                    validReply = true;
                }
                else
                {
                    Console.WriteLine("Response was incorrectly submitted. Please try again.");
                    validReply = false;
                }

            } while (validReply==false);

            Console.ReadLine();
        }

    }
}
