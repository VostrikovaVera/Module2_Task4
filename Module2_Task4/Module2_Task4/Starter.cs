using System;
using Module2_Task4.Enums;
using Module2_Task4.Helpers;
using Module2_Task4.Services;
using Module2_Task4.Services.Contracts;

namespace Module2_Task4
{
    public class Starter
    {
        private readonly IParkService _parkService;

        public Starter()
        {
            _parkService = new ParkService();
        }

        public void Run()
        {
            var parkSection = _parkService.CreateParkSection();

            Array.Sort(parkSection.Animals, new AnimalsComparer());

            Console.WriteLine($"There are {parkSection.AminalTypesCount} types of animals living in this section!");

            for (var i = 0; i < parkSection.Animals.Length; i++)
            {
                Console.WriteLine($"Name: {parkSection.Animals[i].Name} Country of origin: {parkSection.Animals[i].CountryOfOrigin} DateOfBirth: {parkSection.Animals[i].DateOfBirth}");
            }

            Console.WriteLine("----------------------------");

            var animalsFiltered = parkSection.Animals.FilterNameOrigin("Squirrel", Countries.Canada);

            for (var i = 0; i < animalsFiltered.Length; i++)
            {
                Console.WriteLine($"Name: {animalsFiltered[i].Name} Country of origin: {animalsFiltered[i].CountryOfOrigin} DateOfBirth: {animalsFiltered[i].DateOfBirth}");
            }
        }
    }
}