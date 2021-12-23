using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DawrfD;
using ProgramSerialize;
using ProgramDeserialize;

namespace UTest
{
    class UnitTest
    {
        static void Main(string[] args)
        {
            Dwarf dwarf = new Dwarf()
            {
                Color = "Green",
                Name = "Albert"
            };

            string fPath = "DataPlayer";
            Serialize dataSerialize = new Serialize();
            Deserialize dataDeserialize = new Deserialize();
            Dwarf d = null;

            dataSerialize.BinarySerialize(dwarf, fPath);

            d = dataDeserialize.BinaryDeserialize(fPath) as Dwarf;

            Console.WriteLine(d.Color);
            Console.WriteLine(d.Name);

            Console.ReadLine();
        }
    }
}
