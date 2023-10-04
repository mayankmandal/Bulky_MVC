﻿var dataTable;

$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loaddatatable("inprocess");
    }
    else if (url.includes("completed")) {
        loaddatatable("completed");
    }
    else if (url.includes("pending")) {
        loaddatatable("pending");
    }
    else if (url.includes("approved")) {
        loaddatatable("approved");
    }
    else {
        loaddatatable("all");
    }
});


function loaddatatable(status) {
    dataTable = $('#tbldataorder').DataTable({
        "ajax": { url: '/admin/order/getall?status='+status },
        "columns": [
            { "data": 'id', "width": "5%" },
            { "data": 'applicationUser.name', "width": "25%" },
            { "data": 'applicationUser.phoneNumber', "width": "20%" },
            { "data": 'applicationUser.email', "width": "15%" },
            { "data": 'orderStatus', "width": "10%" },
            { "data": 'orderTotal', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/order/details?orderId=${data}" class="btn btn-primary mx-2"><i class="bi bi-pencil-square"></i></a>
                    </div>`
                },
                "width": "10%"
            }
        ]
    });
}