$(document).ready(function () {

    $(document).on('click', "#btnLogin", function (e) {

        var uname = $("#txtUserName").val().trim();
        var pword = $("#txtPassWord").val().trim();


        if (uname == "") {
            $("#txtUserName").addClass("error");
        }
        else {
            $("#txtUserName").removeClass("error");            
        }
        if (pword == "") {
            $("#txtPassWord").addClass("error");
        }
        else {
            $("#txtPassWord").removeClass("error");
        }

        if (uname != "" && pword != "") {
              


            $.ajax({
                url: '/home/Login',
                contentType: 'application/json; charset=utf-8',
                data: { uname: uname, pword: pword },
                type: 'GET',
                dataType: 'json'
                , success: function (data) {

                    if (data == "NOTFOUND") {
                        alert("Tài khoản hoặc mật khẩu không chính xác !");
                    }
                    else if (data == "ACCDISABLED") {
                        alert("Tài khoản đã bị vô hiệu hóa ! Vui lòng liên hệ quản trị viên !");
                    }
                    else if (data == "NOTCUSTOMER") {
                        alert("Tài khoản này không phải là một khách hàng !");
                    }
                    else {
                        window.location.href = "/home/eport";
                    }
                    

                },
                error: function (xhr, status) {
                    alert("Fail connect to system server. Please try again or check internet connection.");
                },
                complete: function (xhr, status) {

                    $("#txtPassWord").removeClass("error");
                    $("#txtUserName").removeClass("error");    
                }
            });

        }

    });

});