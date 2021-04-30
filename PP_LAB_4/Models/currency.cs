using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Net.Http;
using System.ComponentModel;
using System.Data.Entity;
using System.Runtime.Serialization.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PP_LAB_4.Models
{
    public class currency
    {
        public int ID { get; set; }
        public string record_date { get; set; }
        public string name { get; set; }
        public decimal exchange { get; set; }
        [NotMapped]
        public Dictionary<string, decimal> rates { get; set; }
        public currency()
        {
            rates = new Dictionary<string, decimal>();
        }
        public async Task load(string date)
        {
            string call = "https://openexchangerates.org/api/historical/" + date + ".json?app_id=81c1723f53a04465aca559053eaa515a";
            HttpClient httpclient = new HttpClient();
            string json = await httpclient.GetStringAsync(call);
            currency cur = JsonConvert.DeserializeObject<currency>(json);
            this.rates = cur.rates;
        }
    }
}
