using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapBuilder
{
    class NoteCollection
    {

        public List<Notes> collection { get; set; }

        public NoteCollection()
        {
            collection = new List<Notes>();
        }

        public Boolean AddNote(Notes noteIn)
        {
            try
            {
                collection.Add(noteIn);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Array ConvertToArray()
        {
            Notes[] collectionArray = collection.ToArray();
            return collectionArray;
        }

        public string SerializeObject()
        {
            string json = JsonConvert.SerializeObject(collection, Formatting.None);
            return json;
        }


    }
}
