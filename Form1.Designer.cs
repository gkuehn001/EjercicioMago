namespace EjercicioMago
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChooseSource = new System.Windows.Forms.OpenFileDialog();
            this.tabControlParaCompletar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCopyFromClipboard = new System.Windows.Forms.Button();
            this.rbPortapapeles = new System.Windows.Forms.RadioButton();
            this.rbFichero = new System.Windows.Forms.RadioButton();
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.btnChooseOrigin = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSpace = new System.Windows.Forms.Label();
            this.bHideWord = new System.Windows.Forms.CheckBox();
            this.bShowInfinitive = new System.Windows.Forms.CheckBox();
            this.trackBarSpace = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTense = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMood = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearFichero = new System.Windows.Forms.Button();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbConjugated = new System.Windows.Forms.RichTextBox();
            this.cbTenseConj = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMoodConj = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFilterInfinitives = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearFilterInfinitives = new System.Windows.Forms.Button();
            this.listBoxInfinitives = new System.Windows.Forms.ListBox();
            this.tabControlParaCompletar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseSource
            // 
            this.ChooseSource.FileName = "openFileDialogSource";
            // 
            // tabControlParaCompletar
            // 
            this.tabControlParaCompletar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlParaCompletar.Controls.Add(this.tabPage1);
            this.tabControlParaCompletar.Controls.Add(this.tabPage2);
            this.tabControlParaCompletar.Location = new System.Drawing.Point(12, 12);
            this.tabControlParaCompletar.Name = "tabControlParaCompletar";
            this.tabControlParaCompletar.SelectedIndex = 0;
            this.tabControlParaCompletar.Size = new System.Drawing.Size(683, 569);
            this.tabControlParaCompletar.TabIndex = 20;
            this.tabControlParaCompletar.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlParaCompletar_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnCrearFichero);
            this.tabPage1.Controls.Add(this.rtbPreview);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 543);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Para Completar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopyFromClipboard);
            this.groupBox3.Controls.Add(this.rbPortapapeles);
            this.groupBox3.Controls.Add(this.rbFichero);
            this.groupBox3.Controls.Add(this.tbOrigen);
            this.groupBox3.Controls.Add(this.btnChooseOrigin);
            this.groupBox3.Location = new System.Drawing.Point(30, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(588, 71);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origen";
            // 
            // btnCopyFromClipboard
            // 
            this.btnCopyFromClipboard.Location = new System.Drawing.Point(110, 39);
            this.btnCopyFromClipboard.Name = "btnCopyFromClipboard";
            this.btnCopyFromClipboard.Size = new System.Drawing.Size(99, 23);
            this.btnCopyFromClipboard.TabIndex = 5;
            this.btnCopyFromClipboard.Text = "Pegar";
            this.btnCopyFromClipboard.UseVisualStyleBackColor = true;
            this.btnCopyFromClipboard.Click += new System.EventHandler(this.btnCopyFromClipboard_Click);
            // 
            // rbPortapapeles
            // 
            this.rbPortapapeles.AutoSize = true;
            this.rbPortapapeles.Location = new System.Drawing.Point(19, 42);
            this.rbPortapapeles.Name = "rbPortapapeles";
            this.rbPortapapeles.Size = new System.Drawing.Size(87, 17);
            this.rbPortapapeles.TabIndex = 4;
            this.rbPortapapeles.Text = "Portapapeles";
            this.rbPortapapeles.UseVisualStyleBackColor = true;
            this.rbPortapapeles.CheckedChanged += new System.EventHandler(this.rbPortapapeles_CheckedChanged);
            // 
            // rbFichero
            // 
            this.rbFichero.AutoSize = true;
            this.rbFichero.Checked = true;
            this.rbFichero.Location = new System.Drawing.Point(19, 18);
            this.rbFichero.Name = "rbFichero";
            this.rbFichero.Size = new System.Drawing.Size(60, 17);
            this.rbFichero.TabIndex = 3;
            this.rbFichero.TabStop = true;
            this.rbFichero.Text = "Fichero";
            this.rbFichero.UseVisualStyleBackColor = true;
            this.rbFichero.CheckedChanged += new System.EventHandler(this.rbFichero_CheckedChanged);
            // 
            // tbOrigen
            // 
            this.tbOrigen.Location = new System.Drawing.Point(110, 15);
            this.tbOrigen.Name = "tbOrigen";
            this.tbOrigen.Size = new System.Drawing.Size(387, 20);
            this.tbOrigen.TabIndex = 1;
            // 
            // btnChooseOrigin
            // 
            this.btnChooseOrigin.Location = new System.Drawing.Point(503, 15);
            this.btnChooseOrigin.Name = "btnChooseOrigin";
            this.btnChooseOrigin.Size = new System.Drawing.Size(75, 23);
            this.btnChooseOrigin.TabIndex = 2;
            this.btnChooseOrigin.Text = "Elegir";
            this.btnChooseOrigin.UseVisualStyleBackColor = true;
            this.btnChooseOrigin.Click += new System.EventHandler(this.btnChooseOrigin_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSpace);
            this.groupBox2.Controls.Add(this.bHideWord);
            this.groupBox2.Controls.Add(this.bShowInfinitive);
            this.groupBox2.Controls.Add(this.trackBarSpace);
            this.groupBox2.Location = new System.Drawing.Point(268, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 99);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reemplezar";
            // 
            // labelSpace
            // 
            this.labelSpace.AutoSize = true;
            this.labelSpace.Location = new System.Drawing.Point(132, 31);
            this.labelSpace.Name = "labelSpace";
            this.labelSpace.Size = new System.Drawing.Size(48, 13);
            this.labelSpace.TabIndex = 13;
            this.labelSpace.Text = "Espacio:";
            // 
            // bHideWord
            // 
            this.bHideWord.AutoSize = true;
            this.bHideWord.Checked = true;
            this.bHideWord.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bHideWord.Location = new System.Drawing.Point(22, 32);
            this.bHideWord.Name = "bHideWord";
            this.bHideWord.Size = new System.Drawing.Size(99, 17);
            this.bHideWord.TabIndex = 11;
            this.bHideWord.Text = "Ocultar Palabra";
            this.bHideWord.UseVisualStyleBackColor = true;
            this.bHideWord.CheckedChanged += new System.EventHandler(this.bHideWord_CheckedChanged);
            // 
            // bShowInfinitive
            // 
            this.bShowInfinitive.AutoSize = true;
            this.bShowInfinitive.Checked = true;
            this.bShowInfinitive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bShowInfinitive.Location = new System.Drawing.Point(22, 62);
            this.bShowInfinitive.Name = "bShowInfinitive";
            this.bShowInfinitive.Size = new System.Drawing.Size(103, 17);
            this.bShowInfinitive.TabIndex = 7;
            this.bShowInfinitive.Text = "Mostrar Infinitivo";
            this.bShowInfinitive.UseVisualStyleBackColor = true;
            this.bShowInfinitive.CheckedChanged += new System.EventHandler(this.bShowInfinitive_CheckedChanged);
            // 
            // trackBarSpace
            // 
            this.trackBarSpace.LargeChange = 10;
            this.trackBarSpace.Location = new System.Drawing.Point(181, 27);
            this.trackBarSpace.Maximum = 40;
            this.trackBarSpace.Minimum = 5;
            this.trackBarSpace.Name = "trackBarSpace";
            this.trackBarSpace.Size = new System.Drawing.Size(164, 45);
            this.trackBarSpace.SmallChange = 5;
            this.trackBarSpace.TabIndex = 8;
            this.trackBarSpace.Value = 20;
            this.trackBarSpace.ValueChanged += new System.EventHandler(this.trackBarSpace_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTense);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMood);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 99);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // cbTense
            // 
            this.cbTense.FormattingEnabled = true;
            this.cbTense.Location = new System.Drawing.Point(68, 61);
            this.cbTense.Name = "cbTense";
            this.cbTense.Size = new System.Drawing.Size(121, 21);
            this.cbTense.TabIndex = 6;
            this.cbTense.SelectedIndexChanged += new System.EventHandler(this.cbTense_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo:";
            // 
            // cbMood
            // 
            this.cbMood.FormattingEnabled = true;
            this.cbMood.Location = new System.Drawing.Point(68, 30);
            this.cbMood.Name = "cbMood";
            this.cbMood.Size = new System.Drawing.Size(121, 21);
            this.cbMood.TabIndex = 4;
            this.cbMood.SelectedIndexChanged += new System.EventHandler(this.cbMood_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modo:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(70, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 55);
            this.button1.TabIndex = 23;
            this.button1.Text = "Copiar al Portapapeles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearFichero
            // 
            this.btnCrearFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrearFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFichero.Location = new System.Drawing.Point(365, 468);
            this.btnCrearFichero.Name = "btnCrearFichero";
            this.btnCrearFichero.Size = new System.Drawing.Size(208, 55);
            this.btnCrearFichero.TabIndex = 22;
            this.btnCrearFichero.Text = "Crear Fichero";
            this.btnCrearFichero.UseVisualStyleBackColor = true;
            this.btnCrearFichero.Click += new System.EventHandler(this.btnCrearFichero_Click);
            // 
            // rtbPreview
            // 
            this.rtbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPreview.Location = new System.Drawing.Point(30, 219);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPreview.Size = new System.Drawing.Size(619, 235);
            this.rtbPreview.TabIndex = 21;
            this.rtbPreview.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Preestreno:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.rtbConjugated);
            this.tabPage2.Controls.Add(this.cbTenseConj);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cbMoodConj);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxFilterInfinitives);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonClearFilterInfinitives);
            this.tabPage2.Controls.Add(this.listBoxInfinitives);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 543);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conjugador";
            // 
            // rtbConjugated
            // 
            this.rtbConjugated.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbConjugated.Location = new System.Drawing.Point(238, 109);
            this.rtbConjugated.Name = "rtbConjugated";
            this.rtbConjugated.ReadOnly = true;
            this.rtbConjugated.Size = new System.Drawing.Size(416, 411);
            this.rtbConjugated.TabIndex = 11;
            this.rtbConjugated.Text = "";
            // 
            // cbTenseConj
            // 
            this.cbTenseConj.FormattingEnabled = true;
            this.cbTenseConj.Location = new System.Drawing.Point(291, 65);
            this.cbTenseConj.Name = "cbTenseConj";
            this.cbTenseConj.Size = new System.Drawing.Size(121, 21);
            this.cbTenseConj.TabIndex = 10;
            this.cbTenseConj.SelectedIndexChanged += new System.EventHandler(this.cbTenseConj_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiempo:";
            // 
            // cbMoodConj
            // 
            this.cbMoodConj.FormattingEnabled = true;
            this.cbMoodConj.Location = new System.Drawing.Point(291, 34);
            this.cbMoodConj.Name = "cbMoodConj";
            this.cbMoodConj.Size = new System.Drawing.Size(121, 21);
            this.cbMoodConj.TabIndex = 8;
            this.cbMoodConj.SelectedIndexChanged += new System.EventHandler(this.cbMoodConj_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Modo:";
            // 
            // textBoxFilterInfinitives
            // 
            this.textBoxFilterInfinitives.Location = new System.Drawing.Point(21, 36);
            this.textBoxFilterInfinitives.Name = "textBoxFilterInfinitives";
            this.textBoxFilterInfinitives.Size = new System.Drawing.Size(160, 20);
            this.textBoxFilterInfinitives.TabIndex = 4;
            this.textBoxFilterInfinitives.TextChanged += new System.EventHandler(this.textBoxFilterInfinitives_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtro:";
            // 
            // buttonClearFilterInfinitives
            // 
            this.buttonClearFilterInfinitives.Location = new System.Drawing.Point(187, 34);
            this.buttonClearFilterInfinitives.Name = "buttonClearFilterInfinitives";
            this.buttonClearFilterInfinitives.Size = new System.Drawing.Size(25, 23);
            this.buttonClearFilterInfinitives.TabIndex = 2;
            this.buttonClearFilterInfinitives.Text = "X";
            this.buttonClearFilterInfinitives.UseVisualStyleBackColor = true;
            this.buttonClearFilterInfinitives.Click += new System.EventHandler(this.buttonClearFilterInfinitives_Click);
            // 
            // listBoxInfinitives
            // 
            this.listBoxInfinitives.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxInfinitives.FormattingEnabled = true;
            this.listBoxInfinitives.Location = new System.Drawing.Point(21, 62);
            this.listBoxInfinitives.Name = "listBoxInfinitives";
            this.listBoxInfinitives.Size = new System.Drawing.Size(191, 459);
            this.listBoxInfinitives.TabIndex = 0;
            this.listBoxInfinitives.SelectedValueChanged += new System.EventHandler(this.listBoxInfinitives_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 593);
            this.Controls.Add(this.tabControlParaCompletar);
            this.Name = "Form1";
            this.Text = "EjercicioMago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlParaCompletar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ChooseSource;
        private System.Windows.Forms.TabControl tabControlParaCompletar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCopyFromClipboard;
        private System.Windows.Forms.RadioButton rbPortapapeles;
        private System.Windows.Forms.RadioButton rbFichero;
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Button btnChooseOrigin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSpace;
        private System.Windows.Forms.CheckBox bHideWord;
        private System.Windows.Forms.CheckBox bShowInfinitive;
        private System.Windows.Forms.TrackBar trackBarSpace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTense;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearFichero;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxInfinitives;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClearFilterInfinitives;
        private System.Windows.Forms.TextBox textBoxFilterInfinitives;
        private System.Windows.Forms.ComboBox cbTenseConj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMoodConj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbConjugated;
    }
}

