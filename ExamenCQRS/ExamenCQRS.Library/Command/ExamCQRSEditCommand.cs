using ExamenCQRS.Library.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Command
{
    public record ExamCQRSEditCommand(int id, ExamenUsuarios request): IRequest<ExamenUsuarios>;
}
