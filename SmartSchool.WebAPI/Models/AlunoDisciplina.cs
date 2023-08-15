namespace SmartSchool.WebAPI.Models
{

    public class AlunoDisciplina
    {
        public AlunoDisciplina(){}    
        public AlunoDisciplina(int alunoId, Disciplina disciplina) 
        {
            this.AlunoId = alunoId;
            this.Disciplina = disciplina;
   
        }
                public int AlunoId { get; set; }
        public Aluno  Aluno { get; set; }
        public int  DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }


        
    }
}
