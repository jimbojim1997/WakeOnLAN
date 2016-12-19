using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WakeOnLAN
{
    /// <summary>
    /// Stores configuration data for the application that is to be save and loaded from file.
    /// </summary>
    public class Config
    {
        [XmlArray(ElementName = "Targets")]
        public List<Target> targets = new List<Target>();

        public Config() { }
    }
}
