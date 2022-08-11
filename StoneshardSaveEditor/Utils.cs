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
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                using (var inputStream = new InflaterInputStream(fs))
                {
                    using (StreamReader sr = new StreamReader(inputStream, Encoding.UTF8))
                    {
                        using (JsonTextReader reader = new JsonTextReader(sr))
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