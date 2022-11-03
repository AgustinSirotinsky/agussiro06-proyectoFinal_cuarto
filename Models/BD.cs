using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace agussiro06_tp9.Models;

public class BD 
{
    private static List<Juego> ListadoJuegos= new List<Juego>();
    private static List<Consola> ListadoConsolas= new List<Consola>();
    //CAMBIAR SERVIDOR 
    private static string  _connectionstring = @"Server=A-PHZ2-CIDI-030;DataBase=ConsoleWorld;Trusted_Connection=True;";
    public static List<Consola> ListarConsolas ()
    {
        using(SqlConnection db = new SqlConnection(_connectionstring)){
            string sql = "SELECT * FROM Consola";
            ListadoConsolas = db.Query<Consola>(sql).ToList();
        }
        return ListadoConsolas;
    }
    public static List<Juego> ListarJuegos ()
    {
        using(SqlConnection db = new SqlConnection(_connectionstring)){
            string sql = "SELECT * FROM Juego";
            ListadoJuegos = db.Query<Juego>(sql).ToList();
        }
        return ListadoJuegos;
    }  
    public static Consola DetalleConsola(int IdConsola)
    {
            Consola ConsolaElegida=null;
            using(SqlConnection db = new SqlConnection(_connectionstring)){
                string sql = "SELECT * FROM Consola WHERE IdConsola=@pIdConsola";
                ConsolaElegida = db.QueryFirstOrDefault<Consola>(sql, new {pIdConsola = IdConsola});
        }
            System.Console.WriteLine(ConsolaElegida.Nombre);
            return ConsolaElegida;
    }
    public static Juego DetalleJuego(int IdJuego)
    {
            Juego JuegoElegido=null;
        using(SqlConnection db = new SqlConnection(_connectionstring)){
                string sql = "SELECT * FROM Juego WHERE IdJuego=@pIdJuego";
            JuegoElegido = db.QueryFirstOrDefault<Juego>(sql, new {pIdJuego = IdJuego});
        }
        return JuegoElegido;
    }
}