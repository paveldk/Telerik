namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ExcelDocument : OfficeDocument, IEncryptable
    {
        private bool isEncrypted;

        public ExcelDocument(string docName, string docContent = null, ulong? docSize = null, string docVersion = null, int? docNumberOfRows = null, int? docNumberOfCols = null) 
            : base(docName, docContent, docSize, docVersion)
        {
            this.NumberOfRows = docNumberOfRows;
            this.NumberOfCols = docNumberOfCols;
        }

        public int? NumberOfRows
        {
            get;
            private set;
        }

        public int? NumberOfCols
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
            output.Add(new KeyValuePair<string, object>("rows", this.NumberOfRows));
            output.Add(new KeyValuePair<string, object>("cols", this.NumberOfCols));
        }
    }
}
