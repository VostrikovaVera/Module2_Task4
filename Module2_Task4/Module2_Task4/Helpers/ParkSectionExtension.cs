using Module2_Task4.Enums;
using Module2_Task4.Models;

namespace Module2_Task4.Helpers
{
    public static class ParkSectionExtension
    {
        public static ParkInhabitant[] FilterNameOrigin(this ParkInhabitant[] animals, string name, Countries country)
        {
            var filteredItems = new ParkInhabitant[animals.Length];
            var count = 0;

            for (var i = 0; i < animals.Length; i++)
            {
                if (animals[i].Name.Contains(name) && animals[i].CountryOfOrigin == country)
                {
                    filteredItems[i] = animals[i];
                    count++;
                }
            }

            if (count == 0)
            {
                return null;
            }

            var result = new ParkInhabitant[count];
            var counter = 0;

            for (var i = 0; i < filteredItems.Length; i++)
            {
                if (filteredItems[i] != null)
                {
                    result[counter] = filteredItems[i];
                    counter++;
                }
            }

            return result;
        }
    }
}
