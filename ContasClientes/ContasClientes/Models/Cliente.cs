using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasClientes.Models
{
     class Cliente
    {
        private long Id { get; set; }
        private string Nome { get; set; }
        private string Cpf { get; set; }

        public Cliente(long id, string nome, string cpf)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
        }
    }
}
