using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Serialization.Abstractions
{
    /// <summary>
    /// a do-nothing serializer
    /// </summary>
    public class DefaultBinarySerializer : ISerializer
    {
        public T Deserialize<T>(Stream stream)
        {
            return default(T);
        }

        public Task<T> DeserializeAsync<T>(Stream stream)
        {
            return Task.FromResult<T>(default(T));
        }

        public void Serialize<T>(T obj, Stream stream)
        {
            //Do nothing
        }

        public Task SerializeAsync<T>(T obj, Stream stream)
        {
            return Task.FromResult<int>(0);
        }
    }
}
