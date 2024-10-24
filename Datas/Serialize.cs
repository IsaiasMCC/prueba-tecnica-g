﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace Task.Datas
{
   
    public class Serialize
    {
        public static void Save<T>(T objeto, string f)
        {
            string s = JsonConvert.SerializeObject(objeto);
            TextWriter file = new StreamWriter($"{f}");
            file.Write(s);
            file.Close();
        }

        public static T Load<T>(string f)
        {
            T objectt = default(T);
            TextReader read = new StreamReader($"{f}");
            string s = read.ReadToEnd();
            objectt = JsonConvert.DeserializeObject<T>(s);
            Console.WriteLine(objectt);
            read.Close();
            return objectt;
        }
    }
}
