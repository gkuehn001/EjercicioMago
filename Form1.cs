using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioMago
{
    public partial class Form1 : Form
    {
        string originalText;
        SpanishClozeTestGenerator generator;

        public Form1()
        {
            InitializeComponent();
            generator = new SpanishClozeTestGenerator("verbos.sqlite");
            if (!File.Exists("ejemplo_indefinido.txt"))
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "EjercicioMago.ejemplo.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream, Encoding.Default))
                {
                    string result = reader.ReadToEnd();
                    using (var exampleFile = File.Open("ejemplo_indefinido.txt", FileMode.Create))
                    using (StreamWriter writer = new StreamWriter(exampleFile, Encoding.Default))
                    {
                        writer.Write(result);
                        writer.Close();
                    }
                }
            }
            
            var example = File.Open("ejemplo_indefinido.txt", FileMode.Open, FileAccess.Read);
            tbOrigen.Text = example.Name;
            ReadOriginalFromTextFile(example);

            
 
            cbMood.DataSource = new BindingSource(generator.MoodStrings.Values, null);
            cbMood.SelectedItem = generator.MoodStrings[SpanishClozeTestGenerator.EMood.Indicativo];

            cbTense.DataSource = new BindingSource(generator.TenseStrings.Values, null);
            cbTense.SelectedItem = generator.TenseStrings[SpanishClozeTestGenerator.ETense.Preterito];

            UpdateElementEnablesStates();

            CreatePreview();

        }

        private void CreatePreview()
        {
            //string previewText = (originalText.Length > 200) ? $"{originalText.Substring(0, 700)} ..." : originalText;

            //string cloze = generator.CreateClozeFromText(originalText, (string)cbMood.SelectedItem, (string)cbTense.SelectedItem, bShowInfinitive.Checked, bHideWord.Checked ? (double)trackBarSpace.Value / 10.0 : -1.0);
            //rtbPreview.Text = cloze;

            string cloze = generator.CreateRTFClozeFromText(originalText, (string)cbMood.SelectedItem, (string)cbTense.SelectedItem, bShowInfinitive.Checked, bHideWord.Checked ? (double)trackBarSpace.Value / 10.0 : -1.0);
            rtbPreview.Rtf = cloze;
        }

        private void ReadOriginalFromTextFile(Stream fileStream)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileStream, Encoding.Default))
                {
                    originalText = reader.ReadToEnd();
                }
                CreatePreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No puedo abrir el origen. Error original: " + ex.Message);
            }
        }

        private void btnChooseOrigin_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ReadOriginalFromTextFile(openFileDialog1.OpenFile());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No puedo abrir el archivo. Original error: " + ex.Message);
                }
            }
        }

        private void eMoodBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelSpace.Enabled = bHideWord.Checked;
            trackBarSpace.Enabled = bHideWord.Checked;
            CreatePreview();
        }

        private void trackBarSpace_ValueChanged(object sender, EventArgs e)
        {
            CreatePreview();
        }

        private void bShowInfinitive_CheckedChanged(object sender, EventArgs e)
        {
            CreatePreview();
        }

        private void cbTense_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatePreview();
        }

        private void cbMood_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreatePreview();
        }

        private void btnCrearFichero_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            fileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    using (StreamWriter writer = new StreamWriter(fileDialog.OpenFile(), Encoding.Default))
                    {
                        writer.Write(GetTextFromRTF());
                        writer.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No puedo escribier el fichero. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(GetTextFromRTF());
        }

        private string GetTextFromRTF()
        {
            return Regex.Replace(rtbPreview.Text, @"\n", Environment.NewLine);
        }

        private void rbPortapapeles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPortapapeles.Checked)
            {
                if (Clipboard.ContainsText(TextDataFormat.Text))
                {
                    originalText = Clipboard.GetText(TextDataFormat.Text);
                    CreatePreview();
                }
            }
            UpdateElementEnablesStates();
        }

        private void UpdateElementEnablesStates()
        {
            tbOrigen.Enabled = rbFichero.Checked;
            btnChooseOrigin.Enabled = rbFichero.Checked;
            btnCopyFromClipboard.Enabled = rbPortapapeles.Checked;
        }

        private void btnCopyFromClipboard_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                originalText = Clipboard.GetText(TextDataFormat.Text);
                CreatePreview();
            }
        }

        private void rbFichero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFichero.Checked)
            {
                if (tbOrigen.Text != "" && System.IO.File.Exists(tbOrigen.Text))
                {
                    ReadOriginalFromTextFile(System.IO.File.Open(tbOrigen.Text, FileMode.Open, FileAccess.Read));
                }
            }
        }
    }
}
