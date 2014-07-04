namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class BinaryDocument : Document
    {
        public BinaryDocument(string docName, string docContent, ulong? docSize = null) 
            : base(docName, docContent)
        {
            this.Size = docSize;
        }

        public ulong? Size
        {
            get;
            private set;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("size", this.Size));
        }
    }
}
