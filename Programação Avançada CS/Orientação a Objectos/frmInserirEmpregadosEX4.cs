using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSAvancadoClasses;

namespace POOAvCS.Orientação_a_Objectos
{
    public partial class frmInserirEmpregadosEX4 : Form
    {
        public frmInserirEmpregadosEX4()
        {
            InitializeComponent();
        }

        List<Empregado> listaEmpEx4 = new List<Empregado>();


        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            foreach (Empregado dados in listaEmpEx4)
            {
                lstVerEmpregados.Items.Add(dados.imprimeDados());
            }
        }

        private void btnInserirEmpregado_Click(object sender, EventArgs e)
        {
            Empregado empregadoAdd = new Empregado();

            empregadoAdd.Nome = txtNome.Text;
            empregadoAdd.DataNascimento = dtpDataNascimento.Value.Date;
            empregadoAdd.Departamento = cboDepartamento.ToString();
            empregadoAdd.Salario = Convert.ToDecimal(txtSalario.Text);
            listaEmpEx4.Add(empregadoAdd);
        }
    }
}