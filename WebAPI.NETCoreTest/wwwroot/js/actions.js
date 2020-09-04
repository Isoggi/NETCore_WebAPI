function LoginValidate() {
    var isUserID = $('#username').val() !== "";
    var isPassword = $('#password').val() !== "";
    if (isUserID && isPassword) {
        return;
    }
}

function AddUserAccess() {
    var nameField = '<label>Name : </label><input type="text" placeholder="Enter Name" id="name" required>';
    $('#loginForm').append(nameField);
    $('#loginUser').hide();
}

function SubmitNewUser() {
    var user = { Id = 0, User_Id: "", Password: "", Name: "" };
    user.User_Id = $('#username').val();
    user.Password = $('#password').val();
    user.name = $('#name').val();
    AddUserAccess(user);
}

function CancelAddUserAccess() {
    $('#name').parent('div').remove();
    $('#loginUser').show();
}

function AddItemToList(data) {
    var table = $('#employeeList');
    if (data) {

    }

    table.append("<tr><td>" + result["NIK"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");
    table.append("<td>" + result["Name"] + "</td>");

    table.append("<td>" + result[] + "</td></tr>");

}