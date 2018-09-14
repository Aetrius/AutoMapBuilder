using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace AutoMapBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportSong_Click(object sender, EventArgs e)
        {
            var objectToSerialize = new Map();
            objectToSerialize = new Map
            {
                _version = "1.5.0",
                _beatsPerMinute = 90,
                _beatPerBar = 16,
                _noteJumpSpeed = 10,
                _shuffle = 0,
                _shufflePeriod = 0.5,
                _events = null,
                _notes = null,
                _obstacles = null

            };


            var collection = new EventCollection();
            collection.AddEvent(new Events(34.827999114990234, 3, 3));
            collection.AddEvent(new Events(34.827999114990335, 2, 3));
            collection.AddEvent(new Events(34.827999114990452, 1, 3));


            //objectToSerialize._events = collection.SerializeObject();
            objectToSerialize._events = collection.ConvertToArray();

            JavaScriptSerializer js = new JavaScriptSerializer();
            string jsonData = js.Serialize(objectToSerialize);
            Console.WriteLine(jsonData);

        }
    }
}
