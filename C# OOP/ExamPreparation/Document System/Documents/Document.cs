namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Document : IDocument
    {
        private readonly IList<KeyValuePair<string, object>> properties = new List<KeyValuePair<string, object>>();

        public Document(string docName, string docContent = null)
        {
            this.Name = docName;
            this.Content = docContent;
        }

        public string Name
        {
            get;
            set;
        }

        public string Content
        {
            get;
            set;
        }

        public void LoadProperty(string key, string value)
        {
            this.properties.Add(new KeyValuePair<string,object>(key, value));
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            var results = new List<KeyValuePair<string, object>>();

            SaveAllProperties(results);

            results.Sort((x, y) => x.Key.CompareTo(y.Key));

            StringBuilder result = new StringBuilder();

            result.Append(this.GetType().Name + "[");

            for (int i = 0; i < results.Count; i++)
			{
                if (results[i].Value != null)
                {
                    result.Append(results[i].Key + "=" + results[i].Value + ';');
                }
			}

            var clearResult = result.ToString().TrimEnd(';') + ']';

            return clearResult;
        }
    }
}
