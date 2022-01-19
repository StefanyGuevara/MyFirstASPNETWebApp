// alert("Final Grade: " + "%");
$("#btnSend").click(function () {
    var a = ($("#Assignments").val())
    var g = ($("#Group").val())
    var q = ($("#Quizzes").val())
    var e = ($("#Exams").val())
    var i = ($("#Intex").val())

    var output = (a * .55) + (g * .05) + (q * .1) + (e * .2) + (i * .1)
    alert("Final Grade: " + output + "%");
})
