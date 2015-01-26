var apiLessonsUrl = "/api/Lessons";
var apiProjectsUrl = "/api/project";


$(function () {

    var btnLinkLesson = $("#btnLink");
    var ddlLessons = $("#ddlLessonsToLink");


    btnLinkLesson.click(function () {
        var projectLesson = {
            _lessonId: ddlLessons.val(),
            _projectId: "1"
        };

        utils.ApiPost(apiProjectsUrl + "-link-lesson", projectLesson, "POST", function (result) {
            if (result) {
                toastr.success("Success");
                window.location.href = "/Projects/Index";
            }
            else {
                toastr.error(result);
            }
        });
    })


    var ddlLessons = $("#ddlLessonsToLink");

    var lessons = utils.ApiGet(apiLessonsUrl + "-get/", function (data) {
        $.each(data, function () {
            ddlLessons.append($("<option />").val(this.id).text(this.title));
        })
    });
});