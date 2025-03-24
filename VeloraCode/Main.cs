using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VeloraCode
{
    public partial class Main: Form
    {
        Editor editor = new Editor();
        public Main()
        {
            InitializeComponent();

            splitContainer1.Panel2.Controls.Add(editor);
            splitContainer1.Panel2.Controls[0].Dock = DockStyle.Fill;

            agregarPestana();
        }

        private void agregarPestana()
        {
            var lastIndex = editor.tabControl1.TabCount - 1;

            FastTextBox fastTextBox = new FastTextBox();
            fastTextBox.Dock = DockStyle.Fill;

            editor.tabControl1.TabPages.Insert(lastIndex, "Sin título");
            editor.tabControl1.SelectedIndex = lastIndex;
            editor.tabControl1.TabPages[lastIndex].UseVisualStyleBackColor = true;

            editor.tabControl1.TabPages[lastIndex].Controls.Add(fastTextBox); //Agregar El Editor de Texto
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            agregarPestana();

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verificar si hay una pestaña activa en el TabControl
            if (editor.tabControl1.SelectedTab != null && editor.tabControl1.SelectedTab.Controls.Count > 0)
            {
                // Obtener el control FastTextBox dentro de la pestaña activa
                FastTextBox fastTextBox = editor.tabControl1.SelectedTab.Controls[0] as FastTextBox;

                // Obtener el FastColoredTextBox dentro de FastTextBox
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();

                // Verificar si hay texto seleccionado
                if (!string.IsNullOrEmpty(fastColoredTextBox.SelectedText))
                {
                    copiarToolStripMenuItem.Enabled = true;
                    cortarToolStripMenuItem.Enabled = true;
                }
                else
                {
                    copiarToolStripMenuItem.Enabled = false;
                    cortarToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                if (!string.IsNullOrEmpty(fastColoredTextBox?.SelectedText))
                {
                    fastColoredTextBox.Cut();
                }
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                if (!string.IsNullOrEmpty(fastColoredTextBox?.SelectedText))
                    fastColoredTextBox.Copy();
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                fastColoredTextBox.Paste();
            }
        }

        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
               
                    fastColoredTextBox.SelectAll();
            }
        }

        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
               
                    fastColoredTextBox.Redo();
            }
        }

        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
             
                    fastColoredTextBox.Undo();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
                openFileDialog.Title = "Abrir Archivo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener la ruta del archivo y leer el contenido
                    string rutaArchivo = openFileDialog.FileName;
                    string contenido = File.ReadAllText(rutaArchivo);

                    // Crear una nueva pestaña
                    var lastIndex = editor.tabControl1.TabCount - 1;
                    FastTextBox fastTextBox = new FastTextBox { Dock = DockStyle.Fill };

                    // Obtener los controles dentro del FastTextBox
                    var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                    var txtRutaArchivo = fastTextBox.Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();

                    if (fastColoredTextBox != null)
                        fastColoredTextBox.Text = contenido; // Asignar el contenido del archivo

                    if (txtRutaArchivo != null)
                        txtRutaArchivo.Text = rutaArchivo; // Mostrar la ruta en el TextBox dentro del UserControl

                    // Agregar la nueva pestaña con el nombre del archivo
                    var nuevaPestaña = new TabPage(Path.GetFileName(rutaArchivo))
                    {
                        UseVisualStyleBackColor = true
                    };
                    nuevaPestaña.Controls.Add(fastTextBox);

                    // Insertar la pestaña y seleccionarla
                    editor.tabControl1.TabPages.Insert(lastIndex, nuevaPestaña);
                    editor.tabControl1.SelectedTab = nuevaPestaña;
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                var txtRutaArchivo = fastTextBox.Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();

                if (fastColoredTextBox != null && txtRutaArchivo != null && !string.IsNullOrWhiteSpace(txtRutaArchivo.Text))
                {
                    try
                    {
                        File.WriteAllText(txtRutaArchivo.Text, fastColoredTextBox.Text);
                        MessageBox.Show("Archivo guardado correctamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No hay una ruta de archivo válida. Use 'Guardar Como...'", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void guardarcomoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var tab = editor.tabControl1.SelectedTab;
            if (tab?.Controls.Count > 0 && tab.Controls[0] is FastTextBox fastTextBox)
            {
                var fastColoredTextBox = fastTextBox.Controls.OfType<FastColoredTextBox>().FirstOrDefault();
                var txtRutaArchivo = fastTextBox.Controls.OfType<System.Windows.Forms.TextBox>().FirstOrDefault();

                if (fastColoredTextBox != null)
                {
                    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                    {
                        saveFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
                        saveFileDialog.Title = "Guardar Archivo Como";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            try
                            {
                                // Guardar el contenido en la nueva ruta
                                File.WriteAllText(saveFileDialog.FileName, fastColoredTextBox.Text);

                                // Actualizar la ruta en el TextBox dentro del UserControl
                                if (txtRutaArchivo != null)
                                {
                                    txtRutaArchivo.Text = saveFileDialog.FileName;
                                }

                                // Cambiar el nombre de la pestaña con el nuevo nombre del archivo
                                tab.Text = Path.GetFileName(saveFileDialog.FileName);

                                MessageBox.Show("Archivo guardado correctamente.", "Guardar Como", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay contenido para guardar.", "Guardar Como", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
