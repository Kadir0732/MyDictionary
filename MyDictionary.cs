using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;
        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void add(Tkey key, Tvalue value)
        {
            Tkey[] tempKey = keys;
            Tvalue[] tempValue = values;
        
            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for(int i = 0;i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
            }

            for(int j = 0;j < tempValue.Length; j++)
            {
                values[j] = tempValue[j];
            }
            values[values.Length - 1] = value;
            keys[keys.Length - 1] = key;
        }
        public void show()
        {
            for (int i = 0; i < keys.Length; i++)
            {         
                    Console.WriteLine("Key: "+ keys[i]+", value: "+ values[i]);
            }
        }
    }
}
