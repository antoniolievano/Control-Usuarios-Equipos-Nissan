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
    public class RepositorioUsuarioSiaChesa : IRepositorioUsuarioSiaChesa
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioUsuarioSiaChesa(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        
        public async Task<bool> InsertarUsuarioSiaChesa(int idUsuario, Usuario_Sia_Chesa usuarioChesa)
        {
            var sql = "INSERT INTO Usuario_Sia_Chesa (id_usuario, numero_cuenta, usuario, ubicacion) VALUES (@id_usuario, @numero_cuenta, @usuario, @ubicacion)";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_usuario = idUsuario, numero_cuenta = usuarioChesa.NumeroCuenta, usuario = usuarioChesa.Usuario.ToUpper(), ubicacion = usuarioChesa.Ubicacion.ToUpper() });

            return result > 0;
        }

        public async Task<IEnumerable<Usuario_Sia_Chesa>> ObtenerUsuariosSiaChesaPorUsuario(int idUsuario)
        {
            var sql = "SELECT numero_cuenta as NumeroCuenta, usuario, ubicacion from Usuario_Sia_Chesa WHERE id_usuario=@id_usuario";

            return await _dbConnection.QueryAsync<Usuario_Sia_Chesa>(sql, new { id_usuario = idUsuario });
        }

        public async Task<bool> EliminarUsuariosSiaChesaPorUsuario(int idUsuario)
        {
            var sql = "DELETE FROM Usuario_Sia_Chesa WHERE id_usuario=@id_usuario";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_usuario = idUsuario });

            return result > 0;
        }
    }
}
