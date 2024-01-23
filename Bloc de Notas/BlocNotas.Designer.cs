namespace Bloc_de_Notas
{
    partial class BlocNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlocNotas));
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            bNew = new ToolStripMenuItem();
            bOpen = new ToolStripMenuItem();
            bSave = new ToolStripMenuItem();
            bSaveAs = new ToolStripMenuItem();
            bPrint = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            bUndo = new ToolStripMenuItem();
            bCopy = new ToolStripMenuItem();
            bPaste = new ToolStripMenuItem();
            bCut = new ToolStripMenuItem();
            bDelete = new ToolStripMenuItem();
            formatoToolStripMenuItem = new ToolStripMenuItem();
            bFont = new ToolStripMenuItem();
            verToolStripMenuItem = new ToolStripMenuItem();
            bStatebar = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            bDesc = new ToolStripMenuItem();
            bHelp = new ToolStripMenuItem();
            textBox1 = new TextBox();
            statusStrip1 = new StatusStrip();
            sPosition = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, editarToolStripMenuItem, formatoToolStripMenuItem, verToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bNew, bOpen, bSave, bSaveAs, bPrint });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(73, 24);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // bNew
            // 
            bNew.AccessibleName = "bNew";
            bNew.Name = "bNew";
            bNew.ShortcutKeys = Keys.Control | Keys.N;
            bNew.Size = new Size(199, 26);
            bNew.Text = "Nuevo";
            bNew.Click += bNew_Click;
            // 
            // bOpen
            // 
            bOpen.AccessibleName = "bOpen";
            bOpen.Name = "bOpen";
            bOpen.ShortcutKeys = Keys.Control | Keys.A;
            bOpen.Size = new Size(199, 26);
            bOpen.Text = "Abrir";
            bOpen.Click += bOpen_Click;
            // 
            // bSave
            // 
            bSave.AccessibleName = "bSave";
            bSave.Name = "bSave";
            bSave.ShortcutKeys = Keys.Control | Keys.S;
            bSave.Size = new Size(199, 26);
            bSave.Text = "Guardar";
            bSave.Click += bSave_Click;
            // 
            // bSaveAs
            // 
            bSaveAs.AccessibleName = "bSaveAs";
            bSaveAs.Name = "bSaveAs";
            bSaveAs.Size = new Size(199, 26);
            bSaveAs.Text = "Guardar como";
            bSaveAs.Click += bSaveAs_Click;
            // 
            // bPrint
            // 
            bPrint.AccessibleName = "bPrint";
            bPrint.Name = "bPrint";
            bPrint.ShortcutKeys = Keys.Control | Keys.P;
            bPrint.Size = new Size(199, 26);
            bPrint.Text = "Imprimir";
            bPrint.Click += bPrint_Click;
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bUndo, bCopy, bPaste, bCut, bDelete });
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(62, 24);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // bUndo
            // 
            bUndo.AccessibleName = "bUndo";
            bUndo.Name = "bUndo";
            bUndo.ShortcutKeys = Keys.Control | Keys.Z;
            bUndo.Size = new Size(204, 26);
            bUndo.Text = "Deshacer";
            bUndo.Click += bUndo_Click;
            // 
            // bCopy
            // 
            bCopy.AccessibleName = "bCopy";
            bCopy.Name = "bCopy";
            bCopy.ShortcutKeys = Keys.Control | Keys.C;
            bCopy.Size = new Size(204, 26);
            bCopy.Text = "Copiar";
            bCopy.Click += bCopy_Click;
            // 
            // bPaste
            // 
            bPaste.AccessibleName = "bPaste";
            bPaste.Name = "bPaste";
            bPaste.ShortcutKeys = Keys.Control | Keys.V;
            bPaste.Size = new Size(204, 26);
            bPaste.Text = "Pegar";
            bPaste.Click += bPaste_Click;
            // 
            // bCut
            // 
            bCut.AccessibleName = "bCut";
            bCut.Name = "bCut";
            bCut.ShortcutKeys = Keys.Control | Keys.X;
            bCut.Size = new Size(204, 26);
            bCut.Text = "Cortar";
            bCut.Click += bCut_Click;
            // 
            // bDelete
            // 
            bDelete.AccessibleName = "bDelete";
            bDelete.Name = "bDelete";
            bDelete.ShortcutKeys = Keys.Control | Keys.D;
            bDelete.Size = new Size(204, 26);
            bDelete.Text = "Eliminar";
            bDelete.Click += bDelete_Click;
            // 
            // formatoToolStripMenuItem
            // 
            formatoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bFont });
            formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            formatoToolStripMenuItem.Size = new Size(79, 24);
            formatoToolStripMenuItem.Text = "Formato";
            // 
            // bFont
            // 
            bFont.AccessibleName = "bFont";
            bFont.Name = "bFont";
            bFont.Size = new Size(136, 26);
            bFont.Text = "Fuente";
            bFont.Click += bFont_Click;
            // 
            // verToolStripMenuItem
            // 
            verToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bStatebar });
            verToolStripMenuItem.Name = "verToolStripMenuItem";
            verToolStripMenuItem.Size = new Size(44, 24);
            verToolStripMenuItem.Text = "Ver";
            // 
            // bStatebar
            // 
            bStatebar.AccessibleName = "bStateBar";
            bStatebar.CheckOnClick = true;
            bStatebar.Name = "bStatebar";
            bStatebar.Size = new Size(224, 26);
            bStatebar.Text = "Barra de estado";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bDesc, bHelp });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(65, 24);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // bDesc
            // 
            bDesc.AccessibleName = "bDesc";
            bDesc.Name = "bDesc";
            bDesc.Size = new Size(158, 26);
            bDesc.Text = "Acerca de";
            bDesc.Click += bDesc_Click;
            // 
            // bHelp
            // 
            bHelp.AccessibleName = "bHelp";
            bHelp.Name = "bHelp";
            bHelp.Size = new Size(158, 26);
            bHelp.Text = "Ver ayuda";
            bHelp.Click += bHelp_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 28);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(1182, 725);
            textBox1.TabIndex = 1;
            //textBox1.CursorChanged += TextBox1_CursorChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { sPosition });
            statusStrip1.Location = new Point(0, 731);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // sPosition
            // 
            sPosition.Name = "sPosition";
            sPosition.Size = new Size(0, 16);
            // 
            // BlocNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(statusStrip1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "BlocNotas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bloc de notas";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem bNew;
        private ToolStripMenuItem bOpen;
        private ToolStripMenuItem bSave;
        private ToolStripMenuItem bSaveAs;
        private ToolStripMenuItem bPrint;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem bUndo;
        private ToolStripMenuItem bCopy;
        private ToolStripMenuItem bPaste;
        private ToolStripMenuItem bCut;
        private ToolStripMenuItem bDelete;
        private ToolStripMenuItem formatoToolStripMenuItem;
        private ToolStripMenuItem bFont;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem bStatebar;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem bDesc;
        private ToolStripMenuItem bHelp;
        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel sPosition;
    }
}
