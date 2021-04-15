using ExercicioAluno.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioAluno.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IESContext _context;

        public AlunoController(IESContext context)
        {
            _context = context;
        }

        #region Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alunos.OrderBy(a => a.AlunoID).ToListAsync()); ;
        }
        #endregion
    }
}
