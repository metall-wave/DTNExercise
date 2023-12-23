using DTNExercise.Microsoft.MapPoint;

namespace DTNExercise.Services
{
    public class CoordinatesConverterService : ICoordinatesConverterService
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
        public long LatLongToQuadKey(double latitude, double longitude, int levelOfDetail)
        {
            int pixelX, pixelY;
            int tileX, tileY;

            TileSystem.LatLongToPixelXY(latitude, longitude, levelOfDetail, out pixelX, out pixelY);
            TileSystem.PixelXYToTileXY(pixelX, pixelY, out tileX, out tileY);

            return long.Parse(TileSystem.TileXYToQuadKey(tileX, tileY, levelOfDetail));
        }
    }
}
