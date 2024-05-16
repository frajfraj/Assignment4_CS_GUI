using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace Assignment4_CS_GUI
{
    public partial class MainForm : Form
    {
        private FileManager fileMngr = new FileManager();
        private BoundedBuffer buffer = new BoundedBuffer(20); // Create a shared buffer with a maximum capacity of 20
        private Modifier modifier;
        private Reader reader;
        private List<string> modifiedLines = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
            modifier = new Modifier(buffer);
            reader = new Reader(buffer, modifiedLines);

            txtFind.TextChanged += TxtFind_TextChanged;
        }

        private void TxtFind_TextChanged(object sender, EventArgs e)
        {
            string findText = txtFind.Text;
            HighlightText(findText);
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

            string findText = txtFind.Text;
            string replaceText = txtReplace.Text;

            // Modify the text in the buffer
            modifier.ModifyBuffer(findText, replaceText);

            // Read modified text from the buffer
            reader.ReadFromBuffer();

            // Display modified text in the RichTextBox
            rtxtDest.Clear();
            foreach (string line in modifiedLines)
            {
                rtxtDest.AppendText(line + "\n");
            }
        }

        private void HighlightText(string searchText)
        {
            // Clear existing highlighting
            rtxtSource.SelectAll();
            rtxtSource.SelectionBackColor = rtxtSource.BackColor;

            // Start highlighting anew
            int startIndex = 0;
            while (startIndex < rtxtSource.TextLength)
            {
                int index = rtxtSource.Find(searchText, startIndex, RichTextBoxFinds.None);
                if (index != -1)
                {
                    rtxtSource.SelectionStart = index;
                    rtxtSource.SelectionLength = searchText.Length;
                    rtxtSource.SelectionBackColor = Color.Yellow; // You can set any color you want for highlighting
                    startIndex = index + searchText.Length;
                }
                else
                {
                    break;
                }
            }

            rtxtSource.SelectionStart = rtxtSource.TextLength;
        }
    }
}
