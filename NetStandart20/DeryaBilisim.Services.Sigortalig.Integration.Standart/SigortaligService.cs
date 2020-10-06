using RestSharp;
using System.Collections.Generic;
using System.Linq;

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

        /// <summary>
        /// Creates a new Healty Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHealtyInsuranceRequest(NewHealtInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewHealtRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Earthquake Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewEarthquakeInsuranceRequest(NewEarthquakeInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewEarthquakeRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Individual Pension Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewBesInsuranceRequest(NewBesInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewBesRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Car Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewCarInsuranceRequest(NewCarInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewCarRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Comprehensive Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewComprehensiveInsuranceRequest(NewComprehensiveInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewComprehensiveRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Fire Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewFireInsuranceRequest(NewFireInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewFireRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new House Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewHouseInsuranceRequest(NewHouseInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewHouseRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Work Place Insurance Request.
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewWorkPlaceInsuranceRequest(NewWorkPlaceInsuranceRequestModel model)
        {
            var request = new RestRequest("/RequestInsurances/NewWorkPlaceRequestInsurance", Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Creates a new Other Insurance Request. Except(Healty, Car, Work Place, Fire, House, Comprehensive, Individual Pension, Earthquake)
        /// </summary>
        /// <param name="model">Request model.</param>
        /// <param name="insuranceType">Insurance Type.</param>
        /// <returns></returns>
        public IRestResponse<SigortaligServiceResponse<NewRequestInsuranceResponse>> NewOtherInsuranceRequest(NewOtherInsuranceRequestModel model, InsuranceType insuranceType)
        {
            var insuranceTypes = GetAllInsuranceTypes();

            var endpoint = insuranceTypes.Data?.SingleOrDefault(x => x.InsuranceType == insuranceType).ApiEndPoint;
            endpoint = endpoint.Replace("api/", "/");

            var request = new RestRequest(endpoint, Method.POST, DataFormat.Json);
            request.AddJsonBody(model);
            return _client.Post<SigortaligServiceResponse<NewRequestInsuranceResponse>>(request);
        }

        /// <summary>
        /// Get all insurance types with name and API end points.
        /// </summary>
        /// <returns></returns>
        public IRestResponse<List<InsuranceTypeResponse>> GetAllInsuranceTypes()
        {
            var request = new RestRequest("/RequestInsurances/GetAllInsuranceTypes", Method.GET, DataFormat.Json);
            return _client.Get<List<InsuranceTypeResponse>>(request);
        }
    }
}
