using System.Diagnostics;
using System.Drawing.Printing;

namespace Bloc_de_Notas
{
    public record TextAction(string oldText, string newText);
    public partial class BlocNotas : Form
    {
        private string ruta;

        private List<TextAction> textHistory = new List<TextAction>();
        private int currentIndex = -1;


        public BlocNotas()
        {
            
            InitializeComponent();
        }

        #region Archivo

        private void bNew_Click(object sender, EventArgs e)
        {
            BlocNotas newBlocNotas = new BlocNotas();
            newBlocNotas.Show();
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            openFileDialog.Title = "Abrir archivo de texto";


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    string contenido = File.ReadAllText(openFileDialog.FileName);
                    textBox1.Text = contenido;
                    ruta = openFileDialog.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ruta))
            {
                //Si no existe el archivo lo crea como si fuera un guardar como 
                bSaveAs_Click(sender, e);
            }
            else
            {
                // Si ya existe, se guarda
                try
                {

                    File.WriteAllText(ruta, textBox1.Text);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bSaveAs_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            saveFileDialog.Title = "Guardar archivo de texto";


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    File.WriteAllText(saveFileDialog.FileName, textBox1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDocument = new PrintDocument();


            printDocument.DocumentName = "Imprimir";
            printDialog.Document = printDocument;
            printDialog.AllowSelection = true;

            if (printDialog.ShowDialog() == DialogResult.OK) { printDocument.Print(); }
        }
        #endregion


        #region Editar

        private void bCopy_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectedText != "")
            {
                Clipboard.SetText(textBox1.SelectedText);
            }
        }

        private void bPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                textBox1.Paste();
            }
        }

        private void bCut_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText = null;
        }
 
        private void bUndo_Click(object sender, EventArgs e)
        {

            if (textBox1.CanUndo == true)
            {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }
        #endregion


        #region Formato

        private void bFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog.Font;
            }
        }
        #endregion

        #region Ver


        /*private void TextBox1_CursorChanged(object sender, EventArgs e)
        {
            
            TextBox textBox = (TextBox)sender;

            
            int index = textBox.SelectionStart;

            int linea = textBox.GetLineFromCharIndex(index) + 1;
            int columna = index - textBox.GetFirstCharIndexFromLine(linea - 1) + 1;

            
            sPosition.Text = "Línea: " + linea.ToString()+ "Columna: " + columna.ToString();
            sPosition.Text = "aaaaaaaaaaa";
        }
        */
        #endregion


        #region Ayuda

        private void bDesc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta aplicacion fue desarrollada por Daniel Paz", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        
        private void bHelp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = "https://stackoverflow.com/questions/58024/open-a-url-from-windows-forms",
                UseShellExecute = true
            };
            Process.Start(processInfo);
        }
        #endregion
    }
}


