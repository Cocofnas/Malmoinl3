using System;

namespace Malmoinl3
{
    // WaterIntakeCalculator class to calculate water intake based on a Person object
    internal class WaterIntakeCalculator
    {
        private Person person;

        // Constructor that accepts a Person object
        public WaterIntakeCalculator(Person person)
        {
            this.person = person;
        }

        // Method to calculate water intake
        public double CalculateWaterIntake()
        {
            // Base intake (33 ml per kg of body weight)
            double baseIntake = person.Weight * 33;

            // Adjust based on gender
            if (person.Gender == Gender.Male)
                baseIntake *= 1.1; // Increase by 10% for males
            else if (person.Gender == Gender.Female)
                baseIntake *= 0.9; // Decrease by 10% for females

            // Adjust based on height
            if (person.Height > 175)
                baseIntake *= 1.05; // Increase by 5% if taller than 175 cm
            else if (person.Height < 160)
                baseIntake *= 0.95; // Decrease by 5% if shorter than 160 cm

            // Adjust based on activity level
            switch (person.ActivityLevel)
            {
                case ActivityLevel.Medium:
                    baseIntake *= 1.2; // Increase by 20% for medium activity
                    break;
                case ActivityLevel.High:
                    baseIntake *= 1.5; // Increase by 50% for high activity
                    break;
            }

            return baseIntake; // Return the water intake in milliliters
        }

        // Method to calculate the number of glasses based on water intake
        public int CalculateGlasses(double waterIntake)
        {
            return (int)(waterIntake / 240); // 1 glass = 240 ml
        }
    }
}
