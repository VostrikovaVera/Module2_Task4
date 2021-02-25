using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Rodents.Sheep
{
    public class Sheep : Rodents
    {
        public Sheep(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override string Name => "Sheep";

        public override Habitats Habitat => Habitats.Plain;
    }
}
