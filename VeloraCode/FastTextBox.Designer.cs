namespace VeloraCode
{
    partial class FastTextBox
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastTextBox));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextProce = new FastColoredTextBoxNS.FastColoredTextBox();
            this.MenuEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertarHoraYFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TextProce)).BeginInit();
            this.MenuEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(749, 20);
            this.textBox1.TabIndex = 0;
            // 
            // TextProce
            // 
            this.TextProce.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.TextProce.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.TextProce.BackBrush = null;
            this.TextProce.CharHeight = 14;
            this.TextProce.CharWidth = 8;
            this.TextProce.ContextMenuStrip = this.MenuEditor;
            this.TextProce.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextProce.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextProce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextProce.IsReplaceMode = false;
            this.TextProce.Location = new System.Drawing.Point(0, 20);
            this.TextProce.Name = "TextProce";
            this.TextProce.Paddings = new System.Windows.Forms.Padding(0);
            this.TextProce.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.TextProce.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("TextProce.ServiceColors")));
            this.TextProce.Size = new System.Drawing.Size(749, 541);
            this.TextProce.TabIndex = 1;
            this.TextProce.Zoom = 100;
            // 
            // MenuEditor
            // 
            this.MenuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator1,
            this.seleccionarTodoToolStripMenuItem,
            this.insertarHoraYFechaToolStripMenuItem});
            this.MenuEditor.Name = "MenuEditor";
            this.MenuEditor.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuEditor.Size = new System.Drawing.Size(182, 120);
            this.MenuEditor.Opening += new System.ComponentModel.CancelEventHandler(this.MenuEditor_Opening);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // insertarHoraYFechaToolStripMenuItem
            // 
            this.insertarHoraYFechaToolStripMenuItem.Name = "insertarHoraYFechaToolStripMenuItem";
            this.insertarHoraYFechaToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.insertarHoraYFechaToolStripMenuItem.Text = "Insertar hora y fecha";
            this.insertarHoraYFechaToolStripMenuItem.Click += new System.EventHandler(this.insertarHoraYFechaToolStripMenuItem_Click);
            // 
            // FastTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextProce);
            this.Controls.Add(this.textBox1);
            this.Name = "FastTextBox";
            this.Size = new System.Drawing.Size(749, 561);
            ((System.ComponentModel.ISupportInitialize)(this.TextProce)).EndInit();
            this.MenuEditor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FastColoredTextBoxNS.FastColoredTextBox TextProce;
        private System.Windows.Forms.ContextMenuStrip MenuEditor;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertarHoraYFechaToolStripMenuItem;
        public System.Windows.Forms.TextBox textBox1;
    }
}
