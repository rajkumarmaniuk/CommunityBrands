// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
Json();
static void Json()
{
    //using (StreamReader r = new StreamReader("./Json/input_mis_data.json"))
    //{
    //    string json = r.ReadToEnd();
    //    var items = JsonConvert.DeserializeObject<List<string>>(json);
    //    var ss=string.Empty;
    //}

   // JObject inputFile = JObject.Parse(File.ReadAllText("./Json/input_mis_data.json"));

    // read JSON directly from a file
    JObject inputValues = new JObject();
    using (StreamReader file = File.OpenText("./Json/input_mis_data.json"))
    
    using (JsonTextReader reader = new JsonTextReader(file))
    {
        inputValues = (JObject)JToken.ReadFrom(reader);
    }
    List<string> values = new List<string>();
}