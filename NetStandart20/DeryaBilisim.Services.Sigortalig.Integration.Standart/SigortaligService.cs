using RestSharp;

namespace DeryaBilisim.Services.Sigortalig.Integration.Standart
{
    public partial class SigortaligService
    {
        private readonly IRestClient _client;
        public SigortaligService(string endpoint, string token)
        {
            _client = new RestClient(endpoint);
            _client.Authenticator = new RestSharp.Authenticators.JwtAuthenticator(token);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHealtInsuranceRequest(NewHealtRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewHealtRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewEarthquakeInsuranceRequest(NewEarthquakeRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewEarthquakeRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewBesInsuranceRequest(NewBesRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewBesRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewCarInsuranceRequest(NewCarRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewCarRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewComprehensiveInsuranceRequest(NewComprehensiveRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewComprehensiveRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewFireInsuranceRequest(NewFireRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewFireRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHouseInsuranceRequest(NewHouseRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewHouseRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewWorkPlaceInsuranceRequest(NewWorkPlaceRequestInsurance model)
        {
            var request = new RestRequest("/RequestInsurances/NewWorkPlaceRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }
    }
}
