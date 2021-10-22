using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
namespace _56EditorTexto
{
    public partial class FormEditorTexto : Form
    {
        public FormEditorTexto()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string fileContent = string.Empty;
            string filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
            rtbEditor.Text += fileContent;
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            StreamWriter archivo = null;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Este es el path
                    MessageBox.Show(saveFileDialog1.FileName);
                    archivo = new StreamWriter(saveFileDialog1.FileName);
                    archivo.WriteLine(rtbEditor.Text);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                archivo.Close();
            }
        }

        private void FormEditorTexto_Load(object sender, EventArgs e)
        {
            
        }
    }
}
