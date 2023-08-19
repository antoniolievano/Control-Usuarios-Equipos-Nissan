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
    public class RepositorioUsuarioCorreos : IRepositorioUsuarioCorreos
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioUsuarioCorreos(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<Usuario_Correos>> ObtenerCorreosPorUsuario(int idUsuario)
        {
            var sql = "SELECT numero_correo as NumeroCorreo, correo, contrasenia As Contraseña from Usuario_Correos WHERE id_usuario=@id_usuario";

            return await _dbConnection.QueryAsync<Usuario_Correos>(sql, new { id_usuario = idUsuario });
        }

        public async Task<bool> InsertarCorreo(int idUsuario, Usuario_Correos usuario_correo)
        {
            var sql = "INSERT INTO Usuario_Correos (id_usuario, numero_correo, correo, contrasenia) VALUES (@id_usuario, @numero_correo, @correo, @contrasenia)";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_usuario = idUsuario, numero_correo = usuario_correo.NumeroCorreo, correo = usuario_correo.Correo.ToUpper(), contrasenia = usuario_correo.Contraseña == null ? null : usuario_correo.Contraseña });

            return result > 0;
        }

        public async Task<bool> EliminarCorreosPorUsuario(int idUsuario)
        {
            var sql = "DELETE FROM Usuario_Correos WHERE id_usuario=@id_usuario";

            var result = await _dbConnection.ExecuteAsync(sql, new { id_usuario = idUsuario});

            return result > 0;
        }
    }
}
