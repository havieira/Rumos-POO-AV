using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAvancadoClasses
{
    public class Programador : Empregado
    {
        #region " Atributos "

        string _linguagem;

        #endregion

        #region " Propriedades "

        public string Linguagem
        {
            get { return _linguagem; }
            set { _linguagem = value; }
        }

        #endregion

        public override string imprimeDados()
        {
            return string.Format("Nome: {0}; Salário: {1:C}; Linguagem: {2}", Nome, Salario, Linguagem);
        }

    }
}
