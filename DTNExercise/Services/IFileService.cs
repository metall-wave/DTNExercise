using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTNExercise.Services
{
    public interface IFileService
    {
        bool FileExists(string path);
        string ReadAllText(string path);
    }
}