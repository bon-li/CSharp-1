using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Assignment1
{
    class Program
    {

        static void Main(string[]args)
        {
            int choice = 1;
            bool choiceValid = true;

            Guid uniqueId = Guid.NewGuid();
            Employee employee = new Employee();
            List<Employee> employees = new List<Employee>();
            List<Payroll> payroll = new List<Payroll>();
            List<Vacation> vacation = new List<Vacation>();

            //Premade entries
            employees.Add(new Employee { id = 1, name = "Jane Doe", address = "123 Street rd.", email = "jdoe@email.com", phone = "(123)456-7890", role = "Customer Service"});
            employees.Add(new Employee { id = 2, name = "Zula Gill", address = "3454 Yonge st.", email = "zGill@email.com", phone = "(111)222-3333", role = "Marketing Rep"});
            employees.Add(new Employee { id = 3, name = "Gwyneth Brandee", address = "75 Erin st.", email = "gBrandee@email.com", phone = "(432)987-4570", role = "Sales Rep"});
            employees.Add(new Employee { id = 4, name = "Fabian Kristie", address = "456 Road st.", email = "fKristie@email.com", phone = "(355)987-2349", role = "Customer Service"});
            employees.Add(new Employee { id = 5, name = "Geoff Hudson", address = "675 Bay st.", email = "gHudson@email.com", phone = "(463)873-2948", role = "Marketing Manager"});
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = 1, numberOfDays = 14 });
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = 2, numberOfDays = 14 });
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = 3, numberOfDays = 14 });
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = 4, numberOfDays = 14 });
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = 5, numberOfDays = 14 });

            Console.WriteLine("Welcome, please choose a command");

            //First main menu
            do 
            {
                Console.WriteLine("Press 1 to modify employees");
                Console.WriteLine("Press 2 to add payroll");
                Console.WriteLine("Press 3 to view vacation days");
                Console.WriteLine("Press 4 to exit program");

                //Checks for valid input choice
                choiceValid = int.TryParse(Console.ReadLine(), out choice);
                if(choiceValid == true) 
                {

                    if (choice < 0 || choice > 4)
                    {
                        Console.WriteLine("Invalid choice.");
                        choiceValid = false;
                    } 
                    else
                    {
                        choiceValid = true;
                    }
                } 
                else 
                {
                    Console.WriteLine("Please input an integer.");
                    choiceValid = false;
                }

                switch(choice)
                {
                    //Employee menu
                    case 1:
                        do
                        {
                            Console.WriteLine("\nEmployees menu");
                            Console.WriteLine("Press 1 to list all employees");
                            Console.WriteLine("Press 2 to add a new employee");
                            Console.WriteLine("Press 3 to update employee");
                            Console.WriteLine("Press 4 to delete employee");
                            Console.WriteLine("Press 5 to return to main menu");
                            choiceValid = int.TryParse(Console.ReadLine(), out choice);
                            if(choiceValid == true) 
                            {
                                if (choice < 0 || choice > 5)
                                {
                                    Console.WriteLine("Invalid choice.");
                                    choiceValid = false;
                                } 
                                else if (choice == 1)
                                {
                                    ListEmployees(employees);
                                    choiceValid = false;
                                }
                                else if (choice == 2)
                                {
                                    AddEmployee(employees, vacation, uniqueId);
                                    choiceValid = false;
                                }
                                else if (choice == 3)
                                {
                                    UpdateEmployee(employees);
                                    choiceValid = false;
                                }
                                else if (choice == 4 )
                                {
                                    DeleteEmployee(employees, payroll, vacation);
                                    choiceValid = false;
                                }
                                else if (choice == 5)
                                {
                                    break;
                                }
                            } 
                            else
                            {
                                Console.WriteLine("Please input an integer.");
                                choiceValid = false;
                            }
                        }while (choice != 5 && choiceValid == false);
                        
                        break;

                    //Payroll menu
                    case 2:
                        do
                        {
                            Console.WriteLine("\nPayroll menu");
                            Console.WriteLine("Press 1 to insert new payroll entry");
                            Console.WriteLine("Press 2 to view payroll history for an employee");
                            Console.WriteLine("Press 3 to return to main menu");
                            choiceValid = int.TryParse(Console.ReadLine(), out choice);
                            if(choiceValid == true) 
                            {
                                if (choice < 0 || choice > 3)
                                {
                                    Console.WriteLine("Invalid choice.");
                                    choiceValid = false;
                                } 
                                else if (choice == 1)
                                {
                                    InsertPayroll(payroll, employees, uniqueId);
                                    choiceValid = false;
                                }
                                else if (choice == 2)
                                {
                                    viewPayRoll(payroll);
                                    choiceValid = false;
                                }
                                else if (choice == 3)
                                {
                                    break;
                                }
                            } 
                            else 
                            {
                                Console.WriteLine("Please input an integer.");
                                choiceValid = false;
                            }
                        }while(choice != 3 && choiceValid == false);
                        
                        break;
                    
                    //Vacation days menu
                    case 3:
                        do
                        {
                            Console.WriteLine("\nVacation days menu");
                            Console.WriteLine("Press 1 to view vacation days");
                            Console.WriteLine("Press 2 to modify vacation days of an employee");
                            Console.WriteLine("Press 3 to return to the main menu");
                            choiceValid = int.TryParse(Console.ReadLine(), out choice);
                            if(choiceValid == true) 
                            {
                                if (choice < 0 || choice > 3)
                                {
                                    Console.WriteLine("Invalid choice.");
                                    choiceValid = false;
                                } 
                                else if (choice == 1)
                                {
                                    ViewVacation(vacation);
                                    choiceValid = false;
                                }
                                else if (choice == 2)
                                {
                                    ModifyVacation(vacation, employees);
                                    choiceValid = false;
                                }
                                else if (choice == 3)
                                {
                                    break;
                                } 
                            } 
                            else 
                            {
                                Console.WriteLine("Please input an integer.");
                                choiceValid = false;
                            }
                        }while(choice != 3 && choiceValid == false);
                        break;
                    case 4:
                        Console.WriteLine("Exiting program.");
                        break;

                    default:
                        break;
                }
                choiceValid = false;
            }while(choice != 4 && choiceValid == false);
          
        }

        //Lists all employees
        public static void ListEmployees(List<Employee> employees)
        {
            //Checks for no employees
            if (employees.Count == 0 )
            {
                Console.WriteLine("List of Employees is empty.");
            } 
            else
            {
                //Lists all available employees
                var allEmp = from emp in employees select emp;
                foreach (var emp in allEmp)
                    Console.WriteLine(emp);
            }
        }

        //Adds new employees
        public static (List<Employee>, List<Vacation>) AddEmployee(List<Employee> employees, List<Vacation> vacation, Guid uniqueId)
        {
            int empId;
            string empName;
            string empAddress;
            string empEmail;
            string empPhone;
            string empRole;
            bool valid;
            Employee employee = new Employee();
            
            //Checks for valid employee id
            do
            {
                Console.WriteLine("Employee ID:");
                valid = int.TryParse(Console.ReadLine(), out empId);
                if (valid == false)
                {
                    Console.WriteLine("Invalid Employee ID.");
                }

            } while (valid == false);

            Console.WriteLine("Employee Name:");
            empName = Console.ReadLine();

            Console.WriteLine("Employee Address:");
            empAddress = Console.ReadLine();

            Console.WriteLine("Employee Email:");
            empEmail = Console.ReadLine();

            Console.WriteLine("Employee Phone:");
            empPhone = Console.ReadLine();

            Console.WriteLine("Employee Role:");
            empRole = Console.ReadLine();
            
            //Creates new employee
            employee = new Employee(empId, empName, empAddress, empEmail, empPhone, empRole);
            employees.Add(employee);
            //Adds vacation days to new employee
            vacation.Add(new Vacation { id = uniqueId.ToString(), employeeID = employee.id, numberOfDays = 14});
            return (employees, vacation);
        }

        //Update employee information
        public static List<Employee> UpdateEmployee(List<Employee> employees)
        {
            int empId;
            bool validId = true;
            string empName;
            string empAddress;
            string empEmail;
            string empPhone;
            string empRole;
            Employee employee = new Employee();

            //Asks for employee id
            do
            {
                Console.WriteLine("Enter Employee ID to update Employee:");
                validId = int.TryParse(Console.ReadLine(), out empId);
                if (validId == false)
                {
                    Console.WriteLine("Invalid Employee ID.");
                }

            } while (validId == false);

            Console.WriteLine("Enter new employee Name:");
            empName = Console.ReadLine();

            Console.WriteLine("Enter new  employee Address:");
            empAddress = Console.ReadLine();

            Console.WriteLine("Enter new employee Email:");
            empEmail = Console.ReadLine();

            Console.WriteLine("Enter new employee Phone:");
            empPhone = Console.ReadLine();

            Console.WriteLine("Enter new employee Role:");
            empRole = Console.ReadLine();

            //Checks for employee id
            var updateEmp = from emp in employees where (emp.id).Equals(empId) select emp;
            if (!updateEmp.Any())
            {
                Console.WriteLine("Invalid Employee ID.");
            }
            else
            {
                //Updates employee information
                employees.Where(e => e.id == empId).ToList().ForEach(e =>
                {
                    e.name = empName;
                    e.address = empAddress;
                    e.email = empEmail;
                    e.phone = empPhone;
                    e.role = empRole;
                });

                return employees;
            }

            return employees;
        }

        //Deletes employee
        public static List<Employee> DeleteEmployee(List<Employee> employees, List<Payroll> payroll, List<Vacation> vacation)
        {
            int empId;
            bool validId = true;

            //Asks for employee id
            do 
            { 
                Console.WriteLine("Enter Employee ID to delete Employee:");
                validId = int.TryParse(Console.ReadLine(), out empId);
                if (validId == false)
                {
                    Console.WriteLine("Invalid Employee ID.");
                }

            } while (validId == false);

            //Searches for employee id
            var delEmp = from emp in employees where (emp.id).Equals(empId) select emp;

            if (!delEmp.Any())
            {
                Console.WriteLine("Employee ID does not exist.");
            }
            else
            {
                //Removes employee entries 
                employees.RemoveAll((e) => (e.id).Equals(empId));
                payroll.RemoveAll((e) => (e.id).Equals(empId));
                vacation.RemoveAll((e) => (e.id).Equals(empId));
                return employees;
            }

            return employees;
        }

        //Inserts new payroll
        public static List<Payroll> InsertPayroll(List<Payroll> payroll, List<Employee> employees, Guid uniqueId)
        {
            int empId;
            double hours;
            double rate;
            bool valid = true;
            DateTime today = DateTime.Today;

            //Asks for employee id
            do
            {
                Console.WriteLine("Enter Employee ID to insert payroll:");
                valid = int.TryParse(Console.ReadLine(), out empId);

                if (valid == false)
                {
                    Console.WriteLine("Invalid Employee ID.");
                }

            } while (valid == false);

            //Input employee hours worked
            do
            {
                Console.WriteLine("Enter hours worked:");
                valid = double.TryParse(Console.ReadLine(), out hours);

                if (valid == false)
                {
                    Console.WriteLine("Invalid number.");
                }

            } while (valid == false);

            //Input employee hourly rate
            do
            {
                Console.WriteLine("Enter hours rate:");
                valid = double.TryParse(Console.ReadLine(), out rate);

                if (valid == false)
                {
                    Console.WriteLine("Invalid number.");
                }

            } while (valid == false);

            //Checks if employee id valid
            var viewEmp = from emp in employees where (emp.id).Equals(empId) select emp;
            if (!viewEmp.Any())
            {
                Console.WriteLine("Invalid Employee ID.");
            } 
            else
            {
                //Adds new payroll
                payroll.Add(new Payroll { id = uniqueId.ToString(), employeeID = empId, hoursWorked = hours, hourlyRate = rate, date = today });
                return payroll;
            }

            return payroll;
        }

        //View payrolls for employee
        public static void viewPayRoll(List<Payroll> payroll)
        {
            int empId;
            bool validId = true;

            //Asks for employee id
            do
            {
                Console.WriteLine("Enter Employee ID to view payroll history:");
                validId = int.TryParse(Console.ReadLine(), out empId);

                if(validId == false)
                {
                    Console.WriteLine("Invalid number.");
                }


            } while(validId == false);

            //Checks for employee id
            var viewPR = from pr in payroll where (pr.employeeID).Equals(empId) select pr;
            if (!viewPR.Any())
            {
                Console.WriteLine("Invalid Employee ID.");
            }
            else
            {
                //Lists all payroll for employee
                foreach (var pr in viewPR)
                {
                    Console.WriteLine(pr);
                }
            }

        }

        //Shows vacations for employee
        public static void ViewVacation(List<Vacation> vacation)
        {
            int empId;
            bool validId = true;

            //Asks for employee id
            do
            {
                Console.WriteLine("Enter Employee ID to view vacation days:");
                validId = int.TryParse(Console.ReadLine(), out empId);

                if(validId == false)
                {
                    Console.WriteLine("Employee ID does not exist.");
                }

            }while(validId == false);

            //Checks for employee id
            var viewVac = from vac in vacation where (vac.employeeID).Equals(empId) select vac;
            if (!viewVac.Any())
            {
                Console.WriteLine("Invalid Employee ID.");
            } else
            {
                //Lists vacation days for employee
                foreach (var vac in viewVac)
                {
                    Console.WriteLine(vac);
                }
            }

        }

        //Modify vacation days for employee
        public static List<Vacation> ModifyVacation(List<Vacation> vacation, List<Employee> employees)
        {
            int empId;
            int days;
            bool valid = true;

            //Asks for employee id
            do
            {
                Console.WriteLine("Enter Employee ID:");
                valid = int.TryParse(Console.ReadLine(), out empId);

                if (valid == false)
                {
                    Console.WriteLine("Employee ID does not exist.");
                }

            } while (valid == false);

            //Input vacation days
            do
            {
                Console.WriteLine("Enter days:");
                valid = int.TryParse(Console.ReadLine(), out days);

                if (valid == false)
                {
                    Console.WriteLine("Invalid number.");
                }

            } while (valid == false);

            //Checks for employee id
            var viewEmp = from emp in employees where (emp.id).Equals(empId) select emp;
            if (!viewEmp.Any())
            {
                Console.WriteLine("Invalid Employee ID.");
            }
            else
            {
                //Changes vacation days
                vacation.Where(v => v.employeeID == empId).ToList().ForEach(v =>
                {
                    v.numberOfDays = days;
                });
                return vacation;
            }

            return vacation;
        }

    }
}