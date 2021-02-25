using System;
using Module2_Task4.Enums;
namespace Module2_Task4.Models
{
    public abstract class Mammal : ParkInhabitant
    {
        public Mammal(string name, Genders gender, DateTime dateOfBirth, Countries countryOfOrigin, Habitats habitat) : base(name, gender, dateOfBirth, countryOfOrigin, habitat)
        {
        }

        public override ClassNames ClassName => ClassNames.Mammals;

        public abstract HousingTypes HousingTypes { get; }
    }
}
