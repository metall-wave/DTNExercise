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
        public void ArrayFromJsonLines_return_type_is_lightning_array()
        {
            //Given
            string jsonString = Constants.VALID_JSON_OBJECT_LIST;

            //When
            var result = _jsonConverterService.ArrayFromJsonLines<Lightning>(jsonString);

            //Then
            result.Should().BeOfType<Lightning[]>();
        }

        [Fact]
        public void ArrayFromJsonLines_handles_valid_json_string()
        {
            //Given
            string jsonString = Constants.VALID_JSON_OBJECT_LIST;

            //When
            var result = _jsonConverterService.ArrayFromJsonLines<Lightning>(jsonString);

            //Then
            result.Length.Should().Be(24);
        }

        [Fact]
        public void ArrayFromJsonArray_return_type_is_asset_array()
        {
            //Given
            string jsonString = Constants.VALID_JSON_ARRAY;

            //When
            var result = _jsonConverterService.ArrayFromJsonArray<Asset>(jsonString);

            //Then
            result.Should().BeOfType<Asset[]>();
        }

        [Fact]
        public void ArrayFromJsonArray_handles_valid_json_string()
        {
            //Given
            string jsonString = Constants.VALID_JSON_ARRAY;

            //When
            var result = _jsonConverterService.ArrayFromJsonArray<Asset>(jsonString);

            //Then
            result.Length.Should().Be(4);
        }
    }
}