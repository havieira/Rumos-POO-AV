using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSAvancadoClasses
{
    abstract class Empresa
    {
        #region " Atributos "

        string _nomeEmpresa;
        byte _NIF;
        Empregados _empregados;

        #endregion
        
        #region " Propriedades "

        public string NomeEmpresa
        {
            get { return _nomeEmpresa; }
            set { _nomeEmpresa = value; }
        }

        public byte NIF
        {
            get { return _NIF; }
            set { _NIF = value; }
        }

        public Empregados Empregados
        {
            get { return _empregados; }
            set { _empregados = value; }
        }

        #endregion

        
    }
}
