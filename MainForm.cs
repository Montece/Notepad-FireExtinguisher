namespace FireExtinguisher
{
    public partial class MainForm : Form
    {
        private List<MainFormTab> MainFormTabs = new();
        private MainFormTab CurrentMainFormTab = null;

        public MainForm()
        {
            InitializeComponent();

            List<string> args = Environment.GetCommandLineArgs().ToList();
            args.RemoveAt(0);

            foreach (string textfile in args)
            {
                OpenFile(textfile);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Environment.GetCommandLineArgs();
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileWithDialog();
        }

        private void OpenFileWithDialog()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Текстовый файл|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFile(openFileDialog.FileName);
            }
        }

        private void OpenFile(string filename)
        {
            TextFileEditor textFileEditor = new TextFileEditor();
            bool result = textFileEditor.OpenTextFile(filename);

            if (result)
            {
                MainFormTab tab = new MainFormTab();
                tab.TextFileEditor = textFileEditor;

                TextBox textBox = new()
                {
                    Multiline = true,
                    Text = tab.TextFileEditor.Text,
                    Dock = DockStyle.Fill
                };

                TabPage tabPage = new()
                {
                    Text = Path.GetFileName(filename),
                    Controls = { textBox }
                };

                tab.TextFileTab = tabPage;

                if (CurrentMainFormTab == null) CurrentMainFormTab = tab;

                MainFormTabs.Add(tab);

                Tabs.TabPages.Add(tabPage);
                Tabs.SelectedTab = tabPage;
            }
        }

        private void SaveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            if (CurrentMainFormTab == null) return;
            EditCurrentText();
            CurrentMainFormTab.TextFileEditor.SaveTextFile();
        }

        private void EditCurrentText()
        {
            if (CurrentMainFormTab == null) return;
            TextBox textBox = CurrentMainFormTab.TextFileTab.Controls[0] as TextBox;
            CurrentMainFormTab.TextFileEditor.EditText(textBox.Text);
        }

        private void SaveAllFileMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentMainFormTab == null) return;
            EditCurrentText();
            foreach (MainFormTab tab in MainFormTabs) tab.TextFileEditor.SaveTextFile();
        }

        private void Tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeCurrentTab(Tabs.SelectedTab);
        }

        private void ChangeCurrentTab(TabPage page)
        {
            EditCurrentText();
            CurrentMainFormTab = SearchTab(page);
        }

        private MainFormTab SearchTab(TabPage selectedTab)
        {
            MainFormTab temp = null;

            for (int i = 0; i < MainFormTabs.Count; i++)
            {
                if (MainFormTabs[i].TextFileTab == selectedTab)
                {
                    temp = MainFormTabs[i];
                    break;
                }
            }

            return temp;
        }

        private void CloseFileMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile();
        }

        private void CloseFile()
        {
            if (CurrentMainFormTab == null) return;
            MainFormTab toClose = CurrentMainFormTab;
            CurrentMainFormTab = null;
            MainFormTabs.Remove(toClose);
            Tabs.TabPages.Remove(toClose.TextFileTab);
        }

        private void Tabs_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.F4)) CloseFile();
            if (e.KeyData == (Keys.Control | Keys.S)) SaveFile();
            if (e.KeyData == (Keys.Control | Keys.O)) OpenFileWithDialog();
        }
    }
}