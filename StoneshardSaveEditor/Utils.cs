using System.IO;
using System.IO.Compression;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StoneshardSaveEditor
{
    public static class Utils
    {
        public static JObject ReadJson(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(2, SeekOrigin.Begin); //zlib header
                using (DeflateStream deflateStream = new DeflateStream(fs, CompressionMode.Decompress))
                {
                    using (StreamReader sr = new StreamReader(deflateStream, Encoding.UTF8))
                    {
                        using (JsonTextReader reader = new JsonTextReader(sr))
                        {
                            return JObject.Load(reader);

                        }
                        // var decodedData = sr.ReadToEnd();
                        // var jsonEnd = decodedData.LastIndexOf('}');
                        // var jsonString = decodedData.Substring(0, jsonEnd + 1);
                        // return JsonDocument.Parse(jsonString);
                    }
                }
            }
        }
    }
}