var utils = utils || {};
utils.ApiPost = {};
utils.ApiGet = {};


toastr.options = {
    "positionClass": "toast-bottom-right"
};

utils.ApiPost = function (url, object, type, successF, errorF) {

    $.ajax({
        type: type,
        data: JSON.stringify(object),
        url: url,
        contentType: "application/json",
        success: function (result) {
            if (typeof successF !== "undefined") {
                successF(result);
            }
        },
        error: function (result) {
            if (errorF == null || typeof errorF === "undefined") {
                alert('Error - ' + result.statusText);
            }
            else {
                errorF(result);
            }
        }
    });
}

utils.ApiGet = function (url, successF) {
    $.ajax({
        type: "GET",
        url: url,
        success: function (data) {
            successF(data);
        }
    });
}
