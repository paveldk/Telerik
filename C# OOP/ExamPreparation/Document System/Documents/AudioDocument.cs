namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AudioDocument : MultimediaDocument
    {
        public AudioDocument(string docName, string docContent = "", ulong? docSize = null, int? docLength = null, int? docSampleRate = null)
            : base(docName, docContent, docSize, docLength)
        {
            this.SampleRate = docSampleRate;
        }

        public int? SampleRate
        {
            get;
            private set;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
        }
    }
}
