using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProgramDeserialize
{
    class Deserialize
    {
        public object BinaryDeserialize(string fPath)
        {
            object obj = null;

            FileStream fStream;

            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(fPath))
            {
                fStream = File.OpenRead(fPath);
                obj = bf.Deserialize(fStream);
                fStream.Close();
            }

            return 0;
        }
    }
}
