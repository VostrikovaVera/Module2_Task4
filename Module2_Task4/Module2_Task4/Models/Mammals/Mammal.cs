using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals
{
    public abstract class Mammal : ParkInhabitant
    {
        protected Mammal(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override ClassNames ClassName => ClassNames.Mammals;

        public abstract HousingTypes HousingTypes { get; }
    }
}
