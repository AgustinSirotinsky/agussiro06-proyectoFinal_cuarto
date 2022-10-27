using System;
namespace agussiro06_tp9.Models;

public class Juego
{
    private int _idJuego; string _Nombre; int _idConsola; DateTime _FechaSalida; string _Desarroladora; bool _favorito; string _Informacion; string _portada;
    public Juego(){}
    public Juego(int idJuego, string Nombre, int idConsola, DateTime FechaSalida, string Desarrolladora, bool favorito, string Informacion, string portada)
    {
        _idJuego=idJuego;
        _Nombre=Nombre;
        _idConsola=idConsola;
        _FechaSalida=FechaSalida;
        _Desarroladora=Desarrolladora;
        _favorito=favorito;
        _Informacion=Informacion;
        _portada=portada;
    }
    public int IdJuego 
        {
            get{return _idJuego;}
            set{_idJuego = value;}
        }
    public string Nombre 
        {
            get{return _Nombre;}
            set{_Nombre = value;}
        }
    public int idConsola
    {
        get{return _idConsola; }
        set{_idConsola=value;}
    }
    public DateTime FechaSalida
    {
        get{return _FechaSalida;}
        set {_FechaSalida=value;}
    }
    public string Desarrolladora
    {
        get { return _Desarroladora;}
        set { _Desarroladora=value;}
    }
    public bool Favorito
    {
        get {return _favorito;}
        set{_favorito=value;}
    }
    public string Informacion 
        {
            get{return _Informacion;}
            set{_Informacion = value;}
        }
    public string Portada 
    {
        get{return _portada;}
        set{_portada=value;}
    }
}