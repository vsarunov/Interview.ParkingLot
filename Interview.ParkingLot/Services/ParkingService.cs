using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interview.ParkingLot.Services
{
    public class ParkingService : IParkingService
    {

        /// <summary>
        /// Would definately make this rules generic and applicable not only to a specific case.
        /// As well would make a list of invokable rules to check agains no one single rule.
        /// Since we can go only up and down we can take There is no need to use shortest path algorithm.
        /// This assumes that we would always get floor numbers even if there would be no space otherwise we would validate FirstOrDefault for null value.
        /// We would probably need to validate if there are any rules, in this case if the rule is not null actually.
        /// The carId is not used however we assume that there would be an object of boom Barrier which would provide as a carId which is basically a car palte number.
        /// If there would be a list of cars supplied we would need to minus the free space each time we park a car.
        /// We return a nullanle assuming there is no parking space or an error occured.
        /// </summary>
        public int? GetFloor(IDictionary<int, int> floorSpace, int boomBarriers, Func<int, int, bool> rule)
        {
            if (rule == null) return null;

            var ordered = floorSpace?.Select(x => new { x.Key, FreeSpace = x.Value, Distance = Math.Abs(x.Key - boomBarriers) })
                .Where(x => rule(x.FreeSpace, 1))
                .OrderBy(x => x.Distance)
                .FirstOrDefault()?.Key;

            return ordered;
        }

    }
}
