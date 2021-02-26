using System;
using Module2_Task4.Enums;
using Module2_Task4.Models;
using Module2_Task4.Models.Mammals.Herbivory.Lagomorphs.Hare;
using Module2_Task4.Models.Mammals.Herbivory.Lagomorphs.Rabbit;
using Module2_Task4.Models.Mammals.Herbivory.Rodents.Goat;
using Module2_Task4.Models.Mammals.Herbivory.Rodents.Mouse;
using Module2_Task4.Models.Mammals.Herbivory.Rodents.Squirrell;
using Module2_Task4.Services.Contracts;

namespace Module2_Task4.Services
{
    public class ParkService : IParkService
    {
        public ParkService()
        {
        }

        public ParkSection CreateParkSection()
        {
            var animals = new ParkInhabitant[]
            {
                new Squirrell(Genders.Female, new DateTime(2018, 07, 08), Countries.Ukraine),
                new Rabbit(Genders.Female, new DateTime(2018, 02, 04), Countries.Canada, RabbitBreeds.NHD),
                new Squirrell(Genders.Female, new DateTime(2020, 12, 07), Countries.Canada),
                new Hare(Genders.Female, new DateTime(2018, 07, 08), Countries.Ukraine),
                new Mouse(Genders.Female, new DateTime(2018, 07, 09), Countries.Ukraine),
                new Goat(Genders.Female, new DateTime(2019, 01, 08), Countries.China),
                new Mouse(Genders.Female, new DateTime(2018, 07, 10), Countries.Ukraine),
                new Rabbit(Genders.Female, new DateTime(2018, 05, 16), Countries.Ukraine, RabbitBreeds.LionHead),
                new Rabbit(Genders.Female, new DateTime(2018, 11, 14), Countries.Finland, RabbitBreeds.MiniLop),
            };

            var animalTypesCount = 0;
            for (var i = 0; i < animals.Length; i++)
            {
                var isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (animals[i].Name == animals[j].Name)
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    animalTypesCount++;
                }
            }

            return new ParkSection { Animals = animals, AminalTypesCount = animalTypesCount };
        }
    }
}
