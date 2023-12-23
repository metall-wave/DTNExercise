using DTNExercise.Models;
using DTNExercise.Services;
using FluentAssertions;
using Xunit;

namespace DTNExercise.Tests
{
    public class MyJsonConverterServiceTests
    {
        IMyJsonConverterService _jsonConverterService;

        public MyJsonConverterServiceTests()
        {
            _jsonConverterService = new MyJsonConverterService();
        }

        [Fact]
        public void ArrayFromJsonLines_WithValidInput_ReturnsLightningArray()
        {
            //Given
            string jsonString = Constants.VALID_JSON_OBJECT_LIST;

            //When
            var result = _jsonConverterService.ArrayFromJsonLines<Lightning>(jsonString);

            //Then
            result.Should().BeOfType<Lightning[]>();
            result.Length.Should().Be(24);
        }

        [Fact]
        public void ArrayFromJsonArray_WithValidInput_ReturnsAssetArray()
        {
            //Given
            string jsonString = Constants.VALID_JSON_ARRAY;

            //When
            var result = _jsonConverterService.ArrayFromJsonArray<Asset>(jsonString);

            //Then
            result.Should().BeOfType<Asset[]>();
            result.Length.Should().Be(4);
        }
    }
}