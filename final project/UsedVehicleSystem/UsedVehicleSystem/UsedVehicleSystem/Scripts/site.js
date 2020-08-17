$(document).ready(function () {

    //$('#dataTable').DataTable();

    $('.clickable-row').click(function () {
        window.location = $(this).data("href");
    });

});
