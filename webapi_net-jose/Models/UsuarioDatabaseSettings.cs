using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaAPI.Models
{
    public class UsuarioDatabaseSettings : IUserstoreDatabaseSettings
    {
        public string ColNombreUsuario { get; set; }
        public string ConnectionString { get; set; }
        public string NombreDB { get; set; }
    }

    public interface IUserstoreDatabaseSettings
    {
        string ColNombreUsuario { get; set; }
        string ConnectionString { get; set; }
        string NombreDB { get; set; }
    }
}
