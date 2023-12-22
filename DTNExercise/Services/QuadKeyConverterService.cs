
//------------------------------------------------------------------------------  
// <copyright company="Microsoft">  
//     Copyright (c) 2006-2009 Microsoft Corporation.  All rights reserved.  
// </copyright>  
//------------------------------------------------------------------------------  

using DTNExercise.Microsoft.MapPoint;
using System.Text;

namespace DTNExercise.Services
{
    public static class QuadKeyConverterService
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
        public static long LatLongToQuadKey(double latitude, double longitude, int levelOfDetail)
        {
            int pixelX, pixelY;
            int tileX, tileY;

            TileSystem.LatLongToPixelXY(latitude, longitude, levelOfDetail, out pixelX, out pixelY);
            TileSystem.PixelXYToTileXY(pixelX, pixelY, out tileX, out tileY);

            return long.Parse(TileSystem.TileXYToQuadKey(tileX, tileY, levelOfDetail));
        }
    }
}
