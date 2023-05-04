using System;

namespace Assignment1
{
    class Payroll
    {
        public string id { get; set; }
        public int employeeID { get; set; }
        public double hoursWorked { get; set; }
        public double hourlyRate { get; set; }
        public DateTime date { get; set; }

        public Payroll()
        {

        }

        public Payroll(string id, int employeeID, double hoursWorked, double hourlyRate, DateTime date)
        {
            this.id = id;
            this.employeeID = employeeID;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
            this.date = date;
        }

        public override string ToString()
        {
            return $"\nID: {id} \nEmployee ID: {employeeID} \nHours Worked: {hoursWorked} \nHourly Rate: {hourlyRate} \nDate: {date}";
        }

    }
}