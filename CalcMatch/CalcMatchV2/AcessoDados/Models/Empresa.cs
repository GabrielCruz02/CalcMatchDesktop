using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcMatchV1.Entities
{
    public class Empresa
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String CNPJ { get; set; }
        public String RamoAtuacao { get; set; }
        public String Email { get; set; }

    }
}
