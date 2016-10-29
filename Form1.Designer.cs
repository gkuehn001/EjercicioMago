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
            this.tbOrigen = new System.Windows.Forms.TextBox();
            this.btnChooseOrigin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChooseSource = new System.Windows.Forms.OpenFileDialog();
            this.cbMood = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTense = new System.Windows.Forms.ComboBox();
            this.bShowInfinitive = new System.Windows.Forms.CheckBox();
            this.trackBarSpace = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.bHideWord = new System.Windows.Forms.CheckBox();
            this.labelSpace = new System.Windows.Forms.Label();
            this.rtbPreview = new System.Windows.Forms.RichTextBox();
            this.btnCrearFichero = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFichero = new System.Windows.Forms.RadioButton();
            this.rbPortapapeles = new System.Windows.Forms.RadioButton();
            this.btnCopyFromClipboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modo:";
            // 
            // ChooseSource
            // 
            this.ChooseSource.FileName = "openFileDialogSource";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preestreno:";
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
            this.bHideWord.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            // rtbPreview
            // 
            this.rtbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPreview.Location = new System.Drawing.Point(16, 222);
            this.rtbPreview.Name = "rtbPreview";
            this.rtbPreview.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbPreview.Size = new System.Drawing.Size(590, 174);
            this.rtbPreview.TabIndex = 14;
            this.rtbPreview.Text = "";
            // 
            // btnCrearFichero
            // 
            this.btnCrearFichero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCrearFichero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearFichero.Location = new System.Drawing.Point(354, 411);
            this.btnCrearFichero.Name = "btnCrearFichero";
            this.btnCrearFichero.Size = new System.Drawing.Size(210, 55);
            this.btnCrearFichero.TabIndex = 15;
            this.btnCrearFichero.Text = "Crear Fichero";
            this.btnCrearFichero.UseVisualStyleBackColor = true;
            this.btnCrearFichero.Click += new System.EventHandler(this.btnCrearFichero_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 55);
            this.button1.TabIndex = 16;
            this.button1.Text = "Copiar al Portapapeles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbTense);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMood);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 99);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSpace);
            this.groupBox2.Controls.Add(this.bHideWord);
            this.groupBox2.Controls.Add(this.bShowInfinitive);
            this.groupBox2.Controls.Add(this.trackBarSpace);
            this.groupBox2.Location = new System.Drawing.Point(254, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 99);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reemplezar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCopyFromClipboard);
            this.groupBox3.Controls.Add(this.rbPortapapeles);
            this.groupBox3.Controls.Add(this.rbFichero);
            this.groupBox3.Controls.Add(this.tbOrigen);
            this.groupBox3.Controls.Add(this.btnChooseOrigin);
            this.groupBox3.Location = new System.Drawing.Point(16, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(590, 71);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Origen";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearFichero);
            this.Controls.Add(this.rtbPreview);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "EjercicioMago";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbOrigen;
        private System.Windows.Forms.Button btnChooseOrigin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog ChooseSource;
        private System.Windows.Forms.ComboBox cbMood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTense;
        private System.Windows.Forms.CheckBox bShowInfinitive;
        private System.Windows.Forms.TrackBar trackBarSpace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox bHideWord;
        private System.Windows.Forms.Label labelSpace;
        private System.Windows.Forms.RichTextBox rtbPreview;
        private System.Windows.Forms.Button btnCrearFichero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbPortapapeles;
        private System.Windows.Forms.RadioButton rbFichero;
        private System.Windows.Forms.Button btnCopyFromClipboard;
    }
}

