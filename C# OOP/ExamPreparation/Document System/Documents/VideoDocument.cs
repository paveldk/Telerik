namespace DocumentSystem.Documents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class VideoDocument : MultimediaDocument
    {
        public VideoDocument(string docName, string docContent, ulong? docSize, int? docLength, int? docFramePerSecond = null)
            : base(docName, docContent, docSize, docLength)
        {
            this.FramePerSecond = docFramePerSecond;
        }

        public int? FramePerSecond
        {
            get;
            private set;
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("framerate", this.FramePerSecond));
        }
    }
}
