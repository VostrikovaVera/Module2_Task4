using System;
using Module2_Task4.Enums;
namespace Module2_Task4.Models
{
    public abstract class ParkInhabitant
    {
        protected ParkInhabitant(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin)
        {
            Gender = gender;
            DateOfBirth = dateOfBirth;
            CountryOfOrigin = countryOfOrigin;
        }

        public Genders Gender { get; }

        public DateTime DateOfBirth { get; }

        public Countries CountryOfOrigin { get; }

        public abstract string Name { get; }

        public abstract Habitats Habitat { get; }

        public abstract ClassNames ClassName { get; }

        public abstract OrderNames OrderName { get; }
    }
}
