using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class ObstacleCollection
    {

        public List<Obstacles> collection { get; set; }

        public ObstacleCollection()
        {
            collection = new List<Obstacles>();
        }

        public Boolean AddEvent(Obstacles obstacleIn)
        {
            try
            {
                collection.Add(obstacleIn);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Array ConvertToArray()
        {
            Obstacles[] collectionArray = collection.ToArray();
            return collectionArray;
        }

        public string SerializeObject()
        {
            string json = JsonConvert.SerializeObject(collection, Formatting.None);
            return json;
        }

    }
}
