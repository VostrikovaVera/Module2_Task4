using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory
{
    public abstract class Herbivory : Mammal
    {
        protected Herbivory(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public abstract HerbivoryFoodTypes[] FoodType { get; }
    }
}
