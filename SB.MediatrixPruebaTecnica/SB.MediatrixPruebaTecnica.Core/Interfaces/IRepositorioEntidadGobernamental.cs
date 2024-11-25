using SB.MediatrixPruebaTecnica.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.MediatrixPruebaTecnica.Core.Interfaces
{
    public interface IRepositorioEntidadGobernamental
    {
        Task<IEnumerable<EntidadGubernamental>> ObtenerTodasAsync();
        Task AgregarAsync(EntidadGubernamental entidadGubernamental);
        Task ActualizarAsync(int id, EntidadGubernamental entidadActualizada);
        Task EliminarAsync(int id);
    }
}
