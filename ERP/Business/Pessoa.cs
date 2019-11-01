using System;
using System.Collections.Generic;
using System.Data;
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

        public static List<Pessoa> Listar()
        {

            var pessoas = new List<Pessoa>();

            DataTable dados = new Database.Pessoa().Listar();
            for (var i= 0; i < dados.Rows.Count; i++)
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Id = Convert.ToInt32(dados.Rows[i]["Id"]);
                pessoa.Nome = dados.Rows[i]["nome"].ToString();
                pessoa.CPF = dados.Rows[i]["CPF"].ToString();
                pessoa.Telefone = dados.Rows[i]["telefone"].ToString();
                pessoa.Email = dados.Rows[i]["email"].ToString();
                pessoas.Add(pessoa);

                /*
                 Outra maneira de preencher o objeto pessoas 
                pessoas.Add(new Pessoa()
                {
                    Id = Convert.ToInt32(dados.Rows[i]["Id"]),
                    Nome = dados.Rows[i]["nome"].ToString(),
                    CPF = dados.Rows[i]["CPF"].ToString(),
                    Telefone = dados.Rows[i]["telefone"].ToString(),
                    Email = dados.Rows[i]["email"].ToString(),
                 }); 
                 */

            }
           
            return pessoas;
        }
    }
}
