using System;

namespace Assignment1
{
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string role { get; set; }

        public Employee ()
        {
            
        }

        public Employee (int id, string name, string address, string email, string phone, string role)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }

        public override string ToString()
        {
            return $"\nID: {id} \nName: {name} \nAddress: {address} \nEmail: {email} \nPhone: {phone} \nRole: {role}";
        }

    }
}