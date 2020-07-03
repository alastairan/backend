using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Controllers.Models;

namespace backend
{
    public class QuizContext : DbContext
    {
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }

        public DbSet<Controllers.Models.Question> Questions { get; set; }

        public DbSet<backend.Controllers.Models.Quiz> Quiz { get; set; }

    }
}
