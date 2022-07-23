$(document).ready(function () {
    debugger;
    var Ano = $("#AnoAtual")[0].value;
    var Mes = $("#MesAtual")[0].value;
    document.getElementById("txtAno").value = Ano;
    document.getElementById("enumMes").selectedIndex = Mes - 1;
    document.getElementById("txtTema").focus();
});