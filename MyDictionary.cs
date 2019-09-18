using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{

    //Create a class named `MyDictionary` which contains one array of
    //KeyValue structs and one `int` to keep track of the number of stored
    //values as private instance fields. You may choose a reasonable fixed size for the array. 

    class MyDictionary
    {
        private int length = 0;

        KeyValue[] keyValue = new KeyValue[]
        {new KeyValue("key1", "value1"),
            new KeyValue("key2", "value2"),
            new KeyValue("key3", "value3"),
            new KeyValue("key4", "value4"),
            new KeyValue("key5", "value5")
        };


        public object this[string key]
        {

            get
            {
                for (int i = 0; i < keyValue.Length; i++)
                {
                    if (keyValue[i].Key.ToLower() == key.ToLower())
                    {
                        //access index of the array
                        return keyValue[i].Value;
                    }
                }
                throw new KeyNotFoundException();

            }

            set
            {
                bool KeyExsists = false;
                for (int i = 0; i < keyValue.Length; i++)
                {


                    if (keyValue[i].Key.Equals(key))
                    {
                        keyValue[i] = new KeyValue(key, value);
                        KeyExsists = true;
                        break;
                    }
                }
               
                    if (!KeyExsists)
                    {
                        length = keyValue.Length;
                        length++;

                    KeyValue[] Temp = new KeyValue[length];
                    //copy old array into temp array
                    for (int i = 0; i < keyValue.Length; i++)
                        {
                        
                        Temp[i] = keyValue[i];

                        }

                        Temp[length - 1] = new KeyValue(key, value);
                        this.keyValue = Temp;
                    }

                }

            }
        }
    }


    //internal class Temp
    //{
    //    private string key;
    //    private object value;

    //    public Temp(string key, object value)
    //    {
    //        this.key = key;
    //        this.value = value;
    //    }
    //}

//            for (int i = 0; i<KeyValue.Length; i++)
//            //implement an indexer which takes a string (key) and returns an object(value)
//            // startig at position 0, moving up 1 until the 5th and final index
//            {
//                for (i = 0; i<KeyValue.Length; i++)
//                {
                  

//                    set property
//                        ()

//            }
//}

    //if key doesnt exsists
    //temp[i] = KeyValue[i];
