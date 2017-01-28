using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Domain
{
    public class Intent : IIntent
    {
        private readonly List<Template> _templates = new List<Template>();

        public IReadOnlyList<Template> GetTemplates()
        {
            return _templates.AsReadOnly(); 
        }

        public void AddTemplate(Template template)
        {
            if (!_templates.Contains(template))
            {
                _templates.Add(template);
            }
        }

        public void DeleteTemplate(Template template)
        {
            _templates.Remove(template);
        }

        public bool Recognize(string message)
        {
            return _templates.Any(p => p.Recognize(message));
        }
    }
}