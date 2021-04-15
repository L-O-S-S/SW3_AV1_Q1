using ExercicioAluno.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAluno.Data
{
    public class IESDbInitializer
    {
        public static void Initialize(IESContext context)
        {
            context.Database.EnsureCreated();

            if (context.Alunos.Any())
            {
                return;
            }

            var alunos = new Aluno[]
            {
                new Aluno{Nome = "Ana", Idade=12, Genero="F", Sala="01", Turma="1A"},
                new Aluno{Nome = "Beatriz", Idade=12, Genero="F", Sala="01", Turma="1A"},
                new Aluno{Nome = "Carlos", Idade=13, Genero="M", Sala="06", Turma="2C"},
                new Aluno{Nome = "Daniel", Idade=11, Genero="M", Sala="02", Turma="1B"},
                new Aluno{Nome = "Elias", Idade=13, Genero="M", Sala="05", Turma="2B"},
                new Aluno{Nome = "Fernanda", Idade=14, Genero="F", Sala="07", Turma="3A"},
                new Aluno{Nome = "Gabriel", Idade=11, Genero="M", Sala="01", Turma="1A"},
                new Aluno{Nome = "Higor", Idade=12, Genero="M", Sala="02", Turma="1B"},
                new Aluno{Nome = "Rubens", Idade=13, Genero="M", Sala="04", Turma="2A"},
                new Aluno{Nome = "Joana", Idade=11, Genero="F", Sala="03", Turma="1C"},

            };


            foreach (Aluno a in alunos)
            {
                context.Alunos.Add(a);
            }

            context.SaveChanges();

        }
    }
}
