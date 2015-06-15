var onButtonClick = function (ev) {
    var input = $('input[type=search]').val();

    ev.preventDefault();

    renderQuestion(input);

    sendQuestion(input);
},
    sendQuestion = function (question) {
        $.ajax({
            url: "api/values",
            type: "POST",
            data: { '': question },
            success: onAnswerSuccess,
            error: onAnswerError
        });
    },
    onAnswerSuccess = function (response) {
        renderAnswer(response);
    },
    onAnswerError = function (err) {
        console.log(err);
    },
    renderAnswer = function (answer) {
        var answerLi = $('<li><strong>' + "Elise: " + '</strong>' + answer + '</li>');
        $('#chatHistory').append(answerLi);
        $('input[type=search]').val("");
    },
    renderQuestion = function (question) {
        var user = $('<strong>Du: </strong>'),
            questionLi = $('<li><strong>' + "Du: " + '</strong>' + question + '</li>');
        $('#chatHistory').append(questionLi);
    };

(function () {
    $('button[type=submit]').click(onButtonClick);
}());
