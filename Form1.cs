using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Verbose_Extractor
{
    public partial class Form1 : Form
    {

        bool compilationTimeIncluded = false;
        bool DateHeureProcess = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Importation_fichier.ShowDialog();
            if (Importation_fichier.FileName != "")
            {
                Box_Importation.Text = Importation_fichier.FileName;
                Fichier_importe.Visible = true;
                CheckBox_Date_heure.Enabled = true;
                Check_TimeCompileInclude.Enabled = true;
                ProcessFile(Importation_fichier.FileName.ToString());
            }
            else
            {
                CheckBox_Date_heure.Enabled = false;
                Check_TimeCompileInclude.Enabled = false;
                Fichier_importe.Text = "Aucun fichier sélectionné";
                Fichier_importe.Visible = true;
            }
        }

        public void ProcessFile(string filePath)
        {
            
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filePath);
                int startIndex = -1;


                for (int i = lines.Length - 1; i >= 0; i--)
                {
                    if (lines[i].Contains("Object names       Objects/Maxobjs  Memory / Maxmem  Fullness "))
                    {
                        Bouton_Export.Enabled = true;
                        startIndex = i;
                        break;
                    }
                }
                if (startIndex != -1 && startIndex + 51 < lines.Length)
                {
                    richTextBox1.Clear();
                    if (compilationTimeIncluded)
                    {
                        for (int i = startIndex; i < startIndex + 53; i++)
                        {
                            string line = lines[i];
                            richTextBox1.AppendText(line + Environment.NewLine);
                        }

                    }
                    else
                    {
                        for (int i = startIndex; i < startIndex + 52; i++)
                        {
                            string line = lines[i];
                            richTextBox1.AppendText(line + Environment.NewLine);
                        }
                    }
                        
                    
                    if (DateHeureProcess)
                    {
                        richTextBox1.AppendText(Environment.NewLine + "| Date et heure création de ce fichier : " + DateTime.Now.ToString("HH:mm:ss"));
                    }
                }
                else
                {
                    MessageBox.Show("Le fichier ne contient pas suffisamment de lignes après la ligne cible.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du traitement du fichier : " + ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text != "")
                {
                    string path = Importation_fichier.FileName;
                    string fileName = Path.GetFileNameWithoutExtension(path);
                    SaveFileDialog saveFileDialog = new SaveFileDialog();

                    saveFileDialog.Filter = "BSP log [ORIGINAL TYPE] (*.log)|*.log|Fichier log en texte (*.txt)|*.txt|Tout types de fichiers custom (*.*)|*.*";
                    saveFileDialog.Title = "Enregistrer le fichier Verbose";
                    if (DateHeureProcess)
                    {
                        saveFileDialog.FileName = "Verbose-" + fileName + "_" + DateTime.Now.ToString("D");
                    }
                    else
                    {
                        saveFileDialog.FileName = "Verbose-" + fileName;
                    }

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            

                                System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                            MessageBox.Show("Fichier exporté avec succès !");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de l'exportation du fichier : " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Aucun contenu à exporter.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'exportation : " + ex.Message);
            }
        }


        private void Importation_fichier_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Box_Importation_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox_Date_heure.Checked)
            {
                DateHeureProcess = true;
                ProcessFile(Importation_fichier.FileName.ToString());
            }
            else
            {
                DateHeureProcess = false;
                ProcessFile(Importation_fichier.FileName.ToString());
            }
  
        }

        private void Check_TimeCompileInclude_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_TimeCompileInclude.Checked)
            {
                compilationTimeIncluded = true;
                ProcessFile(Importation_fichier.FileName.ToString());
            }
            else
            {
                compilationTimeIncluded = false;
                ProcessFile(Importation_fichier.FileName.ToString());
            }

        }
    }
}
