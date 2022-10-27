function MostrarInformacion(NombreC){
    $.ajax({
        url: '/Home/MostrarInformacionAjax',
        data: {_NombrConsola: NombrC},
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