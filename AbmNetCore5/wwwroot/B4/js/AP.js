$(document).ready(function () {
  
    console.log("4i");
    $('[data-toggle="tooltip"]').tooltip();

    $('#uiTipoLicencias').keypress(function (e) {
        $('#myDropdown').slideToggle();
    });

    $("#btnBuscar").click(function () {
        $('#myDropdown').slideToggle();
    });

    $("#btBuscar").click(function () {
        $('#myDropdown').slideToggle();        
    });

    $('.fecha').datepicker({
        lenguage: 'es',
        format: 'dd/mm/yyyy',
        autoclose: true,
        todayHighlight: true,
        clearBtn:true
    });

  /*  $('#uiFDesde').val(Date.now());*/

});


// Add the following code if you want the name of the file appear on select
$(".custom-file-input").on("change", function () {
    var fileName = $(this).val().split("\\").pop();
    $(this).siblings(".custom-file-label").addClass("selected").html(fileName);
});

