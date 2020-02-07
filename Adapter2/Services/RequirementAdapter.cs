using Adapter2.Domain.Entities;
using Adapter2.Services.Interfaces;
using Newtonsoft.Json.Linq;
using System;

namespace Adapter2.Services
{
    public class RequirementAdapter : IRequirementService
    {
        public object GetInfoRequeriment(int iIdRequirement)
        {
            JObject json = GetInfoJSON(iIdRequirement);
            Console.WriteLine(json);
            RequerimentService srvRequirement = new RequerimentService();
            JObject jsonReturn = srvRequirement.GetInfoRequerimentTFS(json);
            return new Requirement(iIdRequirement, (string)jsonReturn["Name"], (int)jsonReturn["LOC"]);
        }
        private JObject GetInfoJSON(int iIdRequirement)
        {
            string cJSON = string.Format("{{ \"RequerimentId\" : \"{0}\" }}", iIdRequirement);
            JObject json = JObject.Parse(cJSON);
            return json;
        }
    }
}
