using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yty.Shared.Repository.Master.Domain.Entities
{
    public class Aggregate
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }


    //Sample 
    public class Address
    {
        public string addresslane, city, state;
        public Address(string addresslane, string city, string state)
        {
            this.addresslane = addresslane;
            this.city = city;
            this.state = state;
        }
    }
    public class Student
    {
        public string name;
        int id;

        Address address;
        public Student(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
}
