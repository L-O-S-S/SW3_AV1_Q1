using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAluno.Models
{
    public class Aluno
    {
        [Key]
        public long? AlunoID { get; set; }

        [Required]
        public string Nome { get; set; }
        [Required]

        public int Idade { get; set; }
        [Required]
        public string Genero { get; set; }

        [Required]
        public string Sala { get; set; }
        [Required]
        public string Turma { get; set; }
    }
}
