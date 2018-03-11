
﻿$(document).ready(function() {

// Exibo o modal
    $("#myModal").modal("show");   
    $("#DeletePortal").modal("show");

  // Exibe o tooltips
  $("[data-toggle='tooltip']").tooltip();
});

function confirmBox() {
    swal({   
        title: "Você tem certeza?",   
        text: "Você não podera recuperar esse usuário!",   
        type: "warning",   
        showCancelButton: true,   
        cancelButtonText: "Cancelar",
        confirmButtonColor: "#DD6B55",   
        confirmButtonText: "Sim, deletar!",   
        closeOnConfirm: false }, 
        function(){   
            swal("Deletado!", "Seu usuário foi excluído.", "success"); 
            $('#delete_portal').submit()
        });
  };

  function SalvarEditaMidias (){
    swal({   title: "Dados atualizados!",   text: "I will close in 2 seconds.",   timer: 2000});
  };
