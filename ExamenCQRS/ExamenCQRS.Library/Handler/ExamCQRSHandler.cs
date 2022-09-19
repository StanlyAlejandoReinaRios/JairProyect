using ExamenCQRS.Library.Command;
using ExamenCQRS.Library.Data;
using ExamenCQRS.Library.Models.Entities;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Handler
{
    public class ExamCQRSHandler : IRequestHandler<ExamenCQRSAddCommand, ExamenUsuarios>
    {
        private readonly ApplicationDbContext _Context;

        public ExamCQRSHandler(ApplicationDbContext context)
        {
            _Context = context;
        }

        public async Task<ExamenUsuarios> Handle(ExamenCQRSAddCommand request, CancellationToken cancellationToken)
        {
            _Context.ExamUsuarios.Add(request.modelo);
            await _Context.SaveChangesAsync();
            return await Task.FromResult(request.modelo);
            //public async Task<ExamenUsuarios> Handle(ExamenCQRSAddCommand request, CancellationToken cancellationToken)
            //{
            //    _Context.ExamUsuarios.Add(request.requestt);
            //    await _Context.SaveChangesAsync();
            //    return await Task.FromResult(request.requestt);

            //}
        }
    }
}

