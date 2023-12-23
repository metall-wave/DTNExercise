using DTNExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Services
{
    public interface IResourceService
    {
        /// <summary>
        /// Parses the assets.json file and returns it's content as an
        /// array of Asset type objects
        /// </summary>
        /// <returns>An array of Asset type objects</returns>
        Asset[] GetAssetEntries();

        /// <summary>
        /// Parses the lightning.json file and returns it's content as an
        /// array of Lighting type objects
        /// </summary>
        /// <returns>An array of Ligtning type objects</returns>
        Lightning[] GetLightningEntries();
    }
}
