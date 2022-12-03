using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanotek.Helpers
{
    public static class StreamHelper
    {
        public static string StreamToString(Stream str)
        {
            var memoryStream = new MemoryStream();
            str.CopyTo(memoryStream);
            memoryStream.Position = 0;
            return StreamToString(memoryStream);
        }

        public static string StreamToString(MemoryStream str)
        {
            string returnStr = "";
            using (StreamReader strr = new StreamReader(str))
                returnStr = strr.ReadToEnd();
            return returnStr;
        }

        public static MemoryStream StringToStream(string str)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}
