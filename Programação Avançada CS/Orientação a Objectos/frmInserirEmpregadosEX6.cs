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
    public partial class frmInserirEmpregadosEX6 : Form
    {
        public frmInserirEmpregadosEX6()
        {
            InitializeComponent();
        }
        List<Empregado> listaEmp = new List<Empregado>();
        //List<Administrador> listaAdmin = new List<Administrador>();
        //List<Comercial> listaComercial = new List<Comercial>();
        //List<Programador> listaProg = new List<Programador>();

        private void btnInserirEmpregado_Click(object sender, EventArgs e)
        {
            Empregado empregadoAdd = new Empregado();
            Administrador adminAdd = new Administrador();
            Comercial comercialAdd = new Comercial();
            Programador programerAdd = new Programador();

            if (cboDepartamento.SelectedIndex == 0)
            {
                adminAdd.Nome = txtNome.Text;
                adminAdd.DataNascimento = dtpDataNascimento.Value.Date;
                adminAdd.Departamento = cboDepartamento.ToString();
                adminAdd.Salario = Convert.ToDecimal(txtSalario.Text);
                adminAdd.Cargo = txtDerivada.Text;
                listaEmp.Add(adminAdd);
            }

            else if (cboDepartamento.SelectedIndex == 1)
            {
                comercialAdd.Nome = txtNome.Text;
                comercialAdd.DataNascimento = dtpDataNascimento.Value.Date;
                comercialAdd.Departamento = cboDepartamento.ToString();
                comercialAdd.Salario = Convert.ToDecimal(txtSalario.Text);
                comercialAdd.Vendas = Convert.ToDouble(txtDerivada.Text);
                listaEmp.Add(comercialAdd);
            }

            else if (cboDepartamento.SelectedIndex == 2)
            {
                programerAdd.Nome = txtNome.Text;
                programerAdd.DataNascimento = dtpDataNascimento.Value.Date;
                programerAdd.Departamento = cboDepartamento.ToString();
                programerAdd.Salario = Convert.ToDecimal(txtSalario.Text);
                programerAdd.Linguagem = txtDerivada.Text;
                listaEmp.Add(programerAdd);
            }
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (cboDepartamento.SelectedIndex == 0)
            {
                foreach (Administrador dados in listaEmp)
                {
                    lstVerEmpregados.Items.Add(dados.imprimeDados());
                }
            }

            else if (cboDepartamento.SelectedIndex == 1)
            {
                foreach (Comercial dados in listaEmp)
                {
                    lstVerEmpregados.Items.Add(dados.imprimeDados());
                }
            }

            else if (cboDepartamento.SelectedIndex == 2)
            {
                foreach (Programador dados in listaEmp)
                {
                    lstVerEmpregados.Items.Add(dados.imprimeDados());
                }
            }
                                            
            
        }

        private void frmInserirEmpregadosEX6_Load(object sender, EventArgs e)
        {
            lblAux.ResetText();
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cboDepartamento.SelectedIndex == 0)
             {
                 lblAux.Text = "Cargo";
             }
             else if (cboDepartamento.SelectedIndex == 1)
             {
                 lblAux.Text = "Vendas";
             }
             else if (cboDepartamento.SelectedIndex == 2)
             {
                 lblAux.Text = "Linguagem";
             }
             else
             {
                 lblAux.Text = "Outro";
             }

        }
    }
}