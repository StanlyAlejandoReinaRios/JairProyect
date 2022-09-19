using ExamenCQRS.Library.Command;
using ExamenCQRS.Library.Data;
using ExamenCQRS.Library.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Handler
{
    public class ExamCQRSEditHandler : IRequestHandler<ExamCQRSEditCommand, ExamenUsuarios>
    {
        private readonly ApplicationDbContext _Context;

        public ExamCQRSEditHandler(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task<ExamenUsuarios> Handle(ExamCQRSEditCommand request, CancellationToken cancellationToken)
        {
            var Request = _Context.ExamUsuarios.FirstOrDefault(d => d.Id == request.id);

            _Context.ExamUsuarios.Update(Request);
            await _Context.SaveChangesAsync();

            return await Task.FromResult(Request);

        }
    }
}
