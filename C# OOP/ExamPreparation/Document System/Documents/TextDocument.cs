namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextDocument : Document, IEditable
    {
        public TextDocument(string docName, string docContent, string docCharSet = null) 
            : base(docName, docContent)
        {
            this.CharSet = docCharSet;
        }

        public string CharSet
        {
            get;
            private set;
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("charset", this.CharSet));
        }
    }
}
