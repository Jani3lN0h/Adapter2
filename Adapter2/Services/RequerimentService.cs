using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2.Services
{
    public class RequerimentService
    {
        public JObject GetInfoRequerimentTFS(JObject json)
        {

            string cJSON = string.Format("{{ \"RequerimentId\" : \"{0}\",\"Name\" : \"{1}\",\"LOC\" : \"{2}\" }}", json["RequirementId"], "Prueba Test 1", 50);
            JObject jsonReturn = JObject.Parse(cJSON);
            return jsonReturn;
        }
    }
}
