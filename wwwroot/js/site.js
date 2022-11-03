function MostrarInformacionConsola(idc){
    $.ajax({
        url: '/Home/MostrarInformacionAjaxConsola',
        data: {_IdConsola: idc},
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
function MostrarInformacionJuego(idj){
    $.ajax({
        url: '/Home/MostrarInformacionAjaxJuego',
        data: {_IdJuego: idj},
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