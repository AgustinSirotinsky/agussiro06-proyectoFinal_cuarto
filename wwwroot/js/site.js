function MostrarInformacion(NombreC){
    $.ajax({
        url: '/Home/MostrarInformacionAjax',
        data: {_NombreConsola: NombreC},
        type: 'GET',
        dataType: 'json',
        success: 
        function(response)
        {
            $("#Titulo-Modal").html(response.nombre);
            $("#Informacion").html(response.informacion);
        }
    });
}