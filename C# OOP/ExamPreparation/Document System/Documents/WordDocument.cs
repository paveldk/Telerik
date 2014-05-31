namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class WordDocument : OfficeDocument, IEncryptable, IEditable
    {
        private bool isEncrypted;

        public WordDocument(string docName, string docContent , ulong? docSize, string docVersion , int? docNumberOfChars = null) 
            : base(docName, docContent, docSize, docVersion)
        {
            this.NumberOfChars = docNumberOfChars;
        }

        public int? NumberOfChars
        {
            get;
            private set;
        }

        public bool IsEncrypted
        {
            get { return isEncrypted; }
        }

        public void Encrypt()
        {
            this.isEncrypted = true;
        }

        public void Decrypt()
        {
            this.isEncrypted = false;
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }

        public override string ToString()
        {
            if (isEncrypted)
            {
                return this.GetType().Name + "[encrypted]";
            }
            else
            {
                return base.ToString();
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfChars));
        }
    }
}
