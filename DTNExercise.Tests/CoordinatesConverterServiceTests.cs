using DTNExercise.Models;
using DTNExercise.Services;
using FluentAssertions;
using Xunit;

namespace DTNExercise.Tests
{
    public class CoordinatesConverterServiceTests
    {
        private readonly ICoordinatesConverterService _coordinatesConverterService;

        public CoordinatesConverterServiceTests()
        {
            _coordinatesConverterService = new CoordinatesConverterService();
        }

        [Fact]
        public void LatLongToQuadKey_ReturnsValidQuadKey()
        {
            //Given
            double latitude = 40.7128; // New York City latitude
            double longitude = -74.0060; // New York City longitude
            int levelOfDetail = 10;

            //When
            long quadKey = _coordinatesConverterService.LatLongToQuadKey(latitude, longitude, levelOfDetail);

            //Then
            quadKey.Should().NotBe(null);
            quadKey.Should().BeGreaterThan(0);
        }

        [Fact]
        public void LatLongToQuadKey_WithInvalidInput_ReturnsZero()
        {
            //Given
            double invalidLatitude = 200.0;
            double invalidLongitude = -200.0;
            int levelOfDetail = 5;

            //When
            long quadKey = _coordinatesConverterService.LatLongToQuadKey(invalidLatitude, invalidLongitude, levelOfDetail);

            //Then
            quadKey.Should().Be(0);
        }
    }
}