using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain
{
    public interface ITemplate
    {
        bool Recognize(string message);
    }

    public class Template : ITemplate
    {
        private readonly string _templateString;

        public Template(string templateString)
        {
            _templateString = templateString;
        }

        public bool Recognize(string message)
        {
            if (message == null)
            {
                return _templateString == null;
            }

            var result = message.Equals(_templateString);

            return result;
        }

        public override bool Equals(object obj)
        {
            var template = obj as Template; 

            return template != null && template._templateString.Equals(_templateString);
        }

        protected bool Equals(Template other)
        {
            return string.Equals(_templateString, other._templateString);
        }

        public override int GetHashCode()
        {
            return _templateString?.GetHashCode() ?? 0;
        }
    }
}