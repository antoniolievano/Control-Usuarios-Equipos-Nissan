using ControlUsuariosEquipos.Wasm.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace ControlUsuariosEquipos.Wasm.Repositorios
{
    public class RepositorioAgencia : IRepositorioAgencia
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioAgencia(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Agencia>> ObtenerAgencias()
        {
            var sql = "SELECT id As id, nombre As Nombre FROM Agencia";

            return await _dbConnection.QueryAsync<Agencia>(sql, new { });
        }
    }
}
