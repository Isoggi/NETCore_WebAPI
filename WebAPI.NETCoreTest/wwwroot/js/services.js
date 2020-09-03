function GetUserAccess(user) {
    LoginValidate();
    $.ajax({
        type: "POST",
        url: "https://localhost:/login",
        data: JSON.stringify(user),
        dataType: "json",
        success: function (result, status, xhr) {
            if (status) {
                if (result.status) {
                    GoToPageList();
                }
            }
            else {
                alert("Login tidak berhasil");
            }
        },
        error: function (xhr, status, error) {
            alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
        }
    });
}

function AddUserAccess(user) {
    LoginValidate();
    $.ajax({
        type: "POST",
        url: "https://localhost:/login/add",
        dataType: "json",
        data: JSON.stringify(user),
        success: function (result, status) {
            var table = $("#employeelist");

            table.append("<tr><td>City:</td><td>" + result["name"] + "</td></tr>");
            table.append("<tr><td>Country:</td><td>" + result["sys"]["country"] + "</td></tr>");
            table.append("<tr><td>Current Temperature:</td><td>" + result["main"]["temp"] + "°C</td></tr>");
            table.append("<tr><td>Humidity:</td><td>" + result["main"]["humidity"] + "</td></tr>");
            table.append("<tr><td>Weather:</td><td>" + result["weather"][0]["description"] + "</td></tr>");

            $("#message").html(table);
        },
        error: function (xhr, status, error) {
            alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText)
        }
    });
    
}
