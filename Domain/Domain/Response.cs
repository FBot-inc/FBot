using System.Collections.Generic;

namespace Domain.Domain
{
    public class Response
    {
        public List<string> Messages = new List<string>();
        public bool IsError;
    } 
}