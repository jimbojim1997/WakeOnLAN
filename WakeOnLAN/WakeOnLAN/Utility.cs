using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace WakeOnLAN
{
    /// <summary>
    /// General utility functions that aren't relevant to the UI.
    /// </summary>
    static class Utility
    {
        public static void XMLSerialize<T>(T data, string filePath)
        {
            if (!File.Exists(filePath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, data);
            }
        }

        public static T XMLDeserialize<T>(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return default(T);
            }

            try
            {
                T data;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                using (FileStream fs = new FileStream(filePath, FileMode.Open))
                {
                    data = (T)xmlSerializer.Deserialize(fs);
                }

                return data;
            }
            catch
            {
                return default(T);
            }
        }
    }
}
