using DTNExercise.Models;
using DTNExercise.Services;
using FakeItEasy;
using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace DTNExercise.Tests
{
    public class ResourceServiceTests
    {
        IResourceService _resourceManagerService;
        IMyJsonConverterService _jsonConverterService;
        IFileService _fileService;

        string assetsPath;
        string lightningPath;

        public ResourceServiceTests()
        {
            _fileService = A.Fake<IFileService>();
            _jsonConverterService = A.Fake<IMyJsonConverterService>();

            _resourceManagerService = new ResourceService(_fileService, _jsonConverterService);

            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            projectDirectory = Path.Combine(projectDirectory, DTNExercise.Constants.RESOURCES_FOLDER_NAME);

            assetsPath = Path.Combine(projectDirectory, DTNExercise.Constants.ASSETS_FILE_NAME);
            lightningPath = Path.Combine(projectDirectory, DTNExercise.Constants.LIGHTNING_FILE_NAME);
        }

        [Fact]
        public void GetAssetEntries_WhenAssetFileExists_ReturnsAssetArray()
        {
            //Given
            string jsonContent = Constants.VALID_JSON_ARRAY;

            A.CallTo(() => _fileService.FileExists(assetsPath)).Returns(true);
            A.CallTo(() => _fileService.ReadAllText(assetsPath)).Returns(jsonContent);

            A.CallTo(() => _jsonConverterService.ArrayFromJsonArray<Asset>(jsonContent))
                .Returns(new[] { new Asset(), new Asset() });

            //When
            Asset[] assets = _resourceManagerService.GetAssetEntries();

            //Then
            assets.Should().NotBeNull();
            assets.Should().HaveCount(2);
        }

        [Fact]
        public void GetAssetEntries_WhenFileDoesNotExist_ThrowsException()
        {
            //Given
            A.CallTo(() => _fileService.FileExists(assetsPath)).Returns(false);

            // When & Then
            Action act = () => _resourceManagerService.GetAssetEntries();
            act.Should().Throw<Exception>().WithMessage(DTNExercise.Constants.ASSETS_FILE_NOT_FOUND_MESSAGE);
        }

        [Fact]
        public void GetLightningEntries_WhenLightningFileExists_ReturnsLightningArray()
        {
            //Given
            string jsonContent = Constants.VALID_JSON_OBJECT_LIST;

            A.CallTo(() => _fileService.FileExists(lightningPath)).Returns(true);
            A.CallTo(() => _fileService.ReadAllText(lightningPath)).Returns(jsonContent);

            A.CallTo(() => _jsonConverterService.ArrayFromJsonLines<Lightning>(jsonContent))
                .Returns(new[] { new Lightning(), new Lightning() });

            //When
            Lightning[] lightningArray = _resourceManagerService.GetLightningEntries();

            //Then
            lightningArray.Should().NotBeNull();
            lightningArray.Should().HaveCount(2);
        }

        [Fact]
        public void GetLightningEntries_WhenFileDoesNotExist_ThrowsException()
        {
            //Given
            A.CallTo(() => _fileService.FileExists(lightningPath)).Returns(false);

            // When & Then
            Action act = () => _resourceManagerService.GetLightningEntries();
            act.Should().Throw<Exception>().WithMessage(DTNExercise.Constants.LIGHNING_FILE_NOT_FOUND_MESSAGE);
        }
    }
}