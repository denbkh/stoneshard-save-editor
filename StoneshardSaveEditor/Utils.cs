using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace StoneshardSaveEditor
{
    public static class Utils
    {
        public static JObject ReadJson(string file)
        {
            using (FileStream fileStream = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (InflaterInputStream inputStream = new InflaterInputStream(fileStream))
                {
                    using (StreamReader streamReader = new StreamReader(inputStream, Encoding.UTF8))
                    {
                        using (JsonTextReader reader = new JsonTextReader(streamReader))
                        {
                            reader.FloatParseHandling = FloatParseHandling.Decimal;
                            return JObject.Load(reader);
                        }
                    }
                }
            }
        }
    }
}
