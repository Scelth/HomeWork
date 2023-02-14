using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.Presenter
{
    public class DeserializePresenter : IDeserializeable
    {
        public DeserializePresenter()
        {
            using FileStream fs = new("People.json", FileMode.OpenOrCreate);
            using StreamReader sr = new(fs);

            Deserialize(sr.ReadToEnd());
            var res = JsonConvert.DeserializeObject("People.json");
        }

        public void Deserialize(string json)
        {
            //var res = JsonConvert.DeserializeObject(json).ToString;
            //return (string)res;
        }
    }
}
