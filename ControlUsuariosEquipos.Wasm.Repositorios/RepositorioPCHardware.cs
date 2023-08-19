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
    public class RepositorioPCHardware : IRepositorioPCHardware
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioPCHardware(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<bool> ActualizarPCHardware(EquipoHardwareComputadora hardwareComputadora)
        {
            var sql = "UPDATE Equipo_Hardware_Computadora SET procesador=@procesador, ram=@ram, disco_duro=@disco_duro, ssd=@ssd WHERE id_equipo=@id_equipo";

            var result = await _dbConnection.ExecuteAsync(sql, new { procesador = hardwareComputadora.Procesador.ToUpper(), ram = hardwareComputadora.Ram, disco_duro = hardwareComputadora.DiscoDuro, ssd = hardwareComputadora.Ssd, id_equipo = hardwareComputadora.IdEquipo });

            return result > 0;
        }

        public async Task<bool> EliminarPCHardwarePorEquipo(int idEquipo)
        {
            var sql = "DELETE FROM Equipo_Hardware_Computadora WHERE id_equipo=@id_equipo";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_equipo = idEquipo });

            return result > 0;
        }

        public async Task<bool> InsertarPCHardware(int idEquipo, EquipoHardwareComputadora hardwareComputadora)
        {
            var sql = "INSERT INTO Equipo_Hardware_Computadora (id_equipo, procesador, ram, disco_duro, ssd) VALUES (@id_equipo, @procesador, @ram, @disco_duro, @ssd)";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_equipo = idEquipo,
                procesador = hardwareComputadora.Procesador.ToUpper(), ram = hardwareComputadora.Ram,
                disco_duro = hardwareComputadora.DiscoDuro, ssd = hardwareComputadora.Ssd
            });

            return result > 0;
        }

        public async Task<EquipoHardwareComputadora> ObtenerPCHardwarePorEquipo(int idEquipo)
        {
            var sql = "SELECT id_equipo As IdEquipo, procesador, ram, disco_duro As DiscoDuro, ssd from Equipo_Hardware_Computadora WHERE id_equipo=@id_equipo";

            return await _dbConnection.QueryFirstOrDefaultAsync<EquipoHardwareComputadora>(sql, new { id_equipo = idEquipo });
        }
    }
}
