using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using DZ.Model;
using Newtonsoft.Json;

namespace DZ.Presenter.SerializePresenter
{
    public class SerializPresenter
    {
        public SerializPresenter(List<Person> people)
        {
            var json = Serialize(people);

            using FileStream fs = new("People.json", FileMode.OpenOrCreate);
            using StreamWriter sw = new(fs);

            sw.Write(json);
        }

        public string Serialize(List<Person> obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public string Deserialize(string json)
        {
            var res = JsonConvert.DeserializeObject(json);
            return (string)res;
        }
    }
}
