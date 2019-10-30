using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pessoa
    {
        public string nome;

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public void Salvar()
        {
            if (string.IsNullOrEmpty(this.Nome)) {
                throw new Exception("Nome não pode ser vazio");
            }

            this.Id = new Database.Pessoa().Salvar(this.Nome, this.CPF, this.Telefone, this.Email);
        }
    }
}
