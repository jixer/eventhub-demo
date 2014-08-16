using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using UTruck.Shared;

namespace UTruck.Offsite.Consumer
{
    public class StateManager
    {
        private const string _filePath = "state.dat";

        public static SiteState LoadState()
        {
            if (File.Exists(_filePath))
            {
                var fileStream = File.OpenRead(_filePath);
                SiteState state = SerializationHelper.TryDeserializer<SiteState>(fileStream);
                fileStream.Close();

                if (state != null) return state;
                else return new SiteState();
            }
            else
            {
                return new SiteState();
            }
        }

        public static void WriteState(SiteState state)
        {
            var fileStream = File.Create(_filePath);
            SerializationHelper.Serialize(state, fileStream);
            fileStream.Close();
        }
    }
}
