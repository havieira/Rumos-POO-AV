using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAvancadoClasses
{
    public class Administrador : Empregado
    {
        #region " Atributos "

        string _cargo;

        #endregion

        #region " Propriedades "

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }

        #endregion

        public override string imprimeDados()
        {
            return string.Format("Nome: {0}; Salário: {1:C}; Cargo: {2}", Nome, Salario, Cargo);
        }
    }
}
