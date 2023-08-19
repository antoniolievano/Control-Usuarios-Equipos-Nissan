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
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly IDbConnection _dbConnection;

        public RepositorioUsuario(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<bool> ActualizarUsuario(Usuario usuario)
        {
            var sql = "UPDATE Usuarios SET id_sucursal=@id_sucursal, id_agencia=@id_agencia, nombre=@nombre, puesto=@puesto, fecha_modificacion=@fecha_modificacion WHERE id=@id_usuario";

            // Ejecutar la consulta que devolverá el número de filas afectadas (al menos 1)
            var result = await _dbConnection.ExecuteAsync(sql, new { id_sucursal = usuario.IdSucursal, id_agencia = usuario.IdAgencia, nombre = usuario.Nombre.ToUpper(), puesto = usuario.Puesto.ToUpper(), fecha_modificacion = usuario.FechaModificacion, id_usuario=usuario.Id });

            return result > 0;
        }

        public async Task<Usuario> DetallesUsuario(int id)
        {
            var sql = @"SELECT id As Id, id_agencia as IdAgencia, id_sucursal as IdSucursal, nombre As Nombre, puesto As 
                        Puesto, fecha_modificacion as FechaModificacion FROM Usuarios WHERE id=@id_usuario";

            return await _dbConnection.QueryFirstOrDefaultAsync<Usuario>(sql, new { id_usuario = id });
        }

        public async Task EliminarUsuario(int id)
        {
            var sql = "DELETE FROM Usuarios WHERE id=@id_usuario";

            await _dbConnection.ExecuteAsync(sql, new { id_usuario = id });
        }

        public async Task<bool> InsertarUsuario(Usuario usuario)
        {
            var sql = "INSERT INTO Usuarios (id_sucursal, id_agencia, nombre, puesto, fecha_modificacion) VALUES (@id_sucursal, @id_agencia, @nombre, @puesto, @fecha_modificacion)";

            // Ejecutar la consulta que devolverá el número de filas afectadas (al menos 1)
            var result = await _dbConnection.ExecuteAsync(sql, new { id_sucursal = usuario.IdSucursal, id_agencia = usuario.IdAgencia, nombre = usuario.Nombre.ToUpper(), puesto = usuario.Puesto.ToUpper(), fecha_modificacion = usuario.FechaModificacion });

            return result > 0;
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuarios()
        {
            var sql = @"SELECT u.id As Id, a.nombre as Agencia, s.nombre as Sucursal, 
                        u.nombre, u.puesto, u.fecha_modificacion as FechaModificacion, (select Count(*) from 
                        Usuario_Correos c where c.id_usuario = u.id) as TotalCorreos, (select Count(*) from 
                        Usuario_Sia_Chesa c where c.id_usuario = u.id) as TotalUsuariosChesa, (select Count(*) 
                        from Usuario_Sia_Renault c where c.id_usuario = u.id) as TotalUsuariosRenault FROM 
                        Usuarios u INNER JOIN Agencia a ON u.id_agencia=a.id INNER JOIN Sucursal s ON u.id_sucursal=s.id";

            return await _dbConnection.QueryAsync<Usuario>(sql, new { });
        }

        public async Task<IEnumerable<Usuario>> ObtenerUsuariosSimplificado()
        {
            var sql = @"SELECT u.id As Id, u.nombre As Nombre, u.puesto As Puesto, u.id_agencia As IdAgencia, u.id_Sucursal As IdSucursal, s.nombre As Sucursal FROM Usuarios u INNER JOIN Sucursal s ON u.id_sucursal=s.id";

            return await _dbConnection.QueryAsync<Usuario>(sql, new { });
        }

        public async Task<int> SiguienteId()
        {
            var sql = "SELECT IDENT_CURRENT('Usuarios') + 1";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { });
        }

        public async Task<int> CantidadUsuarios()
        {
            var sql = "SELECT count(id) as Id FROM Usuarios";

            return await _dbConnection.QueryFirstOrDefaultAsync<int>(sql, new { });
        }
    }
}
