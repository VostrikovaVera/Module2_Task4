using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Lagomorphs.Hare
{
    public class Hare : Lagomorphs
    {
        public Hare(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override string Name => "Hare";

        public override Habitats Habitat => Habitats.Steppe;
    }
}
