namespace Assignment4_CS_GUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnLoadFile = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFind = new TextBox();
            txtReplace = new TextBox();
            rtxtSource = new RichTextBox();
            rtxtDest = new RichTextBox();
            lblSource = new Label();
            lstStatus = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            openFileDialog1 = new OpenFileDialog();
            btnOk = new Button();
            toolTip1 = new ToolTip(components);
            saveFileDialog1 = new SaveFileDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadFile
            // 
            btnLoadFile.Location = new Point(41, 22);
            btnLoadFile.Margin = new Padding(5, 4, 5, 4);
            btnLoadFile.Name = "btnLoadFile";
            btnLoadFile.Size = new Size(213, 98);
            btnLoadFile.TabIndex = 0;
            btnLoadFile.Text = "Load File";
            btnLoadFile.UseVisualStyleBackColor = true;
            btnLoadFile.Click += btnLoadFile_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 26);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 30);
            label1.TabIndex = 1;
            label1.Text = "Find";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 74);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(85, 30);
            label2.TabIndex = 2;
            label2.Text = "Replace";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(394, 20);
            txtFind.Margin = new Padding(5, 4, 5, 4);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(772, 35);
            txtFind.TabIndex = 3;
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(391, 74);
            txtReplace.Margin = new Padding(5, 4, 5, 4);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(775, 35);
            txtReplace.TabIndex = 4;
            // 
            // rtxtSource
            // 
            rtxtSource.Location = new Point(15, 40);
            rtxtSource.Margin = new Padding(5, 4, 5, 4);
            rtxtSource.Name = "rtxtSource";
            rtxtSource.Size = new Size(638, 402);
            rtxtSource.TabIndex = 5;
            rtxtSource.Text = "";
            // 
            // rtxtDest
            // 
            rtxtDest.Location = new Point(667, 40);
            rtxtDest.Margin = new Padding(5, 4, 5, 4);
            rtxtDest.Name = "rtxtDest";
            rtxtDest.Size = new Size(638, 402);
            rtxtDest.TabIndex = 5;
            rtxtDest.Text = "";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(41, 142);
            lblSource.Margin = new Padding(5, 0, 5, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(87, 30);
            lblSource.TabIndex = 6;
            lblSource.Text = "Source: ";
            // 
            // lstStatus
            // 
            lstStatus.FormattingEnabled = true;
            lstStatus.ItemHeight = 30;
            lstStatus.Location = new Point(24, 58);
            lstStatus.Margin = new Padding(5, 4, 5, 4);
            lstStatus.Name = "lstStatus";
            lstStatus.Size = new Size(1315, 424);
            lstStatus.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtxtDest);
            groupBox1.Controls.Add(rtxtSource);
            groupBox1.Location = new Point(21, 196);
            groupBox1.Margin = new Padding(5, 4, 5, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5, 4, 5, 4);
            groupBox1.Size = new Size(1349, 474);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "  Editor  ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstStatus);
            groupBox2.Location = new Point(7, 700);
            groupBox2.Margin = new Padding(5, 4, 5, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5, 4, 5, 4);
            groupBox2.Size = new Size(1368, 384);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logbook";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOk
            // 
            btnOk.CausesValidation = false;
            btnOk.Location = new Point(1179, 26);
            btnOk.Margin = new Padding(5, 6, 5, 6);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(204, 94);
            btnOk.TabIndex = 11;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 1124);
            Controls.Add(lblSource);
            Controls.Add(btnOk);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtReplace);
            Controls.Add(txtFind);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadFile);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadFile;
        private Label label1;
        private Label label2;
        private TextBox txtFind;
        private TextBox txtReplace;
        private RichTextBox rtxtSource;
        private RichTextBox rtxtDest;
        private Label lblSource;
        private ListBox lstStatus;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private OpenFileDialog openFileDialog1;
        private Button btnOk;
        private ToolTip toolTip1;
        private SaveFileDialog saveFileDialog1;
    }
}