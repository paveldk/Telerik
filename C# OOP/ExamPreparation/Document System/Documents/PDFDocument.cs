namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class PDFDocument : BinaryDocument, IEncryptable
    {
        private bool isEncrypted;

        public PDFDocument(string docName, string docContent, ulong? docSize, int? docNumberOfPages = null) 
            : base(docName, docContent, docSize)
        {
            this.NumberOfPages = docNumberOfPages;
        }

        public int? NumberOfPages
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
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
        }
    }
}
