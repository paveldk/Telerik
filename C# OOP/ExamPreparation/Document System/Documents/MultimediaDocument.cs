namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class MultimediaDocument : BinaryDocument
    {
        public MultimediaDocument(string docName, string docContent, ulong? docSize, int? docLength = null)
            : base(docName, docContent, docSize)
        {
            this.Length = docLength;
        }

        public int? Length
        {
            get;
            private set;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("length", this.Length));
        }
    }
}
