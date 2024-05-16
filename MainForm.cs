using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace Assignment4_CS_GUI
{
    public partial class MainForm : Form
    {
        private FileManager fileMngr = new FileManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            toolTip1.SetToolTip(txtFind, "Select a text from the source and copy here!");
            toolTip1.SetToolTip(txtReplace, "Select a text to replace the above with!");
            toolTip1.SetToolTip(rtxtSource, "You can also write or change the text here manually!");
        }
        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open file for reading as txt!";

            openFileDialog1.Filter = "Text files |*.txt| All files |*.*";
            openFileDialog1.FilterIndex = 0;

            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;  //important
                readDataFromTextFile(fileName);
            }

        }
        List<string> lines;
        private void readDataFromTextFile(string fileName)
        {
            rtxtSource.Clear();
            lstStatus.Items.Clear();
            string errorMsg = string.Empty;
            lines = fileMngr.ReadFromTextFile(fileName, out errorMsg);
            //lblSource.Text = fileName;
            if (lines != null)
            {
                foreach (string line in lines)
                {
                    rtxtSource.AppendText(line + "\n");
                }
                lstStatus.Items.Add("Lines read from the file: " + lines.Count);
            }
            else
                MessageBox.Show(errorMsg);
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load a textfile, select the find and replacement texts and then click me!");
        }


    }

}
