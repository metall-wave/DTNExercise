using DTNExercise.Models;

namespace DTNExercise.Services
{
    public class ResourceManager
    {
        private static string? projectDirectory;

        /// <summary>
        /// Parses the assets.json file and returns it's content as an
        /// array of Asset type objects
        /// </summary>
        /// <returns>An array of Asset type objects</returns>
        public static Asset[] GetAssetEntries()
        {
            UpdateResourceDirectory();

            try
            {
                string assetsPath = Path.Combine(projectDirectory, Constants.ASSETS_FILE_NAME);

                if (File.Exists(assetsPath))
                {
                    string assetsJson = File.ReadAllText(assetsPath);
                    Asset[] assetEntries = MyJsonConverter.ArrayFromJsonArray<Asset>(assetsJson);

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
        public static Lightning[] GetLightningEntries()
        {
            UpdateResourceDirectory();

            try
            {
                string lightningPath = Path.Combine(projectDirectory, Constants.LIGHTNING_FILE_NAME);

                if (File.Exists(lightningPath))
                {
                    string lightningJsonLines = File.ReadAllText(lightningPath);
                    Lightning[] lightningEntries = MyJsonConverter.ArrayFromJsonLines<Lightning>(lightningJsonLines);
                    
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

        /// <summary>
        /// Updates the resources folder directory
        /// </summary>
        private static void UpdateResourceDirectory()
        {
            projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            projectDirectory = Path.Combine(projectDirectory, Constants.RESOURCES_FOLDER_NAME);
        }
    }
}
