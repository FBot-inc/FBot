using System.Collections.Generic;

namespace Domain.Domain
{
    public class ConnectData
    {
        public string UserId { get; set; }
        public List<string> Messages { get; } = new List<string>();

        public override string ToString()
        {
            return "ConnectData [UserId = " + UserId + " ]";
        }
    }
}