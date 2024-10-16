﻿using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel() { Id = 1, FirstName = "Tim", LastName = "Corey" });
            people.Add(new PersonModel() { Id = 2, FirstName = "Ahmed", LastName = "Salem" });
            people.Add(new PersonModel() { Id = 3, FirstName = "Mohamed", LastName = "Ali" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel person = new() { FirstName = firstName, LastName = lastName };
            person.Id = people.Max(X => X.Id) + 1;
            people.Add(person);
            return person;
        }
    }
}
