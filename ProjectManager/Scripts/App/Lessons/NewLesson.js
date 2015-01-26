

var apiUrl = "/api/lessons";

$(document).ready(function () {

 });


function Save() {
    var data;

    data = {
        title: $('#txtTitle').val(),
        pc: $('#txtPc').val(),
        phase: $('#ddlPhases').val(),
        remarks: $('#txtRemarks').val()       
    }

    utils.ApiPost(apiUrl + "-add/", data, "PUT", function (result) {
        if (result) {
            toastr.success("Success");
            window.location.href = "/Lessons/Index";
        }
        else {
            toastr.error(result);
        }
    });


}











