using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Services
{
    public interface IMyJsonConverterService
    {
        /// <summary>
        /// Parses a json array string into an array of elements.
        /// </summary>
        /// <typeparam name="T">The type must be a class</typeparam>
        /// <param name="json">The json array string</param>
        /// <returns>An array of elements</returns>
        T[] ArrayFromJsonArray<T>(string json) where T : class;

        /// <summary>
        /// Parses a json string containing several json objects seperated by
        /// new line.
        /// </summary>
        /// <typeparam name="T">The type must be a class</typeparam>
        /// <param name="json">The json string to be parsed</param>
        /// <returns></returns>
        T[] ArrayFromJsonLines<T>(string json) where T : class;
    }
}
