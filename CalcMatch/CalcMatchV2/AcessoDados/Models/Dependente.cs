using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV1.Entities
{
    public class Dependente
    {
        public int Id { get; set; } // Propriedade de chave primarira necessária
        public int FuncionarioId { get; set; } // Propriedade de chave estrangeira necessária 
        public Funcionario Funcionario { get; set; } = null!; // Navegação de referência necessária para principal
        public string Name { get; set; }
        public string Parentesco { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }

    }
}
