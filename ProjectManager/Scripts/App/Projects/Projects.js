

var apiUrl = "/api/project";

$(document).ready(function () {
    jQuery.ajaxSettings.traditional = true;
});

function Delete(_id) {
    utils.ApiPost(apiUrl + "-delete/", _id, "POST", function (result) {
        if (result) {            
            location.reload();
            toastr.success("Success");
        }
        else {
            toastr.error(result);
        }
    });
}
