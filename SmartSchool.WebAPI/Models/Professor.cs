using System.Collections;
using System.Collections.Generic;

namespace SmartSchool.WebAPI.Models
{

     public class Professor  
    {
          public Professor(){}
          
        public Professor(int id) 
        {
            this.Id = id;
   
        }
                  public int Id { get; set; }
          public string Nome { get; set; }
          public IEnumerable <Disciplina>  Disciplinas { get; set; }

    } 

        
    }

