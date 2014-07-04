namespace DocumentSystem
{
    using System;
    using System.Collections.Generic;
    using Documents;

    public interface IDocument
    {
        string Name { get; }
        string Content { get; }
        void LoadProperty(string key, string value);
        void SaveAllProperties(IList<KeyValuePair<string, object>> output);
        string ToString();
    }

    public interface IEditable
    {
        void ChangeContent(string newContent);
    }

    public interface IEncryptable
    {
        bool IsEncrypted { get; }
        void Encrypt();
        void Decrypt();
    }

    public class DocumentSystem
    {
        private static IList<IDocument> documents = new List<IDocument>();

        static void Main()
        {
            IList<string> allCommands = ReadAllCommands();
            ExecuteCommands(allCommands);
        }

        private static IList<string> ReadAllCommands()
        {
            List<string> commands = new List<string>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "")
                {
                    // End of commands
                    break;
                }
                commands.Add(commandLine);
            }
            return commands;
        }

        private static void ExecuteCommands(IList<string> commands)
        {
            foreach (var commandLine in commands)
            {
                int paramsStartIndex = commandLine.IndexOf("[");
                string cmd = commandLine.Substring(0, paramsStartIndex);
                int paramsEndIndex = commandLine.IndexOf("]");
                string parameters = commandLine.Substring(
                    paramsStartIndex + 1, paramsEndIndex - paramsStartIndex - 1);
                ExecuteCommand(cmd, parameters);
            }
        }

        private static void ExecuteCommand(string cmd, string parameters)
        {
            string[] cmdAttributes = parameters.Split(
                new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            if (cmd == "AddTextDocument")
            {
                AddTextDocument(cmdAttributes);
            }
            else if (cmd == "AddPDFDocument")
            {
                AddPdfDocument(cmdAttributes);
            }
            else if (cmd == "AddWordDocument")
            {
                AddWordDocument(cmdAttributes);
            }
            else if (cmd == "AddExcelDocument")
            {
                AddExcelDocument(cmdAttributes);
            }
            else if (cmd == "AddAudioDocument")
            {
                AddAudioDocument(cmdAttributes);
            }
            else if (cmd == "AddVideoDocument")
            {
                AddVideoDocument(cmdAttributes);
            }
            else if (cmd == "ListDocuments")
            {
                ListDocuments();
            }
            else if (cmd == "EncryptDocument")
            {
                EncryptDocument(parameters);
            }
            else if (cmd == "DecryptDocument")
            {
                DecryptDocument(parameters);
            }
            else if (cmd == "EncryptAllDocuments")
            {
                EncryptAllDocuments();
            }
            else if (cmd == "ChangeContent")
            {
                ChangeContent(cmdAttributes[0], cmdAttributes[1]);
            }
            else
            {
                throw new InvalidOperationException("Invalid command: " + cmd);
            }
        }

        private static void AddTextDocument(string[] attributes)
        {
            string name = null;
            string content = null;
            string charset = null;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("charset"))
                {
                    charset = attributes[i];
                    index = charset.IndexOf('=');
                    charset = charset.Substring(index + 1);
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }
            }

            if (name != null)
            {
                var textDoc = new TextDocument(name, content, charset);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(textDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddPdfDocument(string[] attributes)
        {
            string temp = null;
            string name = null;
            string content = null;
            int? pages = null;
            ulong? size = null;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("pages"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    pages = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }

                if (attributes[i].Contains("size"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    size = (ulong)Convert.ToInt64(temp.Substring(index + 1));
                }
            }

            if (name != null)
            {
                var pdfDoc = new PDFDocument(name, content, size, pages);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(pdfDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddWordDocument(string[] attributes)
        {
            string temp = null;
            string name = null;
            string content = null;
            int? chars = null;
            ulong? size = null;
            string version = null;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("chars"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    chars = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }

                if (attributes[i].Contains("size"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    size = (ulong)Convert.ToInt64(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("version"))
                {
                    version = attributes[i];
                    index = version.IndexOf('=');
                    version = version.Substring(index + 1);
                }
            }

            if (name != null)
            {
                var wordDoc = new WordDocument(name, content, size, version, chars);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(wordDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddExcelDocument(string[] attributes)
        {
            string temp = null;
            string name = null;
            string content = null;
            int? rows = null;
            int? cols = null;
            ulong? size = null;
            string version = string.Empty;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("rows"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    rows = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("cols"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    cols = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }

                if (attributes[i].Contains("size"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    size = (ulong)Convert.ToInt64(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("version"))
                {
                    version = attributes[i];
                    index = version.IndexOf('=');
                    version = version.Substring(index + 1);
                }
            }

            if (name != null)
            {
                var excelDoc = new ExcelDocument(name, content, size, version, rows, cols);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(excelDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddAudioDocument(string[] attributes)
        {
            string temp = null;
            string name = null;
            string content = null;
            int? length = null;
            ulong? size = null;
            int? samplerate = null;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("length"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    length = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("samplerate"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    samplerate = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }

                if (attributes[i].Contains("size"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    size = (ulong)Convert.ToInt64(temp.Substring(index + 1));
                }
            }

            if (name != null)
            {
                var audioDoc = new AudioDocument(name, content, size, length, samplerate);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(audioDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void AddVideoDocument(string[] attributes)
        {
            string temp = null;
            string name = null;
            string content = null;
            int? length = null;
            ulong? size = null;
            int? framerate = null;
            int index;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].Contains("name"))
                {
                    name = attributes[i];
                    index = name.IndexOf('=');
                    name = name.Substring(index + 1);
                }

                if (attributes[i].Contains("length"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    length = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("framerate"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    framerate = Convert.ToInt32(temp.Substring(index + 1));
                }

                if (attributes[i].Contains("content"))
                {
                    content = attributes[i];
                    index = content.IndexOf('=');
                    content = content.Substring(index + 1);
                }

                if (attributes[i].Contains("size"))
                {
                    temp = attributes[i];
                    index = temp.IndexOf('=');
                    size = (ulong)Convert.ToInt64(temp.Substring(index + 1));
                }
            }

            if (name != null)
            {
                var videoDoc = new VideoDocument(name, content, size, length, framerate);
                Console.WriteLine("Document added: {0}", name);
                documents.Add(videoDoc);
            }
            else
            {
                Console.WriteLine("Document has no name");
            }
        }

        private static void ListDocuments()
        {
            if (documents.Count != 0)
            {
                foreach (var document in documents)
                {
                    Console.WriteLine(document);
                }
            }
            else
            {
                Console.WriteLine("No documents found");
            }

        }

        private static void EncryptDocument(string name)
        {
            bool documentFound = false;

            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Encrypt();
                        Console.WriteLine("Document encrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support encryption: " + name);
                    }
                    documentFound = true;
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void DecryptDocument(string name)
        {
            bool documentFound = false;

            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEncryptable)
                    {
                        ((IEncryptable)doc).Decrypt();
                        Console.WriteLine("Document decrypted: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document does not support decryption: " + name);
                    }
                    documentFound = true;
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }

        private static void EncryptAllDocuments()
        {
            bool documentFound = false;

            foreach (var doc in documents)
            {
                if (doc is IEncryptable)
                {
                    ((IEncryptable)doc).Encrypt();
                    documentFound = true;
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("No encryptable documents found");
            }
            else
            {
                Console.WriteLine("All documents encrypted");
            }
        }

        private static void ChangeContent(string name, string content)
        {
            bool documentFound = false;

            foreach (var doc in documents)
            {
                if (doc.Name == name)
                {
                    if (doc is IEditable)
                    {
                        ((IEditable)doc).ChangeContent(content);
                        Console.WriteLine("Document content changed: " + name);
                    }
                    else
                    {
                        Console.WriteLine("Document is not editable: " + name);
                    }
                    documentFound = true;
                }
            }

            if (!documentFound)
            {
                Console.WriteLine("Document not found: " + name);
            }
        }
    }
}
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
            this.properties.Add(new KeyValuePair<string, object>(key, value));
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

        public WordDocument(string docName, string docContent, ulong? docSize, string docVersion, int? docNumberOfChars = null)
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