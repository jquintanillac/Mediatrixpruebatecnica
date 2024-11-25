using SB.MediatrixPruebaTecnica.Core.Dominio;
using SB.MediatrixPruebaTecnica.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SB.MediatrixPruebaTecnica.Infrastructure.Repositorios
{
    public class RepositorioEntidadGobernamental : IRepositorioEntidadGobernamental
    {
        private readonly string _rutaArchivo;
        public RepositorioEntidadGobernamental(string rutaArchivo)
        {
            _rutaArchivo = rutaArchivo;
        }
        public async Task AgregarAsync(EntidadGubernamental entidadGubernamental)
        {
            
            var datos = (await ObtenerTodasAsync()).ToList();
            entidadGubernamental.Id = datos.Any() ? datos.Max(e => e.Id) + 1 : 1;
            datos.Add(entidadGubernamental);
            var json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_rutaArchivo, json);
        }

        public async Task ActualizarAsync(int id, EntidadGubernamental entidadActualizada)
        {
            // Obtén los datos actuales.
            var datos = (await ObtenerTodasAsync()).ToList();

            // Busca la entidad por Id.
            var entidadExistente = datos.FirstOrDefault(e => e.Id == id);
            if (entidadExistente == null)
                throw new KeyNotFoundException("Entidad no encontrada");

            // Actualiza los campos de la entidad.
            entidadExistente.Nombre = entidadActualizada.Nombre;
            entidadExistente.Direccion = entidadActualizada.Direccion;
            entidadExistente.Telefono = entidadExistente.Telefono;

            // Escribe los datos de vuelta al archivo.
            var json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_rutaArchivo, json);
        }
        public async Task<IEnumerable<EntidadGubernamental>> ObtenerTodasAsync()
        {
            // Verifica si el archivo existe, si no, retorna una lista vacía.
            if (!File.Exists(_rutaArchivo))
            {
                return new List<EntidadGubernamental>();
            }
                
            // Lee el contenido del archivo.
            var json = await File.ReadAllTextAsync(_rutaArchivo);

            // Deserializa el JSON en una lista de entidades.
            return JsonSerializer.Deserialize<List<EntidadGubernamental>>(json) ?? new List<EntidadGubernamental>();
        }

        public async Task EliminarAsync(int id)
        {
            // Obtén los datos actuales.
            var datos = (await ObtenerTodasAsync()).ToList();

            // Busca la entidad por Id.
            var entidad = datos.FirstOrDefault(e => e.Id == id);
            if (entidad == null)
                throw new KeyNotFoundException("Entidad no encontrada");

            // Elimina la entidad.
            datos.Remove(entidad);

            // Escribe los datos de vuelta al archivo.
            var json = JsonSerializer.Serialize(datos, new JsonSerializerOptions { WriteIndented = true });
            await File.WriteAllTextAsync(_rutaArchivo, json);
        }
    }
}
