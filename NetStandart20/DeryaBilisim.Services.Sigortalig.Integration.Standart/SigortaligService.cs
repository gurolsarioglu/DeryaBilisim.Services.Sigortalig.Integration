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

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHealtInsuranceRequest(NewHealtInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewHealtRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewEarthquakeInsuranceRequest(NewEarthquakeInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewEarthquakeRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewBesInsuranceRequest(NewBesInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewBesRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewCarInsuranceRequest(NewCarInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewCarRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewComprehensiveInsuranceRequest(NewComprehensiveInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewComprehensiveRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewFireInsuranceRequest(NewFireInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewFireRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHouseInsuranceRequest(NewHouseInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewHouseRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewWorkPlaceInsuranceRequest(NewWorkPlaceInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewWorkPlaceRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }
    }
}
