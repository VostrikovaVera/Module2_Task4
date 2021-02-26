using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Rodents.Mouse
{
    public class Mouse : Rodents
    {
        public Mouse(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public override string Name => "Mouse";

        public override Habitats Habitat => Habitats.Steppe;
    }
}
