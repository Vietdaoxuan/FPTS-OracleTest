using System.IO;
using System.Net.Http;

namespace CoreLib.SharedKernel
{
    public class FileContent : MultipartFormDataContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileContent"/> class.
        /// FileContent.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="apiParamName"></param>
        public FileContent(string filePath, string apiParamName)
        {
            var filestream = File.Open(filePath, FileMode.Open);
            var filename = Path.GetFileName(filePath);

            this.Add(new StreamContent(filestream), apiParamName, filename);
        }
    }
}
