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
    public class RepositorioPCSoftware : IRepositorioPCSoftware
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioPCSoftware(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<bool> EliminarPCSoftwarePorEquipo(int idEquipo)
        {
            var sql = "DELETE FROM Equipo_Software_Computadora WHERE id_equipo=@id_equipo";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_equipo = idEquipo });

            return result > 0;
        }

        public async Task<bool> InsertarPCSoftware(int idEquipo, EquipoSoftwareComputadora softwareComputadora)
        {
            var sql = "INSERT INTO Equipo_Software_Computadora (id_equipo, sistema_operativo, version_office) VALUES (@id_equipo, @sistema_operativo, @version_office)";

            var result = await _dbConnection.ExecuteAsync(sql, new
            {
                id_equipo = idEquipo,
                sistema_operativo = softwareComputadora.SistemaOperativo.ToUpper(),
                version_office = softwareComputadora.VersionOffice
            });

            return result > 0;
        }

        public async Task<EquipoSoftwareComputadora> ObtenerPCSoftwarePorEquipo(int idEquipo)
        {
            var sql = "SELECT id_equipo As IdEquipo, sistema_operativo As SistemaOperativo, version_office As VersionOffice from Equipo_Software_Computadora WHERE id_equipo=@id_equipo";

            return await _dbConnection.QueryFirstOrDefaultAsync<EquipoSoftwareComputadora>(sql, new { id_equipo = idEquipo });
        }
    }
}
