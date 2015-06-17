var onButtonClick = function (ev) {
    var input = $('input[type=search]').val();

    ev.preventDefault();

    if(input){
        renderQuestion(input);
        sendQuestion(input);
    } else {
        alert("Gib etwas ein!!");
    }
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
        if ($('.chat_box ul li').length > 8) {
          $('.chat_box ul').animate({ top: '-=40' }, 'slow');
        }
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
