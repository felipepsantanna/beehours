
document.addEventListener("DOMContentLoaded", function () {
    const spanDate = document.getElementById('spnDate');
    const hiddenDate = document.getElementById('hddDate');

document.getElementById('btnprevday').addEventListener('click', (e) => {
    const _date = AddDays(-1); 
    PrintDate(_date); //mostro a data na tela
    });

    document.getElementById('btnnextday').addEventListener('click', (e) => {
        const _date = AddDays(1);
        PrintDate(_date); //mostro a data na tela
    });

    document.getElementById('btntoday').addEventListener('click', (e) => {
        const _date = new Date();
        PrintDate(_date); //mostro a data na tela
    });

    function AddDays(days) {
        const dataDate = spanDate.getAttribute('data-date'); //recupero a data no data-attibute
        const _date = new Date(dataDate); //crio uma nova data
        return new Date(_date.setDate(_date.getDate() + days)); //tiro um dia
    }


function FormatExtesionDate(dateNoFormat) {
    return new Intl.DateTimeFormat("pt", {
        weekday: "long",
        year: "numeric",
        month: "long",
        day: "2-digit"
    }).format(dateNoFormat);
    }

    function FormatAttrDate(dateNoFormat) {
        return dateNoFormat.toISOString();
    }

    function PrintDate(_date) {
        const formatExtesionDate = FormatExtesionDate(_date); //formato a data para extensão para exibição
        const formatAttrDate = FormatAttrDate(_date); //formato a data para novas pesquisas
        spanDate.innerHTML = formatExtesionDate;
        spanDate.setAttribute('data-date', formatAttrDate);
    }


});