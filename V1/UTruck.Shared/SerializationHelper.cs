using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace UTruck.Shared
{
    public class SerializationHelper
    {
        public static InventoryChangeEvent ExtractInventoryChangedEvent(Stream strm)
        {
            return Deserializer<InventoryChangeEvent>(strm);
        }

        public static InventoryChangeEvent TryExtractInventoryChangedEvent(Stream strm)
        {
            try
            {
                return ExtractInventoryChangedEvent(strm);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static MemoryStream SerializeToMemoryStream<T>(T obj)
        {
            var memStream = new MemoryStream();
            Serialize(obj, memStream);
            memStream.Position = 0;
            return memStream;
        }

        public static T Deserializer<T>(Stream source)
        {
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(source);
        }

        public static T TryDeserializer<T>(Stream source) where T : class
        {
            try
            {
                return Deserializer<T>(source);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Serialize<T>(T source, Stream destination)
        {
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(destination, source);
        }
    }
}
