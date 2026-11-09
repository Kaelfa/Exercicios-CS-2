using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicios
{
    public class Funcionario
    {
        public string nome{get; set;}
        public string cargo{get; set;}
        public decimal salario{get; private set;}

        public Funcionario(string nome, string cargo, decimal salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.salario = salario;
        }
        public void AumentarSalario(decimal mult)
        {
            salario *= mult;
        }
        public decimal ConsultarSalario()
        {
            return salario;
        }

    }
}