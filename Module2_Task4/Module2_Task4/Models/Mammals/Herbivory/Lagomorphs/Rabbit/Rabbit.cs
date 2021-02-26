using System;
using Module2_Task4.Enums;

namespace Module2_Task4.Models.Mammals.Herbivory.Lagomorphs.Rabbit
{
    public class Rabbit : Lagomorphs
    {
        public Rabbit(Genders gender, DateTime dateOfBirth, Countries countryOfOrigin, RabbitBreeds breed) : base(gender, dateOfBirth, countryOfOrigin)
        {
        }

        public RabbitBreeds Breed { get; }

        public override string Name => "Rabbit";

        public override Habitats Habitat => Habitats.Steppe;
    }
}
