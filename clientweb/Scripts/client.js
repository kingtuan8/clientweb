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
                        window.location.href = "/customers/eport";
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

    $(document).on('click', "#btnUpdatepassword", function(e) {

        var newpass = $("#txtNewPass").val().trim();
        var confirm = $("#txtConfirm").val().trim();
        var oldpass = $("#txtOldPass").val().trim();

        if (newpass != confirm) {

            alert("Mật khẩu xác nhận không trùng nhau !");

        }
        else {
            $.ajax({
                url: '/home/ChangePassword',
                contentType: 'application/json; charset=utf-8',
                data: { newpass: newpass, oldpass: oldpass },
                type: 'GET',
                dataType: 'json'
                , success: function(data) {

                    if (data == "NULL") {
                        alert("Phiên làm việc kết thúc ! Vui lòng thử lại !");

                        setTimeout(function() {
                            window.location.href = "/customers/eport";
                        }, 1500);
                    }
                    else if (data == "WRONGOLD") {
                        alert("Mật khẫu cũ không chính xác ! Vui lòng thử lại !");
                    }
                   
                    else {
                        alert("Đổi mật khẩu thành công !");

                        setTimeout(function() {
                            window.location.href = "/home/account";
                        }, 1500);
                    }


                },
                error: function(xhr, status) {
                    alert("Fail connect to system server. Please try again or check internet connection.");
                },
                complete: function(xhr, status) {

                }
            });
        }

    });

});