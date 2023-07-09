function CarregaItens() {
    var Id = $("#Anamnese").val();

    var Parametros = "Id: " + Id;

    $.ajax({
        dataType: "json",
        data: "{" + Parametros + "}",
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: "/Anamnese/GetItens",
        success: function (dados) {
            $("#tblAnamnese tr").remove();
            var link = "";
            var str = "";
            str += "<tr id='Detalhes'>";
            //str += "<th style='display: none;'></th>";
            //str += "<th style='display: none;'></th>";
            str += "<th>Pergunta</th> ";
            str += "<th>Tipo</th>";
            //str += "<th class='col-1 fontLabel fundoCinza border'> </th>";
            str += "</tr>";

            $(dados).each(function (i, o) {
                $("#id_anamenese").val(o.id_anamenese);
       
                if (link == "") {
                    link = "/Anamnese/Detalhar/" + o.id_anamenese;
                }
               
                str += "<tr id='Detalhes'>";
                //str += "<td style='display: none;'>" + "<input type='text' id='Id' value=" + o.id + ">" + "</td>";
                //str += "<td style='display: none;'>" + "<input type='text' id='Id' value=" + o.id + ">" + "</td>";
                str += "<td class='col-8 fontGrid border'>" + o.pergunta + "</td>";
                if (o.tipo == "SN") {
                    str += "<td class='col-2 fontGrid border'>[   ]  Sim         [   ] Não</td> ";
                }
                else if (o.tipo == "QTD") {
                    str += "<td class='col-2 fontGrid border'><input type='text'></td> ";

                }
                str += "<td class='col-1 fontGrid border'><input type='button' value='Remover' onclick='deleteRow(this)'/></td>";
                str += "</tr>";

            })
            $("#tblAnamnese").append(str);

            $("#linkPDF").attr("href", link);




        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(thrownError);
        }
    });
};



function NovaPergunta() {
    var Id = $("#id_anamenese").val();

    var Parametros = "id: " + Id;

    $.ajax({
        data: Id,
        type: "POST",
        url: "/Anamnese/Novo"
    });
};


//---------------------------------------
//---------------------------------------


function deleteRow(btn) {
    var row = btn.parentNode.parentNode;
    row.parentNode.removeChild(row);

}
