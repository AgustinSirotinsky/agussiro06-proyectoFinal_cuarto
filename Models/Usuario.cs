using System;
namespace agussiro06_tp9.Models;

public class Usuario
{
    private int _idusuario; string _nombre; string _foto; DateTime _fechacreacion; string _informacion; 
    public Usuario(){}
    public Usuario(int pidusuario, string pnombre, string pfoto, DateTime pfechacreacion, string pinformacion)
    {
        idUsuario=pidusuario;
        Nombre=pnombre;
        Foto=pfoto;
        FechaCreacion=pfechacreacion;
        Informacion=pinformacion;
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
    public string Foto
    {
        get{return _foto;}
        set{_foto=value;}
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