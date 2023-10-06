namespace Micalculadora
{
    partial class FrmCalculadora
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
            btnOperar = new Button();
            btnLimpiar = new Button();
            btnCerrar = new Button();
            txtPrimerOperador = new TextBox();
            txtSegundoOperador = new TextBox();
            lblPrimerOperador = new Label();
            lblOperacion = new Label();
            lblSegundoOperador = new Label();
            grpSistema = new GroupBox();
            rdbBinario = new RadioButton();
            rdbDecimal = new RadioButton();
            lblResultado = new Label();
            cmbOperacion = new ComboBox();
            resultado = new Label();
            lblHistorial = new Label();
            lstHistorial = new ListBox();
            grpSistema.SuspendLayout();
            SuspendLayout();
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(25, 360);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(150, 25);
            btnOperar.TabIndex = 4;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(268, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 25);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(518, 360);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(150, 25);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtPrimerOperador
            // 
            txtPrimerOperador.Location = new Point(25, 286);
            txtPrimerOperador.Name = "txtPrimerOperador";
            txtPrimerOperador.Size = new Size(150, 23);
            txtPrimerOperador.TabIndex = 1;
            txtPrimerOperador.TextChanged += txtPrimerOperador_TextChanged;
            // 
            // txtSegundoOperador
            // 
            txtSegundoOperador.Location = new Point(518, 286);
            txtSegundoOperador.Name = "txtSegundoOperador";
            txtSegundoOperador.Size = new Size(150, 23);
            txtSegundoOperador.TabIndex = 3;
            txtSegundoOperador.TextChanged += txtSegundoOperador_TextChanged;
            // 
            // lblPrimerOperador
            // 
            lblPrimerOperador.AutoSize = true;
            lblPrimerOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrimerOperador.Location = new Point(36, 242);
            lblPrimerOperador.Name = "lblPrimerOperador";
            lblPrimerOperador.Size = new Size(125, 21);
            lblPrimerOperador.TabIndex = 5;
            lblPrimerOperador.Text = "Primer operador";
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacion.Location = new Point(303, 242);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(85, 21);
            lblOperacion.TabIndex = 6;
            lblOperacion.Text = "Operacion:";
            // 
            // lblSegundoOperador
            // 
            lblSegundoOperador.AutoSize = true;
            lblSegundoOperador.Cursor = Cursors.Cross;
            lblSegundoOperador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSegundoOperador.Location = new Point(518, 242);
            lblSegundoOperador.Name = "lblSegundoOperador";
            lblSegundoOperador.Size = new Size(148, 21);
            lblSegundoOperador.TabIndex = 6;
            lblSegundoOperador.Text = "Segundo Operacion";
            // 
            // grpSistema
            // 
            grpSistema.Controls.Add(rdbBinario);
            grpSistema.Controls.Add(rdbDecimal);
            grpSistema.Location = new Point(223, 168);
            grpSistema.Name = "grpSistema";
            grpSistema.Size = new Size(265, 47);
            grpSistema.TabIndex = 9;
            grpSistema.TabStop = false;
            grpSistema.Text = "Resaltar resultado en:";
            // 
            // rdbBinario
            // 
            rdbBinario.AutoSize = true;
            rdbBinario.Location = new Point(165, 22);
            rdbBinario.Name = "rdbBinario";
            rdbBinario.Size = new Size(62, 19);
            rdbBinario.TabIndex = 8;
            rdbBinario.TabStop = true;
            rdbBinario.Text = "Binario";
            rdbBinario.UseVisualStyleBackColor = true;
            rdbBinario.CheckedChanged += rdbBinario_CheckedChanged;
            // 
            // rdbDecimal
            // 
            rdbDecimal.AutoSize = true;
            rdbDecimal.Checked = true;
            rdbDecimal.Location = new Point(41, 22);
            rdbDecimal.Name = "rdbDecimal";
            rdbDecimal.Size = new Size(68, 19);
            rdbDecimal.TabIndex = 8;
            rdbDecimal.TabStop = true;
            rdbDecimal.Text = "Decimal";
            rdbDecimal.UseVisualStyleBackColor = true;
            rdbDecimal.CheckedChanged += rdbDecimal_CheckedChanged;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblResultado.Location = new Point(25, 45);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(174, 46);
            lblResultado.TabIndex = 0;
            lblResultado.Text = "Resultado:";
            // 
            // cmbOperacion
            // 
            cmbOperacion.FormattingEnabled = true;
            cmbOperacion.Items.AddRange(new object[] { "", "+", "-", "/", "*" });
            cmbOperacion.Location = new Point(268, 286);
            cmbOperacion.Name = "cmbOperacion";
            cmbOperacion.Size = new Size(150, 23);
            cmbOperacion.TabIndex = 2;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            resultado.Location = new Point(290, 101);
            resultado.Name = "resultado";
            resultado.Size = new Size(0, 30);
            resultado.TabIndex = 1;
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Cursor = Cursors.Cross;
            lblHistorial.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblHistorial.Location = new Point(697, 89);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(92, 30);
            lblHistorial.TabIndex = 10;
            lblHistorial.Text = "Historial";
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.ItemHeight = 15;
            lstHistorial.Location = new Point(697, 122);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(217, 259);
            lstHistorial.TabIndex = 11;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 405);
            Controls.Add(lstHistorial);
            Controls.Add(lblHistorial);
            Controls.Add(resultado);
            Controls.Add(cmbOperacion);
            Controls.Add(lblResultado);
            Controls.Add(grpSistema);
            Controls.Add(lblSegundoOperador);
            Controls.Add(lblOperacion);
            Controls.Add(lblPrimerOperador);
            Controls.Add(txtSegundoOperador);
            Controls.Add(txtPrimerOperador);
            Controls.Add(btnCerrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnOperar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Leonel D'agostino";
            FormClosing += FrmCalculadora_FormClosing;
            Load += FrmCalculadora_Load;
            grpSistema.ResumeLayout(false);
            grpSistema.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOperar;
        private Button btnLimpiar;
        private Button btnCerrar;
        private TextBox txtPrimerOperador;
        private TextBox txtSegundoOperador;
        private Label lblPrimerOperador;
        private Label lblOperacion;
        private Label lblSegundoOperador;
        private GroupBox grpSistema;
        private RadioButton rdbBinario;
        private RadioButton rdbDecimal;
        private Label lblResultado;
        private ComboBox cmbOperacion;
        private Label resultado;
        private Label lblHistorial;
        private ListBox lstHistorial;
    }
}