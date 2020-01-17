using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_lab_1
{
    class ParkingOccupiedPlaceException :Exception
    {
        public ParkingOccupiedPlaceException(int i) : base("На месте " + i + " ужестоит автомобиль")
        { }
    }
}