using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CSAvancadoClasses
{
    public class Empregados
    {
        #region " Atributos "

        private ArrayList _empregados;
        private Empregado _empMaisCaro;
        
        #endregion

        #region " Construtores "

        public Empregados(){}
        public Empregados(Empregado novoEmpregado) { }

        #endregion

        #region " Propriedades "

        public Empregado this[int i]
        {
            get;
            set;
        }

        public Empregado EmpMaisCaro
        {
            get { return _empMaisCaro; }
        }

        public decimal MediaRemun
        {
            get;
        }

        public int NrEpregados
        {
            get;
        }

        #endregion

        #region " Metódos "

        public void AdicionaEmpregado(Empregado novoempregado)
        {

        }

        public static Empregado ComparaEmpregados
                  (Empregado empregado1, Empregado empregado2)
        {

        }

        #endregion

    }
}
