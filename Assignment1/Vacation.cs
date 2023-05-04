using System;

namespace Assignment1
{
    class Vacation
    {
        public string id { get; set; }
        public int employeeID { get; set; }
        public int numberOfDays { get; set; }

        public Vacation()
        {

        }

        public Vacation(string id, int employeeID, int numberOfDays)
        {
            this.id = id;
            this.employeeID = employeeID; 
            this.numberOfDays = numberOfDays;
        }

        public override string ToString()
        {
            return $"\nID: {id} \nEmployee ID: {employeeID} \n:Number of Days: {numberOfDays}";
        }

    }
}