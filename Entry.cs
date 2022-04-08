using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashTable
{
    internal class Entry
    {
        public string key { get; set; }
        public object value { get; set; }

        public Entry(string key, object value)
        {
            this.key = key;
            this.value = value;
        }

    }
}
