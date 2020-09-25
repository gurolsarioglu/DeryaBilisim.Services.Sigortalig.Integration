using System.Collections.Generic;

namespace DeryaBilisim.Services.Sigortalig.Integration.Standart
{
    public partial class SigortaligServiceResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public string internalMessage { get; set; }
        public T data { get; set; }
        public List<object> errors { get; set; }

        public SigortaligServiceResponse()
        {
            errors = new List<object>();
        }
    }
}
