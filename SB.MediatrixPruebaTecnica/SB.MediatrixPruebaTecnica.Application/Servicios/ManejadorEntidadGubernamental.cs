using SB.MediatrixPruebaTecnica.Core.Dominio;
using SB.MediatrixPruebaTecnica.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SB.MediatrixPruebaTecnica.Application.Servicios
{
    public class ManejadorEntidadGubernamental
    {
        private readonly IRepositorioEntidadGobernamental _entidadGobernamental;

        public ManejadorEntidadGubernamental(IRepositorioEntidadGobernamental entidadGobernamental)
        {
            _entidadGobernamental = entidadGobernamental;
        }

        public async Task<IEnumerable<EntidadGubernamental>> ObtenerTodasAsync()
        {
           return await _entidadGobernamental.ObtenerTodasAsync();
        }

        public async Task AgregarAsync(EntidadGubernamental entidadGubernamental)
        {
            await _entidadGobernamental.AgregarAsync(entidadGubernamental);
        }
        public async Task ActualizarAsync(int id, EntidadGubernamental entidadActualizada)
        {
            await _entidadGobernamental.ActualizarAsync(id, entidadActualizada);
        }
        public async Task EliminarAsync(int id)
        {
            await _entidadGobernamental.EliminarAsync(id);
        }
    }
}
