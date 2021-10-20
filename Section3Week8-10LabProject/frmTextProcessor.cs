using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section3Week8_10LabProject
{
    public partial class frmTextProcessor : Form
    {
        public frmTextProcessor()
        {
            InitializeComponent();
        }
        private void frmTextProcessor_Load(object sender, EventArgs e)
        {
            rdoOneWordList.Checked = true;
            cboUnique.Checked = false;
            cboFreq.Enabled = false;
            txtUniqueWordCount.Enabled = false;
            txtAvgUniqueWordLen.Enabled = false;
            txtUniqueTwoWordPairFreq.Enabled = false;
            txtUniqueWordCount.BackColor = System.Drawing.Color.LightGray;
            txtAvgUniqueWordLen.BackColor = System.Drawing.Color.LightGray;
            txtUniqueTwoWordPairFreq.BackColor = System.Drawing.Color.LightGray;
            lblOutput.Text = "";
        }
        private List<string> getWordList()
        {
            List<string> wordList = new List<string>();
            string[] words = txtInput.Text.Split(' ');

            foreach (string word in words)
            {
                wordList.Add(word);
            }
            wordList.Sort();

            return wordList;
        }

        private SortedList<string, int> getUniqueWordList()
        {
            List<string> wordList = getWordList();
            SortedList<string, int> uniqueList = new SortedList<string, int>();
            int freq = 1;

            foreach (string word in wordList)
            {
                if (uniqueList.ContainsKey(word) == true)
                {
                    freq++;
                    uniqueList.Remove(word);
                }
                else
                {
                    freq = 1;
                }
                uniqueList.Add(word, freq);
            }
            return uniqueList;
        }

        private List<string> getWordPairList()
        {
            List<string> wordPairList = new List<string>();
            string[] wordPairs = txtInput.Text.Split(' ');

            for (int i = 0; i < (wordPairs.Length - 1); i++)
            {
                if (!wordPairs[i].Contains("."))
                {
                    wordPairList.Add(wordPairs[i] + " " + wordPairs[i + 1]);
                }
            }
            wordPairList.Sort();
            return wordPairList;
        }

        private SortedList<string, int> getUniqueWordPairList()
        {
            List<string> wordPairList = getWordPairList();
            SortedList<string, int> uniqueWordPairList = new SortedList<string, int>();
            int freq = 1;

            foreach (string wordPair in wordPairList)
            {
                if (uniqueWordPairList.ContainsKey(wordPair) == true)
                {
                    freq++;
                    uniqueWordPairList.Remove(wordPair);
                }
                else
                {
                    freq = 1;
                }
                uniqueWordPairList.Add(wordPair, freq);
            }
            return uniqueWordPairList;
        }

        private void giveOutput(List<string> output)
        {
            for (int i = 0; i < output.Count; i++)
            {
                lblOutput.Text += output[i] + "\n";
            }
        }

        private void giveUniqueOutput(SortedList<string, int> uniqueOutput)
        {
            if (cboFreq.Checked == true)
            {
                foreach (KeyValuePair<string, int> wordAndFrequency in uniqueOutput)
                {
                    lblOutput.Text += wordAndFrequency.Key + " (" + wordAndFrequency.Value + ")\n";
                }
            }
            else
            {
                foreach (KeyValuePair<string, int> word in uniqueOutput)
                {
                    lblOutput.Text += word.Key + "\n";
                }
            }
        }

        private void getLists()
        {
            lblOutput.Text = "";
            if (rdoOneWordList.Checked == true)
            {
                if (cboUnique.Checked == false)
                {
                    List<string> wordList = getWordList();
                    giveOutput(wordList);
                }
                else
                {
                    SortedList<string, int> uniqueWordList = getUniqueWordList();
                    giveUniqueOutput(uniqueWordList);
                }
            }
            else if (rdoTwoWordList.Checked == true)
            {
                if (cboUnique.Checked == false)
                {
                    List<string> wordPairList = getWordPairList();
                    giveOutput(wordPairList);
                }
                else
                {
                    SortedList<string, int> uniqueWordPairList = getUniqueWordPairList();
                    giveUniqueOutput(uniqueWordPairList);
                }
            }
            else
            {
                lblOutput.Text = "An unknown error has occured.";
            }
        }
        private int getSentenceCount(List<string> wordList)
        {
            int sentenceCount = 0;
            foreach (string word in wordList)
            {
                if (word.Contains(".") || word.Contains("?") || word.Contains("!"))
                {
                    sentenceCount++;
                }
            }
            return sentenceCount;
        }
        private int getFreqCount(SortedList<string, int> uniqueWordList)
        {
            int freqCount = 0;
            foreach (KeyValuePair<string, int> wordAndFreq in uniqueWordList)
            {
                if (wordAndFreq.Value > 1)
                {
                    freqCount++;
                }
            }
            return freqCount;
        }
        private int getAvgWordLength()
        {
            if (rdoTwoWordList.Checked == true)
            {
                List<string> wordList = getWordPairList();
                int totalLength = 0;
                foreach (string word in wordList)
                {
                    totalLength += word.Length;
                }
                int avgLength = totalLength / wordList.Count;
                return avgLength;
            }
            else
            {
                List<string> wordList = getWordList();
                int totalLength = 0;
                foreach (string word in wordList)
                {
                    totalLength += word.Length;
                }
                int avgLength = totalLength / wordList.Count;
                return avgLength;
            }

        }
        private int getAvgUniqueWordLength()
        {
            if (rdoTwoWordList.Checked == true)
            {
                SortedList<string, int> uniqueWordList = getUniqueWordPairList();
                int totalUniqueLength = 0;
                foreach (KeyValuePair<string, int> uniqueWord in uniqueWordList)
                {
                    totalUniqueLength += uniqueWord.Key.Length;
                }
                int avgUniqueLength = totalUniqueLength / uniqueWordList.Count;
                return avgUniqueLength;
            }
            else
            {
                SortedList<string, int> uniqueWordList = getUniqueWordList();
                int totalUniqueLength = 0;
                foreach (KeyValuePair<string, int> uniqueWord in uniqueWordList)
                {
                    totalUniqueLength += uniqueWord.Key.Length;
                }
                int avgUniqueLength = totalUniqueLength / uniqueWordList.Count;
                return avgUniqueLength;
            }
            
        }
        private void getStats()
        {
            if (txtSentenceCount.Enabled)
            txtSentenceCount.Text = getSentenceCount(getWordList()).ToString();
            if (txtWordCount.Enabled)
            {
                if (rdoOneWordList.Checked == true)
                    txtWordCount.Text = getWordList().Count.ToString();
                else
                    txtWordCount.Text = getWordPairList().Count.ToString();
            }
            if (txtUniqueWordCount.Enabled)
            {
                if (rdoOneWordList.Checked == true)
                    txtUniqueWordCount.Text = getUniqueWordList().Count.ToString();
                else
                    txtUniqueWordCount.Text = getUniqueWordPairList().Count.ToString();
            }
            if (txtUniqueWordFreq.Enabled)
            txtUniqueWordFreq.Text = getFreqCount(getUniqueWordList()).ToString();
            if (txtUniqueTwoWordPairFreq.Enabled)
            txtUniqueTwoWordPairFreq.Text = getFreqCount(getUniqueWordPairList()).ToString();
            if (txtCharCount.Enabled)
            txtCharCount.Text = txtInput.Text.Length.ToString();
            if (txtAvgWordLen.Enabled)
            txtAvgWordLen.Text = getAvgWordLength().ToString();
            if (txtAvgUniqueWordLen.Enabled)
            txtAvgUniqueWordLen.Text = getAvgUniqueWordLength().ToString();
        }

        private void brnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblOutput.Text = "";
            txtWordCount.Text = "";
            txtUniqueWordCount.Text = "";
            txtCharCount.Text = "";
            txtSentenceCount.Text = "";
            txtAvgWordLen.Text = "";
            txtAvgUniqueWordLen.Text = "";
            txtUniqueWordFreq.Text = "";
            txtUniqueTwoWordPairFreq.Text = "";
            rdoOneWordList.Checked = true;
            cboFreq.Checked = false;
            cboFreq.Enabled = false;
            cboUnique.Checked = false;
        }

        private void btnLists_Click(object sender, EventArgs e)
        {
            txtWordCount.Text = "";
            txtUniqueWordCount.Text = "";
            txtCharCount.Text = "";
            txtSentenceCount.Text = "";
            txtAvgWordLen.Text = "";
            txtAvgUniqueWordLen.Text = "";
            txtUniqueWordFreq.Text = "";
            txtUniqueTwoWordPairFreq.Text = "";
            lblOutput.Text = "";
            if (txtInput.Text == "")
                lblOutput.Text = "Please enter text to be processed before attempting to generate lists.";
            else
            {
                getLists();
            }
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            txtWordCount.Text = "";
            txtUniqueWordCount.Text = "";
            txtCharCount.Text = "";
            txtSentenceCount.Text = "";
            txtAvgWordLen.Text = "";
            txtAvgUniqueWordLen.Text = "";
            txtUniqueWordFreq.Text = "";
            txtUniqueTwoWordPairFreq.Text = "";
            lblOutput.Text = "";
            if (txtInput.Text == "")
                lblOutput.Text = "Please enter text to be processed before attempting to process text statistics";
            else
            {
                getLists();
                getStats();
            }
            
        }

        private void cboUnique_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            if (cboUnique.Checked)
            {
                cboFreq.Enabled = true;
                txtUniqueWordCount.Enabled = true;
                txtAvgUniqueWordLen.Enabled = true;
                txtWordCount.Enabled = false;
                txtAvgWordLen.Enabled = false;
                txtUniqueWordCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtAvgUniqueWordLen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtWordCount.BackColor = System.Drawing.Color.LightGray;
                txtAvgWordLen.BackColor = System.Drawing.Color.LightGray;
                txtWordCount.Text = "";
                txtAvgWordLen.Text = "";
            }
            else
            {
                cboFreq.Checked = false;
                cboFreq.Enabled = false;
                txtUniqueWordCount.Enabled = false;
                txtAvgUniqueWordLen.Enabled = false;
                txtWordCount.Enabled = true;
                txtAvgWordLen.Enabled = true;
                txtUniqueWordCount.BackColor = System.Drawing.Color.LightGray;
                txtAvgUniqueWordLen.BackColor = System.Drawing.Color.LightGray;
                txtWordCount.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtAvgWordLen.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtUniqueWordCount.Text = "";
                txtAvgUniqueWordLen.Text = "";
            }
            if (txtCharCount.Text == "")
            {

            }
            else
            {
                getLists();
                getStats();
            }
        }

        private void rdoOneWordList_CheckedChanged(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            if (rdoOneWordList.Checked == true)
            {
                txtUniqueWordFreq.Enabled = true;
                txtUniqueTwoWordPairFreq.Enabled = false;
                txtUniqueWordFreq.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtUniqueTwoWordPairFreq.BackColor = System.Drawing.Color.LightGray;
                txtUniqueTwoWordPairFreq.Text = "";
            }
            else if (rdoTwoWordList.Checked == true)
            {
                txtUniqueWordFreq.Enabled = false;
                txtUniqueTwoWordPairFreq.Enabled = true;
                txtUniqueWordFreq.BackColor = System.Drawing.Color.LightGray;
                txtUniqueTwoWordPairFreq.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                txtUniqueWordFreq.Text = "";
            }
            else
            {
                lblOutput.Text = "An unknown error has occured.";
            }
            if (txtCharCount.Text == "")
            {
                
            }
            else
            {
                getLists();
                getStats();
            }
        }

        private void cboFreq_CheckedChanged_1(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            if (txtCharCount.Text == "")
            {

            }
            else
            {
                getLists();
            }
        }
    }
}
