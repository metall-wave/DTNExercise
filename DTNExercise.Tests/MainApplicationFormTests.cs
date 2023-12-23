using DTNExercise.Models;
using DTNExercise.Services;
using FakeItEasy;
using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Xunit;

namespace DTNExercise.Tests
{
    public class MainApplicationFormTests
    {
        MainApplicationForm _mainApplicationForm;

        IResourceService _resourceService;
        ICoordinatesConverterService _coordinatesConverter;

        public MainApplicationFormTests()
        {
            _resourceService = A.Fake<IResourceService>();
            _coordinatesConverter = A.Fake<ICoordinatesConverterService>();

            _mainApplicationForm = new MainApplicationForm(_resourceService, _coordinatesConverter);
        }

        [Fact]
        public void GenerateReportListItems_WhenLightningAndAssetEntriesExist_GeneratesReportListItems()
        {
            // Set up lightning and asset entries
            var lightningEntries = new[] { new Lightning { latitude = 40.0, longitude = -75.0 } };
            var assetEntries = new[] { new Asset { quadKey = 1234, assetOwner = 1, assetName = "Name" } };

            A.CallTo(() => _resourceService.GetLightningEntries()).Returns(lightningEntries);
            A.CallTo(() => _resourceService.GetAssetEntries()).Returns(assetEntries);
            A.CallTo(() => _coordinatesConverter.LatLongToQuadKey(40.0, -75.0, DTNExercise.Constants.DEFAULT_LOD)).Returns(1234);

            //When
            _mainApplicationForm.GenerateReportListItems();

            //Then
            _mainApplicationForm.GetReportListBox().Items.Count.Should().Be(1);
            _mainApplicationForm.GetReportListBox().Items[0].Should().Be("lightning alert for 1:Name");
        }
    }
}