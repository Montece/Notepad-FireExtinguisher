namespace FireExtinguisher
{
    public class TextFileEditor
    {
        public string Text { get; private set; }
        public string Filepath { get; private set; }

        public bool OpenTextFile(string filepath)
        {
            if (!File.Exists(filepath)) return false;
            if (string.IsNullOrEmpty(Path.GetExtension(filepath))) return false;
            string ext = Path.GetExtension(filepath);
            if (Path.GetExtension(filepath) != ".txt") return false;

            try
            {
                Filepath = filepath;
                Text = File.ReadAllText(Filepath);
                return true;
            }
            catch
            {
                Filepath = "";
                Text = "";
                return false;
            }
        }

        public void EditText(string newText)
        {
            Text = newText;
        }

        public bool SaveTextFile()
        {
            try
            {
                File.WriteAllText(Filepath, Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}