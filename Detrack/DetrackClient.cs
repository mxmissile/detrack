using System.Collections.Generic;
using RestSharp;
using ServiceStack.Text;

namespace Detrack
{
    public class DetrackClient
    {
        private readonly RestClient _restClient;

        public DetrackClient(string apiKey)
        {
            _restClient = new RestClient("https://app.detrack.com/api/v1/");
            _restClient.AddDefaultHeader("X-API-KEY", apiKey);
        }

        public DeliveryResponse AddDelivery(Delivery delivery)
        {
            var request = new RestRequest("deliveries/create.json", Method.POST);
            using (var scope = JsConfig.BeginScope())
            {
                scope.EmitLowercaseUnderscoreNames = true;
                scope.IncludeNullValues = false;

                var deliveries = new List<Delivery> { delivery };

                var payload = JsonSerializer.SerializeToString(deliveries);
                request.AddParameter("json", payload);

                var response = _restClient.Execute(request);

                var result = JsonSerializer.DeserializeFromString<DeliveryResponse>(response.Content);
                return result;
            }
        }
    }
}
