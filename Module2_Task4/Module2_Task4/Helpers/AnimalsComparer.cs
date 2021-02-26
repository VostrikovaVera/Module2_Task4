using Module2_Task4.Models;
using System.Collections;

namespace Module2_Task4.Helpers
{
    class AnimalsComparer : IComparer
    {
        public int Compare(object i1, object i2)
        {
            var a = i1 as ParkInhabitant;
            var b = i2 as ParkInhabitant;

            if (a.DateOfBirth > b.DateOfBirth)
            {
                return -1;
            }
            else if (a.DateOfBirth < b.DateOfBirth)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
