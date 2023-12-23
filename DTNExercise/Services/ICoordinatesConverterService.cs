using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Services
{
    public interface ICoordinatesConverterService
    {
        /// <summary>
        /// Converts a point from latitude/longitude WGS-84 coordinates (in degrees)
        /// into a QuadKey at a specified level of detail.
        /// </summary>
        /// <param name="latitude">Latitude of the point, in degrees.</param>
        /// <param name="longitude">Longitude of the point, in degrees.</param>
        /// <param name="levelOfDetail">Level of detail, from 1 (lowest detail)  
        /// to 23 (highest detail).</param>
        /// <returns></returns>
        long LatLongToQuadKey(double latitude, double longitude, int levelOfDetail);
    }
}
