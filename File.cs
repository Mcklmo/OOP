namespace OOP
{
    partial class Program
    {
        class File
        {
            public File(string path)
            {
                _name = path;
            }

            private void Load(string path)
            {
                FileStream stream = new FileStream(path, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                _content = reader.ReadLine() ?? throw new InvalidOperationException("FirstName cannot be null");
                _size = _content.Length;
            }

            public string GetInfo()
            {
                return $"{_name} has length {_size}";
            }

            public string GetContent()
            {
                return _content;
            }
            string _content;
            string _name;
            int _size;
            public string GetName()
            {
                return _name;
            }
            public int GetSize()
            {
                return _size;
            }
        }
    }
}

