using Module2_Task4.Enums;
using System;

namespace Module2_Task4.Models.Mammals.Herbivory.EvenToedUngulates
{
    public abstract class EvenToedUngulates : Herbivory
    {
        protected EvenToedUngulates(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override OrderNames OrderName => OrderNames.EvenToedUngulates;

        public override HousingTypes HousingTypes => HousingTypes.FreeRange;

        public override HerbivoryFoodTypes[] FoodType => new HerbivoryFoodTypes[] { HerbivoryFoodTypes.Hay, HerbivoryFoodTypes.Grain, HerbivoryFoodTypes.Vegetables };
    }
}
