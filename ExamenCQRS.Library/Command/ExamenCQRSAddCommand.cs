using ExamenCQRS.Library.Models.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenCQRS.Library.Command
{
    //Modificador de acceso // Record
    public record ExamenCQRSAddCommand(ExamenUsuarios modelo): IRequest<ExamenUsuarios>;
}
