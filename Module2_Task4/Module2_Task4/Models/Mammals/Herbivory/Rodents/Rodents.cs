using Module2_Task4.Enums;
using System;

namespace Module2_Task4.Models.Mammals.Herbivory.Rodents
{
    public abstract class Rodents : Herbivory
    {
        protected Rodents(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override OrderNames OrderName => OrderNames.Rodents;

        public override HousingTypes HousingTypes => HousingTypes.Enclosure;

        public override HerbivoryFoodTypes[] FoodType => new HerbivoryFoodTypes[] { HerbivoryFoodTypes.Hay, HerbivoryFoodTypes.Grain };
    }
}
