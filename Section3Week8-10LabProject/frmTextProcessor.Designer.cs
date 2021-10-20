
namespace Section3Week8_10LabProject
{
    partial class frmTextProcessor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtAvgUniqueWordLen = new System.Windows.Forms.TextBox();
            this.txtUniqueWordFreq = new System.Windows.Forms.TextBox();
            this.txtUniqueTwoWordPairFreq = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtAvgWordLen = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.txtUniqueWordCount = new System.Windows.Forms.TextBox();
            this.txtSentenceCount = new System.Windows.Forms.TextBox();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblUniqueWordCount = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblAvgWordLen = new System.Windows.Forms.Label();
            this.lblAvgUniqueWordLen = new System.Windows.Forms.Label();
            this.lblUniqueWordFreq = new System.Windows.Forms.Label();
            this.lblUniqueTwoWordPairFreq = new System.Windows.Forms.Label();
            this.rdoOneWordList = new System.Windows.Forms.RadioButton();
            this.rdoTwoWordList = new System.Windows.Forms.RadioButton();
            this.gboWordType = new System.Windows.Forms.GroupBox();
            this.cboUnique = new System.Windows.Forms.CheckBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnLists = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.brnExit = new System.Windows.Forms.Button();
            this.lblInputHeader = new System.Windows.Forms.Label();
            this.lblOutputHeader = new System.Windows.Forms.Label();
            this.cboFreq = new System.Windows.Forms.CheckBox();
            this.gboUniqueLists = new System.Windows.Forms.GroupBox();
            this.gboStats = new System.Windows.Forms.GroupBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gboWordType.SuspendLayout();
            this.gboUniqueLists.SuspendLayout();
            this.gboStats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(21, 38);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(578, 190);
            this.txtInput.TabIndex = 0;
            // 
            // txtAvgUniqueWordLen
            // 
            this.txtAvgUniqueWordLen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAvgUniqueWordLen.Location = new System.Drawing.Point(174, 91);
            this.txtAvgUniqueWordLen.Name = "txtAvgUniqueWordLen";
            this.txtAvgUniqueWordLen.ReadOnly = true;
            this.txtAvgUniqueWordLen.Size = new System.Drawing.Size(122, 22);
            this.txtAvgUniqueWordLen.TabIndex = 2;
            this.txtAvgUniqueWordLen.TabStop = false;
            // 
            // txtUniqueWordFreq
            // 
            this.txtUniqueWordFreq.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUniqueWordFreq.Location = new System.Drawing.Point(30, 187);
            this.txtUniqueWordFreq.Name = "txtUniqueWordFreq";
            this.txtUniqueWordFreq.ReadOnly = true;
            this.txtUniqueWordFreq.Size = new System.Drawing.Size(122, 22);
            this.txtUniqueWordFreq.TabIndex = 3;
            this.txtUniqueWordFreq.TabStop = false;
            // 
            // txtUniqueTwoWordPairFreq
            // 
            this.txtUniqueTwoWordPairFreq.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUniqueTwoWordPairFreq.Location = new System.Drawing.Point(174, 187);
            this.txtUniqueTwoWordPairFreq.Name = "txtUniqueTwoWordPairFreq";
            this.txtUniqueTwoWordPairFreq.ReadOnly = true;
            this.txtUniqueTwoWordPairFreq.Size = new System.Drawing.Size(122, 22);
            this.txtUniqueTwoWordPairFreq.TabIndex = 4;
            this.txtUniqueTwoWordPairFreq.TabStop = false;
            // 
            // txtWordCount
            // 
            this.txtWordCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtWordCount.Location = new System.Drawing.Point(30, 139);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.ReadOnly = true;
            this.txtWordCount.Size = new System.Drawing.Size(122, 22);
            this.txtWordCount.TabIndex = 5;
            this.txtWordCount.TabStop = false;
            // 
            // txtAvgWordLen
            // 
            this.txtAvgWordLen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtAvgWordLen.Location = new System.Drawing.Point(30, 91);
            this.txtAvgWordLen.Name = "txtAvgWordLen";
            this.txtAvgWordLen.ReadOnly = true;
            this.txtAvgWordLen.Size = new System.Drawing.Size(122, 22);
            this.txtAvgWordLen.TabIndex = 6;
            this.txtAvgWordLen.TabStop = false;
            // 
            // txtCharCount
            // 
            this.txtCharCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtCharCount.Location = new System.Drawing.Point(30, 43);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.ReadOnly = true;
            this.txtCharCount.Size = new System.Drawing.Size(122, 22);
            this.txtCharCount.TabIndex = 7;
            this.txtCharCount.TabStop = false;
            // 
            // txtUniqueWordCount
            // 
            this.txtUniqueWordCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtUniqueWordCount.Location = new System.Drawing.Point(174, 140);
            this.txtUniqueWordCount.Name = "txtUniqueWordCount";
            this.txtUniqueWordCount.ReadOnly = true;
            this.txtUniqueWordCount.Size = new System.Drawing.Size(122, 22);
            this.txtUniqueWordCount.TabIndex = 8;
            this.txtUniqueWordCount.TabStop = false;
            // 
            // txtSentenceCount
            // 
            this.txtSentenceCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.txtSentenceCount.Location = new System.Drawing.Point(174, 43);
            this.txtSentenceCount.Name = "txtSentenceCount";
            this.txtSentenceCount.ReadOnly = true;
            this.txtSentenceCount.Size = new System.Drawing.Size(122, 22);
            this.txtSentenceCount.TabIndex = 9;
            this.txtSentenceCount.TabStop = false;
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Location = new System.Drawing.Point(27, 122);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(73, 15);
            this.lblWordCount.TabIndex = 10;
            this.lblWordCount.Text = "Word Count";
            // 
            // lblUniqueWordCount
            // 
            this.lblUniqueWordCount.AutoSize = true;
            this.lblUniqueWordCount.Location = new System.Drawing.Point(171, 122);
            this.lblUniqueWordCount.Name = "lblUniqueWordCount";
            this.lblUniqueWordCount.Size = new System.Drawing.Size(115, 15);
            this.lblUniqueWordCount.TabIndex = 11;
            this.lblUniqueWordCount.Text = "Unique Word Count";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Location = new System.Drawing.Point(27, 25);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(94, 15);
            this.lblCharCount.TabIndex = 12;
            this.lblCharCount.Text = "Character Count";
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.AutoSize = true;
            this.lblSentenceCount.Location = new System.Drawing.Point(171, 26);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(95, 15);
            this.lblSentenceCount.TabIndex = 13;
            this.lblSentenceCount.Text = "Sentence Count ";
            // 
            // lblAvgWordLen
            // 
            this.lblAvgWordLen.AutoSize = true;
            this.lblAvgWordLen.Location = new System.Drawing.Point(26, 74);
            this.lblAvgWordLen.Name = "lblAvgWordLen";
            this.lblAvgWordLen.Size = new System.Drawing.Size(126, 15);
            this.lblAvgWordLen.TabIndex = 14;
            this.lblAvgWordLen.Text = "Average Word Length";
            // 
            // lblAvgUniqueWordLen
            // 
            this.lblAvgUniqueWordLen.AutoSize = true;
            this.lblAvgUniqueWordLen.Location = new System.Drawing.Point(170, 74);
            this.lblAvgUniqueWordLen.Name = "lblAvgUniqueWordLen";
            this.lblAvgUniqueWordLen.Size = new System.Drawing.Size(168, 15);
            this.lblAvgUniqueWordLen.TabIndex = 15;
            this.lblAvgUniqueWordLen.Text = "Average Unique Word Length";
            // 
            // lblUniqueWordFreq
            // 
            this.lblUniqueWordFreq.AutoSize = true;
            this.lblUniqueWordFreq.Location = new System.Drawing.Point(27, 170);
            this.lblUniqueWordFreq.Name = "lblUniqueWordFreq";
            this.lblUniqueWordFreq.Size = new System.Drawing.Size(139, 15);
            this.lblUniqueWordFreq.TabIndex = 16;
            this.lblUniqueWordFreq.Text = "Unique Word Frequency";
            // 
            // lblUniqueTwoWordPairFreq
            // 
            this.lblUniqueTwoWordPairFreq.AutoSize = true;
            this.lblUniqueTwoWordPairFreq.Location = new System.Drawing.Point(170, 170);
            this.lblUniqueTwoWordPairFreq.Name = "lblUniqueTwoWordPairFreq";
            this.lblUniqueTwoWordPairFreq.Size = new System.Drawing.Size(189, 15);
            this.lblUniqueTwoWordPairFreq.TabIndex = 17;
            this.lblUniqueTwoWordPairFreq.Text = "Unique Two-Word Pair Frequency";
            // 
            // rdoOneWordList
            // 
            this.rdoOneWordList.AutoSize = true;
            this.rdoOneWordList.Location = new System.Drawing.Point(29, 26);
            this.rdoOneWordList.Name = "rdoOneWordList";
            this.rdoOneWordList.Size = new System.Drawing.Size(111, 19);
            this.rdoOneWordList.TabIndex = 18;
            this.rdoOneWordList.Text = "Show Word List";
            this.rdoOneWordList.UseVisualStyleBackColor = true;
            this.rdoOneWordList.CheckedChanged += new System.EventHandler(this.rdoOneWordList_CheckedChanged);
            // 
            // rdoTwoWordList
            // 
            this.rdoTwoWordList.AutoSize = true;
            this.rdoTwoWordList.Location = new System.Drawing.Point(29, 70);
            this.rdoTwoWordList.Name = "rdoTwoWordList";
            this.rdoTwoWordList.Size = new System.Drawing.Size(161, 19);
            this.rdoTwoWordList.TabIndex = 19;
            this.rdoTwoWordList.Text = "Show Two-Word Pair List";
            this.rdoTwoWordList.UseVisualStyleBackColor = true;
            // 
            // gboWordType
            // 
            this.gboWordType.Controls.Add(this.rdoTwoWordList);
            this.gboWordType.Controls.Add(this.rdoOneWordList);
            this.gboWordType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboWordType.Location = new System.Drawing.Point(21, 249);
            this.gboWordType.Name = "gboWordType";
            this.gboWordType.Size = new System.Drawing.Size(200, 111);
            this.gboWordType.TabIndex = 20;
            this.gboWordType.TabStop = false;
            this.gboWordType.Text = "Word List Type";
            // 
            // cboUnique
            // 
            this.cboUnique.AutoSize = true;
            this.cboUnique.Location = new System.Drawing.Point(29, 30);
            this.cboUnique.Name = "cboUnique";
            this.cboUnique.Size = new System.Drawing.Size(88, 19);
            this.cboUnique.TabIndex = 21;
            this.cboUnique.TabStop = false;
            this.cboUnique.Text = "Unique List";
            this.cboUnique.UseVisualStyleBackColor = true;
            this.cboUnique.CheckedChanged += new System.EventHandler(this.cboUnique_CheckedChanged);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.Thistle;
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.Location = new System.Drawing.Point(21, 487);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(80, 25);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnLists
            // 
            this.btnLists.BackColor = System.Drawing.Color.Thistle;
            this.btnLists.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLists.Location = new System.Drawing.Point(186, 487);
            this.btnLists.Name = "btnLists";
            this.btnLists.Size = new System.Drawing.Size(80, 25);
            this.btnLists.TabIndex = 2;
            this.btnLists.Text = "Create Lists";
            this.btnLists.UseVisualStyleBackColor = false;
            this.btnLists.Click += new System.EventHandler(this.btnLists_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Thistle;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(351, 487);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 25);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // brnExit
            // 
            this.brnExit.BackColor = System.Drawing.Color.Thistle;
            this.brnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.brnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExit.Location = new System.Drawing.Point(519, 487);
            this.brnExit.Name = "brnExit";
            this.brnExit.Size = new System.Drawing.Size(80, 25);
            this.brnExit.TabIndex = 4;
            this.brnExit.Text = "Exit";
            this.brnExit.UseVisualStyleBackColor = false;
            this.brnExit.Click += new System.EventHandler(this.brnExit_Click);
            // 
            // lblInputHeader
            // 
            this.lblInputHeader.AutoSize = true;
            this.lblInputHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputHeader.Location = new System.Drawing.Point(18, 19);
            this.lblInputHeader.Name = "lblInputHeader";
            this.lblInputHeader.Size = new System.Drawing.Size(36, 15);
            this.lblInputHeader.TabIndex = 26;
            this.lblInputHeader.Text = "Input";
            // 
            // lblOutputHeader
            // 
            this.lblOutputHeader.AutoSize = true;
            this.lblOutputHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputHeader.Location = new System.Drawing.Point(624, 19);
            this.lblOutputHeader.Name = "lblOutputHeader";
            this.lblOutputHeader.Size = new System.Drawing.Size(45, 15);
            this.lblOutputHeader.TabIndex = 27;
            this.lblOutputHeader.Text = "Output";
            // 
            // cboFreq
            // 
            this.cboFreq.AutoSize = true;
            this.cboFreq.Location = new System.Drawing.Point(29, 68);
            this.cboFreq.Name = "cboFreq";
            this.cboFreq.Size = new System.Drawing.Size(83, 19);
            this.cboFreq.TabIndex = 28;
            this.cboFreq.TabStop = false;
            this.cboFreq.Text = "Frequency";
            this.cboFreq.UseVisualStyleBackColor = true;
            this.cboFreq.CheckedChanged += new System.EventHandler(this.cboFreq_CheckedChanged_1);
            // 
            // gboUniqueLists
            // 
            this.gboUniqueLists.Controls.Add(this.cboFreq);
            this.gboUniqueLists.Controls.Add(this.cboUnique);
            this.gboUniqueLists.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboUniqueLists.Location = new System.Drawing.Point(21, 371);
            this.gboUniqueLists.Name = "gboUniqueLists";
            this.gboUniqueLists.Size = new System.Drawing.Size(200, 100);
            this.gboUniqueLists.TabIndex = 21;
            this.gboUniqueLists.TabStop = false;
            this.gboUniqueLists.Text = "Unique or Non-Unique Lists";
            // 
            // gboStats
            // 
            this.gboStats.Controls.Add(this.lblCharCount);
            this.gboStats.Controls.Add(this.lblSentenceCount);
            this.gboStats.Controls.Add(this.lblUniqueTwoWordPairFreq);
            this.gboStats.Controls.Add(this.lblUniqueWordFreq);
            this.gboStats.Controls.Add(this.lblAvgUniqueWordLen);
            this.gboStats.Controls.Add(this.lblUniqueWordCount);
            this.gboStats.Controls.Add(this.lblAvgWordLen);
            this.gboStats.Controls.Add(this.lblWordCount);
            this.gboStats.Controls.Add(this.txtAvgUniqueWordLen);
            this.gboStats.Controls.Add(this.txtUniqueWordFreq);
            this.gboStats.Controls.Add(this.txtUniqueTwoWordPairFreq);
            this.gboStats.Controls.Add(this.txtWordCount);
            this.gboStats.Controls.Add(this.txtAvgWordLen);
            this.gboStats.Controls.Add(this.txtCharCount);
            this.gboStats.Controls.Add(this.txtUniqueWordCount);
            this.gboStats.Controls.Add(this.txtSentenceCount);
            this.gboStats.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboStats.Location = new System.Drawing.Point(227, 249);
            this.gboStats.Name = "gboStats";
            this.gboStats.Size = new System.Drawing.Size(370, 222);
            this.gboStats.TabIndex = 28;
            this.gboStats.TabStop = false;
            this.gboStats.Text = "Statistics";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblOutput.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(0, 0);
            this.lblOutput.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.Controls.Add(this.lblOutput);
            this.panel1.Location = new System.Drawing.Point(627, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 474);
            this.panel1.TabIndex = 30;
            // 
            // frmTextProcessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.CancelButton = this.brnExit;
            this.ClientSize = new System.Drawing.Size(804, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gboStats);
            this.Controls.Add(this.gboUniqueLists);
            this.Controls.Add(this.lblOutputHeader);
            this.Controls.Add(this.lblInputHeader);
            this.Controls.Add(this.brnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnLists);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gboWordType);
            this.Controls.Add(this.txtInput);
            this.Name = "frmTextProcessor";
            this.Text = "Text Processor";
            this.Load += new System.EventHandler(this.frmTextProcessor_Load);
            this.gboWordType.ResumeLayout(false);
            this.gboWordType.PerformLayout();
            this.gboUniqueLists.ResumeLayout(false);
            this.gboUniqueLists.PerformLayout();
            this.gboStats.ResumeLayout(false);
            this.gboStats.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtAvgUniqueWordLen;
        private System.Windows.Forms.TextBox txtUniqueWordFreq;
        private System.Windows.Forms.TextBox txtUniqueTwoWordPairFreq;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtAvgWordLen;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.TextBox txtUniqueWordCount;
        private System.Windows.Forms.TextBox txtSentenceCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblUniqueWordCount;
        private System.Windows.Forms.Label lblCharCount;
        private System.Windows.Forms.Label lblSentenceCount;
        private System.Windows.Forms.Label lblAvgWordLen;
        private System.Windows.Forms.Label lblAvgUniqueWordLen;
        private System.Windows.Forms.Label lblUniqueWordFreq;
        private System.Windows.Forms.Label lblUniqueTwoWordPairFreq;
        private System.Windows.Forms.RadioButton rdoOneWordList;
        private System.Windows.Forms.RadioButton rdoTwoWordList;
        private System.Windows.Forms.GroupBox gboWordType;
        private System.Windows.Forms.CheckBox cboUnique;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnLists;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button brnExit;
        private System.Windows.Forms.Label lblInputHeader;
        private System.Windows.Forms.Label lblOutputHeader;
        private System.Windows.Forms.CheckBox cboFreq;
        private System.Windows.Forms.GroupBox gboUniqueLists;
        private System.Windows.Forms.GroupBox gboStats;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Panel panel1;
    }
}

