const GetCode = function () {
    let CodeNode = document.querySelector("#code");
    let IDNode = document.querySelector("#id");
    if (CodeNode.value) {
        window.location.href = `/VerifyCode/${IDNode.value}/${CodeNode.value}`;
    }
    else {
        alert("Please Enter Code");
    }
}

const GetDate = function () {
    let DateNode = document.querySelector("#date");
    let IDNode = document.querySelector("#id");
    if (DateNode.value) {
        window.location.href = `/Checkout/${IDNode.value}/${DateNode.value}`;
    }
    else {
        alert("Please Enter Date and Time");
    }
}