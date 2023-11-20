using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV1.Entities
{
    public class Funcionario
    {

        public int Id { get; set; } // Propriedade de chave primarira necessária
        public DateTime DataAdmissao { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public DateTime Nascimento { get; set; }
        public string Sexo { get; set; }
        public string RegistroGeral { get; set; } 
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cargo { get; set; }
        public string Cpf { get; set; }
        public string Ctps { get; set; }
        public string Endereco { get; set; }
        public double ValorHora { get; set; }
        public double HorasTrabalhadas { get; set; }
        public string Situacao { get; set; }
        public string? Observacoes { get; set; }
        public DateTime InicioFerias { get; set; }
        public DateTime TerminoFerias { get; set; }

        public ICollection<Dependente> dependentes { get; set; } = new List<Dependente>(); // Navegação na coleção contendo dependentes


        public double aliquotaINSS;
        public double aliquotaIR;

        public void AddDependente(Dependente dep)
        {
            dependentes.Add(dep);
        }

        public double CalculaSalarioBruto()
        {
            return ValorHora * HorasTrabalhadas;
        }

        public double calculaSalarioLiquido()
        {
            return CalculaSalarioBruto() -
                CalculaImpostoRenda() -
                CalculaINSS() -
                CalculaVT() +
                CalculaSalarioFamilia();
        }

        //Métodos tributação/benefícios
        public double CalculaVT()
        {
            return CalculaSalarioBruto() * 0.06;
        }

        public double CalculaFGTS()
        {
            return CalculaSalarioBruto() * 0.08;
        }

        public double CalculaSalarioFamilia()
        {
            double valor = 0;

            if (CalculaSalarioBruto() <= 1655.98)
            {
                if (dependentes.Count > 0)
                {
                    foreach (Dependente dep in dependentes)
                    {
                        if (DateTime.Today.Year - dep.DataNascimento.Year < 14)
                        {
                            valor = +56.46;
                        }
                    }
                }
            }
            return valor;
        }

        public double CalculaINSS()
        {
            var teto1 = 1320.00;
            var teto2 = 2571.29;
            var teto3 = 3856.94;
            var teto4 = 7507.49;

            double salario = CalculaSalarioBruto();

            if (salario < teto1) //faixa 1
            {
                aliquotaINSS = 0.075;
                return salario * aliquotaINSS;
            }
            else if (salario > teto1 - 0.01 && salario < teto2)//faixa 2
            {
                aliquotaINSS = 0.09;
                return salario * aliquotaINSS;
            }
            else if (salario > teto2 - 0.01 && salario < teto3)//faixa 3
            {
                aliquotaINSS = 0.12;
                return salario * aliquotaINSS;
            }
            else if (salario > teto3 - 0.01 && salario < teto4)//faixa 4
            {
                aliquotaINSS = 0.14;
                return salario * aliquotaINSS;
            }
            else
            {
                return 877.24; //salário maior que o teto, valor cobrado é fixo
            }
        }

        public double CalculaImpostoRenda()
        {
            var teto1 = 2112;
            var teto2 = 2826.65;
            var teto3 = 3751.06;
            var teto4 = 4664.68;

            double salario = CalculaSalarioBruto();

            if (salario > teto1 + 0.01 && salario <= teto2) //faixa2
            {
                aliquotaIR = 0.075;
                return salario * aliquotaIR;
            }
            else if (salario > teto2 + 0.01 && salario <= teto3)//faixa 3
            {
                aliquotaIR = 0.15;
                return salario * aliquotaIR;
            }
            else if (salario > teto3 + 0.01 && salario <= teto4)//faixa 4
            {
                aliquotaIR = 0.225;
                return salario * aliquotaIR;
            }
            else if (salario > teto4 + 0.01)//faixa 5
            {
                aliquotaIR = 0.275;
                return salario * aliquotaIR;
            }
            return 0; //faixa 1 - alíquota é 0 
        }

    }

}
