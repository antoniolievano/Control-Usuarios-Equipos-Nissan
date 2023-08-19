using ControlUsuariosEquipos.Wasm.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public class RepositorioSucursal : IRepositorioSucursal
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioSucursal(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Sucursal>> ObtenerSucursalesPorAgencia(int idAgencia)
        {
            var sql = "SELECT id, id_agencia, nombre FROM Sucursal WHERE id_agencia = @id_agencia";

            return await _dbConnection.QueryAsync<Sucursal>(sql, new { id_agencia = idAgencia });
        }
    }
}
