using Module2_Task4.Enums;
using System;

namespace Module2_Task4.Models.Mammals.Herbivory.Lagomorphs
{
    public abstract class Lagomorphs : Herbivory
    {
        protected Lagomorphs(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override OrderNames OrderName => OrderNames.Lagomorphs;

        public override HousingTypes HousingTypes => HousingTypes.Enclosure;

        public override HerbivoryFoodTypes[] FoodType => new HerbivoryFoodTypes[] { HerbivoryFoodTypes.Hay, HerbivoryFoodTypes.Vegetables };
    }
}
