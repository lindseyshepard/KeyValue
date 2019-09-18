using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValue
{
    struct KeyValue
    {
        // Create a struct named `KeyValue` which contains one `string` 
        //"key" and one `object` "value" as `public readonly` instance fields


        public readonly string Key; //these are properties so they are uppercase
                                    //add in readonly and you dont need the get; 
        public object Value { get; }


        // Implement a constructor for `KeyValue` which sets the instance fields
        public KeyValue(string key, object value) //overloading contrsuture
        {
            this.Key = key;
            this.Value = value;
        }
    }



    //struct NewKeyValue
    //{
    //    public string newkey { private get ; set; }
    //    public object newvalue { private get; set; }

    //    private NewKeyValue(string newkey, object newvalue)
    //    {
    //        this.newkey = newkey;
    //        this.newvalue = newvalue;
    //    }
    //}
}
