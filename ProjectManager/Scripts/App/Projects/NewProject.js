var apiUrl = "/api/projects";

$(document).ready(function () {

  

    $('#dpStartDate').datepicker({
        autoclose: true,
        todayHighlight: true
    });

    $('#dpEndDate').datepicker({
        autoclose: true,
        todayHighlight: true
    });


   
    
});


function Save() {
    var data;
    
    data = {
        region: $('#ddlRegions').val(),
        projectType: $('#ddlProjectTypes').val(),
        name: $('#txtName').val(),
        company: $('#ddlCompanies').val(),
        PM: $('#ddlPMs').val(),
        startDate: $('#dpStartDate').datepicker('getDate'),
        enddate: $('#dpEndDate').datepicker('getDate'),
        cost: $('#txtCost').val(),
        description: $('#txtDescription').val()
    }

    utils.ApiPost(apiUrl + "-add/", data, "PUT", function (result) {
        if (result) {
            toastr.success("Success");
            window.location.href = "/Projects/Index";
        }
        else {
            toastr.error(result);
        }
    });


}









