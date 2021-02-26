using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Rodents.Goat
{
    public class Goat : Rodents
    {
        public Goat(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override string Name => "Goat";

        public override Habitats Habitat => Habitats.Plain;
    }
}
