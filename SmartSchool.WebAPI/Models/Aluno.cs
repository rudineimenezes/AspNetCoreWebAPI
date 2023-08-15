using System.Data.Common;
using System.Security.Principal;

namespace SmartSchool.WebAPI.Models
{
    public class Aluno
    {

        public Aluno(){}
        
        public Aluno ( int Id, string nome,string sobrenome, string telefone )
        {

            this.Id = Id;
            this.Nome = nome;
            this.Sobrenome = sobrenome; 
            this.Telefone = telefone;

        }

        public int Id{ get; set; }
        public string Nome { get; set; } 
        
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }




        



      


    }

}
