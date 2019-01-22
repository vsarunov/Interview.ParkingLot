using Interview.ParkingLot.Services;
using System;
using System.Collections.Generic;

/**
 * Parking lot suggestion system.
 *
 * Build a simple parking system skeleton with dummy data for multi-floor parking lot which suggests the nearest floor
 * where to drive by floor occupancy level (other rules might be added later, e.g. such as electric cars could park only on specific floors.
 * Rules execution order or dependencies does not matter).
 *
 * Notes:
 *
 * 1) For now implement just one rule - suggesting a nearest floor where is at least one available parking space
 * 2) Boom barrier(s) could be located at any floor (e.g. -1, -2, +1, +2)
 * 3) Create a simple dummmy data for testing your algorithm
 *
 * Example flow:
 * Vehicle approaches boom barrier (could be located any floor) ->
 * scans vehicle's plate number ->
 * resolve from registry system the vehicle details ->
 * calculate the nearest floor by given rule."
 *
 *
 *
 *
 *
 */

namespace Interview.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Would use DI
            IParkingService ps = new ParkingService();
            IRuleValidationService rvs = new RuleValidationService();

            var floor = new Dictionary<int, int>()
            {
                {-2,5 },
                {-1,0 },
                {0,1 },
                {1,3 },
                {2,1 },
            };

            var result = ps.GetFloor(floor, -1, rvs.ValidateFloorSpace);

            Console.WriteLine(result);
        }
    }
}
