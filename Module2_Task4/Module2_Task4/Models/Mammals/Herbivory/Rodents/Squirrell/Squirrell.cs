using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Rodents.Squirrell
{
    public class Squirrell : Rodents
    {
        public Squirrell(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override string Name => "Squirrell";

        public override Habitats Habitat => Habitats.Forest;
    }
}
