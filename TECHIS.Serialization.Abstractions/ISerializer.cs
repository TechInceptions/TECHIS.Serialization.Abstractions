using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECHIS.Serialization.Absractions
{
    public interface ISerializer
    {
        void Serialize<T>(T obj, Stream stream);
        Task SerializeAsync<T>(T obj, Stream stream);

        T Deserialize<T>(Stream stream);
        Task<T> DeserializeAsync<T>(Stream stream);
    }
}
