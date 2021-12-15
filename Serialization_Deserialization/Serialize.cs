using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProgramSerialize
{
    class Serialize
    {
        public void BinarySerialize(object data, string fPath)
        {
            FileStream fStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(fPath)) File.Delete(fPath);
            fStream = File.Create(fPath);
            bf.Serialize(fStream, data);
            fStream.Close();
        }
    }
}
