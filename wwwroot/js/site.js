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

