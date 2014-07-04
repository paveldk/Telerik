namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class OfficeDocument : BinaryDocument
    {
        public OfficeDocument(string docName, string docContent, ulong? docSize, string docVersion = null) 
            : base(docName, docContent, docSize)
        {
            this.Version = docVersion;
        }

        public string Version
        {
            get;
            private set;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("version", this.Version));
        }
    }
}
