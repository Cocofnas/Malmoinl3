using System;

namespace Malmoinl3
{
    // Enums for Gender and ActivityLevel should be outside the Person class
    public enum Gender
    {
        Male,
        Female
    }

    public enum ActivityLevel
    {
        Low,
        Medium,
        High
    }

    // Person class to hold user information
    internal class Person
    {
        public double Weight { get; set; } // Weight in kg or lbs (depending on the unit system)
        public double Height { get; set; } // Height in cm or inches (depending on the unit system)
        public Gender Gender { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
    }
}


