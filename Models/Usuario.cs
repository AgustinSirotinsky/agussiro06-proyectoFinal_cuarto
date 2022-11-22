using System;
namespace agussiro06_tp9.Models;

public class Usuario
{
    private int _idusuario; string _nombre; string _portada; DateTime _fechacreacion; string _informacion; 
    public Usuario(){}
    public Usuario(int pidusuario, string pnombre, string pportada, DateTime pfechacreacion, string pinformacion)
    {
        _idusuario=pidusuario;
        _nombre=pnombre;
        _portada=pportada;
        _fechacreacion=pfechacreacion;
        _informacion=pinformacion;
    }
    public int idUsuario
    {
        get{return _idusuario; }
        set{_idusuario=value;}
    }
    public string Nombre
    {
        get{return _nombre;}
        set{_nombre=value;}
    }
    public string Portada
    {
        get{return _portada;}
        set{_portada=value;}
    }
    public DateTime FechaCreacion
    {
        get{return _fechacreacion;}
        set{_fechacreacion=value;}
    }
    public string Informacion
    {
        get{return _informacion;}
        set{_informacion=value;}
    }
}