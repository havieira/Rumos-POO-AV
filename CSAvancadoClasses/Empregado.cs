using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace CSAvancadoClasses
{
    public class Empregado
    
    {
        // declaração de atributos
        
        #region " Atributos "

        private string _nome;
        private DateTime _dataNascimento;
        private string _departamento;
        private decimal _salario;
        public static int _numEmp;

        #endregion

        #region " Propriedades {get; set; } "
        
        public string Nome //propriedade Nome
        { 
            get { return _nome; }   //returna o valor do atributo
            set { _nome = value; }  //atribui um valor ao atributo. 
                                    //'value' representa qualquer valor que seja passado para este atributo
                                    // é possível definir restrições (ex. if(_nome = "xxxx")), apenas atribui se o atributo for
                                    // igual a "xxxx".
        }

        public DateTime DataNascimento //propriedade DataNascimento
        {
            get { return _dataNascimento;           }
            set { _dataNascimento = value;   }
        }

        public byte Idade //propriedade Idade, propriedade read-only, não contém um setter, apenas retorna
        {
            get { return (byte)DateAndTime.DateDiff(DateInterval.Year, DataNascimento, DateTime.Now);}
        }

        public decimal Salario //propriedade Salário
        {
            get { return _salario;  }
            set { _salario = value;     }
        }

        public string Departamento //propriedade Departamento
        {
            get { return _departamento; }
            set { _departamento = value;   } //value representa qualquer valor que seja passado para este atributo
        }

        #endregion

        #region " Construtores "

        public Empregado() 
        {
            this.Nome = "";
            this.DataNascimento = new DateTime(1900, 1, 1);
            this.Salario = 0;
        }

        public Empregado(string nome, DateTime dataNasc) : this()
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
        }

        public Empregado(string nome, decimal salario) : this()
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public Empregado(string nome, DateTime dataNasc, decimal salario, string departamento)
            : this()
        {
            this.Nome = nome;
            this.DataNascimento = dataNasc;
            this.Salario = salario;
            this.Departamento = departamento;
        }

        #endregion

        #region " Métodos "

        public string imprimeTodosDados()
        {
            // como método foi criado dentro da própria classe é possível utilizar directamento os atributos da mesma.
            // método retorna uma string com todos os valores atribuidos
            return string.Format("Nome: {0}; Data de Nasc: {1}; Salário: {2}; Departamento: {3}",
                Nome, DataNascimento, Salario, Departamento);
        }

        public virtual string imprimeDados()
        {
            return string.Format("Nome: {0}; Salário: {1:C};", Nome, Salario);    
        }

        public static bool operator <(Empregado Emp1, Empregado Emp2)
        {
            if (Emp1.Salario < Emp2.Salario) 
                { return true;  }
            else 
                { return false; }
        }

        public static bool operator >(Empregado Emp1, Empregado Emp2)
        {
            if (Emp1.Salario > Emp2.Salario)
            { return true; }
            else
            { return false; }
        }

        public int ComparaSalario(Empregado outroempregado)
        {
            if (this.Salario > outroempregado.Salario) {return 1;}

            else if (this.Salario < outroempregado.Salario) { return -1; }

            else  { return 0; }
        }
            
        public void AumentaSalario(int valor) { }

        public void AumentaSalario(decimal percentagem) { }
 

        #endregion

    }
}
