using DTNExercise.Models;

namespace DTNExercise.Services
{
    public class ResourceService : IResourceService
    {
        private readonly string? _projectDirectory;
        private readonly IMyJsonConverterService _jsonConverterService;
        private readonly IFileService _fileService;

        public ResourceService(IFileService fileService, IMyJsonConverterService jsonConverterService)
        {
            _projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            _projectDirectory = Path.Combine(_projectDirectory, Constants.RESOURCES_FOLDER_NAME);

            _jsonConverterService = jsonConverterService;
            _fileService = fileService;
        }

        /// <summary>
        /// Parses the assets.json file and returns it's content as an
        /// array of Asset type objects
        /// </summary>
        /// <returns>An array of Asset type objects</returns>
        public Asset[] GetAssetEntries()
        {
            try
            {
                string assetsPath = Path.Combine(_projectDirectory, Constants.ASSETS_FILE_NAME);

                if (_fileService.FileExists(assetsPath))
                {
                    string assetsJson = _fileService.ReadAllText(assetsPath);
                    Asset[] assetEntries = _jsonConverterService.ArrayFromJsonArray<Asset>(assetsJson);

                    return assetEntries;
                }
                else
                {
                    throw new Exception(Constants.ASSETS_FILE_NOT_FOUND_MESSAGE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Parses the lightning.json file and returns it's content as an
        /// array of Lighting type objects
        /// </summary>
        /// <returns>An array of Ligtning type objects</returns>
        public Lightning[] GetLightningEntries()
        {
            try
            {
                string lightningPath = Path.Combine(_projectDirectory, Constants.LIGHTNING_FILE_NAME);

                if (_fileService.FileExists(lightningPath))
                {
                    string lightningJsonLines = _fileService.ReadAllText(lightningPath);
                    Lightning[] lightningEntries = _jsonConverterService.ArrayFromJsonLines<Lightning>(lightningJsonLines);

                    return lightningEntries;
                }
                else
                {
                    throw new Exception(Constants.LIGHNING_FILE_NOT_FOUND_MESSAGE);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
