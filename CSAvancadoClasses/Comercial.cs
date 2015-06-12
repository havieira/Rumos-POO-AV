using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAvancadoClasses
{
    public class Comercial : Empregado
    {
        #region " Atributos "

        double _vendas;
        double _comissão;

        #endregion

        #region "Propriedades"

        public double Vendas
        {
            get { return _vendas; }
            set { _vendas = value; }
        }

        public double Comissão
        {
            get { return _comissão; }
            set { _comissão = value; }
        }

        #endregion

        public override string imprimeDados()
        {
            Comissão = (Vendas * 0.01);
            return string.Format("Nome: {0}; Salário: {1:C}; Vendas: {2}; Comissão: {3}", Nome, Salario, Vendas, Comissão);
        }

        //public double mComissão()
        //{
        //    return 
        //}
    }
}
