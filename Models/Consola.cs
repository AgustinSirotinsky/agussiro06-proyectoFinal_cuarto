using System;
namespace agussiro06_tp9.Models;

public class Consola
{
    private int _idconsola; string _nombre; DateTime _fechasalida; string _empresa; string _informacion; string _portada;
    public Consola(){}

    public Consola(int idconsola, string nombre, DateTime fechasalida, string empresa, string informacion, string portada)
    {
        _idconsola=idconsola;
        _nombre=nombre;
        _fechasalida=fechasalida;
        _empresa=empresa;
        _informacion=informacion;
        _portada=portada;
    }
    public int idConsola
    {
        get{return _idconsola; }
        set{_idconsola=value;}
    }
    public string Nombre 
        {
            get{return _nombre;}
            set{_nombre = value;}
        }
    public DateTime FechaSalida
    {
        get{return _fechasalida;}
        set {_fechasalida=value;}
    }
    public string Empresa
    {
        get{return _empresa;}
        set{_empresa=value;}
    }
    public string Informacion 
        {
            get{return _informacion;}
            set{_informacion = value;}
        }
    public string Portada 
    {
        get{return _portada;}
        set{_portada=value;}
    }
    
}