using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class EventCollection
    {
        public List<Events> collection { get; set; }

        public EventCollection()
        {
            collection = new List<Events>();
        }
        
        public Boolean AddEvent(Events eventIn)
        {
            try {
                collection.Add(eventIn);
                return true;
            } catch
            {
                return false;
            }

        }

        public Array ConvertToArray()
        {
            Events[] collectionArray = collection.ToArray();
            return collectionArray;
        }

        public string SerializeObject()
        {
            string json = JsonConvert.SerializeObject(collection, Formatting.None);
            return json;
        }

    }
}
