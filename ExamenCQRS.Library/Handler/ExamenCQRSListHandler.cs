using ExamenCQRS.Library.Data;
using ExamenCQRS.Library.Models.Entities;
using ExamenCQRS.Library.Query;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Handler
{

    public class ExamenCQRSListHandler : IRequestHandler<ExamenCQRSListQueries, List<ExamenUsuarios>>
    {
        private readonly ApplicationDbContext _Context;



        public ExamenCQRSListHandler(ApplicationDbContext context)
        {
            _Context = context;
        }
        public async Task<List<ExamenUsuarios>> Handle(ExamenCQRSListQueries request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_Context.ExamUsuarios.ToList());
        }
    }
}
