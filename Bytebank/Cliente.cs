using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf)
        {
            TotalDeClientesCriados += 1;
        }
        public static int TotalDeClientesCriados { get; set; }

    }
    



}
