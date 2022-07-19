﻿using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public  string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public long Mobile { get; set; }
        public string ProfileImageUrl { get; set; }
        //navigation property
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }

        public Address Address { get; set; }







    }
}
