﻿namespace POOAvCS.Orientação_a_Objectos
{
    partial class frmInserirEmpregadosEX6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabInserirEmpregados = new System.Windows.Forms.TabPage();
            this.lblAux = new System.Windows.Forms.Label();
            this.btnInserirEmpregado = new System.Windows.Forms.Button();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtDerivada = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lblDerivada = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.tabVerEmpregados = new System.Windows.Forms.TabPage();
            this.lstVerEmpregados = new System.Windows.Forms.ListBox();
            this.tabAumentaSalario = new System.Windows.Forms.TabPage();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAumentaSalario = new System.Windows.Forms.Button();
            this.txtAumento = new System.Windows.Forms.TextBox();
            this.rdbValor = new System.Windows.Forms.RadioButton();
            this.rdbPergentagem = new System.Windows.Forms.RadioButton();
            this.lblDepois = new System.Windows.Forms.Label();
            this.lblAntes = new System.Windows.Forms.Label();
            this.lstDepois = new System.Windows.Forms.ListBox();
            this.lstAntes = new System.Windows.Forms.ListBox();
            this.TabControl1.SuspendLayout();
            this.tabInserirEmpregados.SuspendLayout();
            this.tabVerEmpregados.SuspendLayout();
            this.tabAumentaSalario.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabInserirEmpregados);
            this.TabControl1.Controls.Add(this.tabVerEmpregados);
            this.TabControl1.Controls.Add(this.tabAumentaSalario);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(699, 347);
            this.TabControl1.TabIndex = 1;
            this.TabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabInserirEmpregados
            // 
            this.tabInserirEmpregados.Controls.Add(this.lblAux);
            this.tabInserirEmpregados.Controls.Add(this.btnInserirEmpregado);
            this.tabInserirEmpregados.Controls.Add(this.cboDepartamento);
            this.tabInserirEmpregados.Controls.Add(this.dtpDataNascimento);
            this.tabInserirEmpregados.Controls.Add(this.txtDerivada);
            this.tabInserirEmpregados.Controls.Add(this.txtSalario);
            this.tabInserirEmpregados.Controls.Add(this.txtNome);
            this.tabInserirEmpregados.Controls.Add(this.Label3);
            this.tabInserirEmpregados.Controls.Add(this.lblDerivada);
            this.tabInserirEmpregados.Controls.Add(this.Label4);
            this.tabInserirEmpregados.Controls.Add(this.Label2);
            this.tabInserirEmpregados.Controls.Add(this.Label1);
            this.tabInserirEmpregados.Location = new System.Drawing.Point(4, 25);
            this.tabInserirEmpregados.Margin = new System.Windows.Forms.Padding(4);
            this.tabInserirEmpregados.Name = "tabInserirEmpregados";
            this.tabInserirEmpregados.Padding = new System.Windows.Forms.Padding(4);
            this.tabInserirEmpregados.Size = new System.Drawing.Size(691, 318);
            this.tabInserirEmpregados.TabIndex = 0;
            this.tabInserirEmpregados.Text = "Inserir Empregados";
            this.tabInserirEmpregados.UseVisualStyleBackColor = true;
            // 
            // lblAux
            // 
            this.lblAux.Location = new System.Drawing.Point(154, 192);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(100, 23);
            this.lblAux.TabIndex = 6;
            this.lblAux.Text = "label5";
            this.lblAux.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInserirEmpregado
            // 
            this.btnInserirEmpregado.Location = new System.Drawing.Point(159, 256);
            this.btnInserirEmpregado.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserirEmpregado.Name = "btnInserirEmpregado";
            this.btnInserirEmpregado.Size = new System.Drawing.Size(415, 43);
            this.btnInserirEmpregado.TabIndex = 4;
            this.btnInserirEmpregado.Text = "Inserir Empregado";
            this.btnInserirEmpregado.UseVisualStyleBackColor = true;
            this.btnInserirEmpregado.Click += new System.EventHandler(this.btnInserirEmpregado_Click);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Financeiro",
            "Comercial",
            "Informática",
            "Outro"});
            this.cboDepartamento.Location = new System.Drawing.Point(261, 108);
            this.cboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(160, 24);
            this.cboDepartamento.TabIndex = 3;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Location = new System.Drawing.Point(261, 60);
            this.dtpDataNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(311, 22);
            this.dtpDataNascimento.TabIndex = 2;
            // 
            // txtDerivada
            // 
            this.txtDerivada.Location = new System.Drawing.Point(261, 194);
            this.txtDerivada.Margin = new System.Windows.Forms.Padding(4);
            this.txtDerivada.Name = "txtDerivada";
            this.txtDerivada.Size = new System.Drawing.Size(160, 22);
            this.txtDerivada.TabIndex = 5;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(261, 155);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(160, 22);
            this.txtSalario.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(261, 17);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(311, 22);
            this.txtNome.TabIndex = 1;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(155, 112);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 17);
            this.Label3.TabIndex = 0;
            this.Label3.Text = "Departamento";
            // 
            // lblDerivada
            // 
            this.lblDerivada.AutoSize = true;
            this.lblDerivada.Location = new System.Drawing.Point(253, 198);
            this.lblDerivada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDerivada.Name = "lblDerivada";
            this.lblDerivada.Size = new System.Drawing.Size(0, 17);
            this.lblDerivada.TabIndex = 0;
            this.lblDerivada.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(201, 159);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(52, 17);
            this.Label4.TabIndex = 0;
            this.Label4.Text = "Salário";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(115, 68);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(136, 17);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Data de Nascimento";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(207, 21);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 17);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Nome";
            // 
            // tabVerEmpregados
            // 
            this.tabVerEmpregados.Controls.Add(this.lstVerEmpregados);
            this.tabVerEmpregados.Location = new System.Drawing.Point(4, 25);
            this.tabVerEmpregados.Margin = new System.Windows.Forms.Padding(4);
            this.tabVerEmpregados.Name = "tabVerEmpregados";
            this.tabVerEmpregados.Padding = new System.Windows.Forms.Padding(4);
            this.tabVerEmpregados.Size = new System.Drawing.Size(691, 318);
            this.tabVerEmpregados.TabIndex = 1;
            this.tabVerEmpregados.Text = "Ver Empregados";
            this.tabVerEmpregados.UseVisualStyleBackColor = true;
            // 
            // lstVerEmpregados
            // 
            this.lstVerEmpregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstVerEmpregados.FormattingEnabled = true;
            this.lstVerEmpregados.HorizontalScrollbar = true;
            this.lstVerEmpregados.ItemHeight = 16;
            this.lstVerEmpregados.Location = new System.Drawing.Point(4, 4);
            this.lstVerEmpregados.Margin = new System.Windows.Forms.Padding(4);
            this.lstVerEmpregados.Name = "lstVerEmpregados";
            this.lstVerEmpregados.Size = new System.Drawing.Size(683, 310);
            this.lstVerEmpregados.TabIndex = 0;
            // 
            // tabAumentaSalario
            // 
            this.tabAumentaSalario.Controls.Add(this.GroupBox1);
            this.tabAumentaSalario.Controls.Add(this.lblDepois);
            this.tabAumentaSalario.Controls.Add(this.lblAntes);
            this.tabAumentaSalario.Controls.Add(this.lstDepois);
            this.tabAumentaSalario.Controls.Add(this.lstAntes);
            this.tabAumentaSalario.Location = new System.Drawing.Point(4, 25);
            this.tabAumentaSalario.Margin = new System.Windows.Forms.Padding(4);
            this.tabAumentaSalario.Name = "tabAumentaSalario";
            this.tabAumentaSalario.Padding = new System.Windows.Forms.Padding(4);
            this.tabAumentaSalario.Size = new System.Drawing.Size(691, 318);
            this.tabAumentaSalario.TabIndex = 2;
            this.tabAumentaSalario.Text = "Aumenta Salário";
            this.tabAumentaSalario.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnAumentaSalario);
            this.GroupBox1.Controls.Add(this.txtAumento);
            this.GroupBox1.Controls.Add(this.rdbValor);
            this.GroupBox1.Controls.Add(this.rdbPergentagem);
            this.GroupBox1.Location = new System.Drawing.Point(275, 9);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(141, 261);
            this.GroupBox1.TabIndex = 3;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Aumento";
            // 
            // btnAumentaSalario
            // 
            this.btnAumentaSalario.Location = new System.Drawing.Point(9, 162);
            this.btnAumentaSalario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAumentaSalario.Name = "btnAumentaSalario";
            this.btnAumentaSalario.Size = new System.Drawing.Size(124, 71);
            this.btnAumentaSalario.TabIndex = 3;
            this.btnAumentaSalario.Text = "Aumenta\r\nSalário";
            this.btnAumentaSalario.UseVisualStyleBackColor = true;
            // 
            // txtAumento
            // 
            this.txtAumento.Location = new System.Drawing.Point(9, 113);
            this.txtAumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtAumento.Name = "txtAumento";
            this.txtAumento.Size = new System.Drawing.Size(123, 22);
            this.txtAumento.TabIndex = 2;
            // 
            // rdbValor
            // 
            this.rdbValor.AutoSize = true;
            this.rdbValor.Location = new System.Drawing.Point(8, 73);
            this.rdbValor.Margin = new System.Windows.Forms.Padding(4);
            this.rdbValor.Name = "rdbValor";
            this.rdbValor.Size = new System.Drawing.Size(62, 21);
            this.rdbValor.TabIndex = 1;
            this.rdbValor.TabStop = true;
            this.rdbValor.Text = "Valor";
            this.rdbValor.UseVisualStyleBackColor = true;
            // 
            // rdbPergentagem
            // 
            this.rdbPergentagem.AutoSize = true;
            this.rdbPergentagem.Location = new System.Drawing.Point(8, 37);
            this.rdbPergentagem.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPergentagem.Name = "rdbPergentagem";
            this.rdbPergentagem.Size = new System.Drawing.Size(41, 21);
            this.rdbPergentagem.TabIndex = 0;
            this.rdbPergentagem.TabStop = true;
            this.rdbPergentagem.Text = "%";
            this.rdbPergentagem.UseVisualStyleBackColor = true;
            // 
            // lblDepois
            // 
            this.lblDepois.AutoSize = true;
            this.lblDepois.Location = new System.Drawing.Point(420, 278);
            this.lblDepois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepois.Name = "lblDepois";
            this.lblDepois.Size = new System.Drawing.Size(62, 17);
            this.lblDepois.TabIndex = 2;
            this.lblDepois.Text = "(Depois)";
            // 
            // lblAntes
            // 
            this.lblAntes.AutoSize = true;
            this.lblAntes.Location = new System.Drawing.Point(12, 278);
            this.lblAntes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAntes.Name = "lblAntes";
            this.lblAntes.Size = new System.Drawing.Size(54, 17);
            this.lblAntes.TabIndex = 1;
            this.lblAntes.Text = "(Antes)";
            // 
            // lstDepois
            // 
            this.lstDepois.FormattingEnabled = true;
            this.lstDepois.ItemHeight = 16;
            this.lstDepois.Location = new System.Drawing.Point(424, 9);
            this.lstDepois.Margin = new System.Windows.Forms.Padding(4);
            this.lstDepois.Name = "lstDepois";
            this.lstDepois.Size = new System.Drawing.Size(252, 260);
            this.lstDepois.TabIndex = 0;
            // 
            // lstAntes
            // 
            this.lstAntes.FormattingEnabled = true;
            this.lstAntes.ItemHeight = 16;
            this.lstAntes.Location = new System.Drawing.Point(12, 9);
            this.lstAntes.Margin = new System.Windows.Forms.Padding(4);
            this.lstAntes.Name = "lstAntes";
            this.lstAntes.Size = new System.Drawing.Size(252, 260);
            this.lstAntes.TabIndex = 0;
            // 
            // frmInserirEmpregadosEX6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 347);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInserirEmpregadosEX6";
            this.Text = "Inserir Empregados";
            this.Load += new System.EventHandler(this.frmInserirEmpregadosEX6_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabInserirEmpregados.ResumeLayout(false);
            this.tabInserirEmpregados.PerformLayout();
            this.tabVerEmpregados.ResumeLayout(false);
            this.tabAumentaSalario.ResumeLayout(false);
            this.tabAumentaSalario.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage tabInserirEmpregados;
        internal System.Windows.Forms.Button btnInserirEmpregado;
        internal System.Windows.Forms.ComboBox cboDepartamento;
        internal System.Windows.Forms.DateTimePicker dtpDataNascimento;
        internal System.Windows.Forms.TextBox txtDerivada;
        internal System.Windows.Forms.TextBox txtSalario;
        internal System.Windows.Forms.TextBox txtNome;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label lblDerivada;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TabPage tabVerEmpregados;
        internal System.Windows.Forms.ListBox lstVerEmpregados;
        internal System.Windows.Forms.TabPage tabAumentaSalario;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnAumentaSalario;
        internal System.Windows.Forms.TextBox txtAumento;
        internal System.Windows.Forms.RadioButton rdbValor;
        internal System.Windows.Forms.RadioButton rdbPergentagem;
        internal System.Windows.Forms.Label lblDepois;
        internal System.Windows.Forms.Label lblAntes;
        internal System.Windows.Forms.ListBox lstDepois;
        internal System.Windows.Forms.ListBox lstAntes;
        private System.Windows.Forms.Label lblAux;
    }
}