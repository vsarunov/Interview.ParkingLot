using System;
using System.Collections.Generic;

namespace Interview.ParkingLot.Services
{
    public interface IParkingService
    {
        int? GetFloor(IDictionary<int, int> floorSpace, int boomBarriers, Func<int, int, bool> rule);
    }
}