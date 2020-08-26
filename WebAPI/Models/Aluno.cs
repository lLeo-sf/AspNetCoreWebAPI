using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WEBAPI
{ 
    public class Aluno
    {
        public Aluno(){}

        public Aluno(int Id, string nome, string Sobrenome, string sobrenome){
            this.Id = Id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Telefone = Telefone;
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string Telefone { get; set; }


        public IEnumerable<AlunoDisciplina> AlunosDisciplinas { get; set;} 
    }
}
