using System;
namespace agussiro06_tp9.Models;

public class Juego
{
    private int _idJuego; string _Nombre; int _idConsola; DateTime _FechaSalida; string _Desarroladora; bool _favorito; string _Informacion;
    public Juego(){}
    public Juego(int idJuego, string Nombre, int idConsola, DateTime FechaSalida, string Desarrolladora, bool favorito, string Informacion)
    {
        _idJuego=idJuego;
        _Nombre=Nombre;
        _idConsola=idConsola;
        _FechaSalida=FechaSalida;
        _Desarroladora=Desarrolladora;
        _favorito=favorito;
        _Informacion=Informacion;
    }
    public int IdJuego 
        {
            get{return _idJuego;}
            set{_idJuego = value;}
        }
}