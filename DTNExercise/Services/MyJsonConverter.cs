using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Services
{
    public static class MyJsonConverter
    {
        /// <summary>
        /// Parses a json array string into an array of elements.
        /// </summary>
        /// <typeparam name="T">The type must be a class</typeparam>
        /// <param name="json">The json array string</param>
        /// <returns>An array of elements</returns>
        public static T[] ArrayFromJsonArray<T>(string json) where T: class
        {
            return JsonConvert.DeserializeObject<T[]>(json);
        }

        /// <summary>
        /// Parses a json string containing several json objects seperated by
        /// new line.
        /// </summary>
        /// <typeparam name="T">The type must be a class</typeparam>
        /// <param name="json">The json string to be parsed</param>
        /// <returns></returns>
        public static T[] ArrayFromJsonLines<T>(string json) where T : class
        {
            string[] lines = json.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //Parse
            T[] resultArray = new T[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                resultArray[i] = JsonConvert.DeserializeObject<T>(lines[i]);
            }

            return resultArray;
        }
    }
}
