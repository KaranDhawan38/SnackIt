@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>SnackIt - Sign Up</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }

        .container {
            width: 400px;
            margin: 50px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        h2 {
            text-align: center;
            margin-bottom: 20px;
            font-family: 'League Spartan', sans-serif;
            color: brown;
        }

        form {
            display: flex;
            flex-direction: column;
        }

        .input-group {
            margin-bottom: 15px;
            display: flex;
            align-items: center;
        }

            .input-group label {
                width: 120px; /* Adjust as needed */
                font-weight: bold;
            }

            .input-group input {
                flex: 1;
                padding: 10px;
                border: 1px solid #ccc;
                border-radius: 5px;
                margin-top: 5px;
            }

        button {
            width: 100%;
            padding: 10px 20px;
            border: none;
            background-color: #007bff;
            color: #fff;
            cursor: pointer;
            border-radius: 5px;
        }

            button:hover {
                background-color: #0056b3;
            }

        .container .links {
            text-align: center;
            margin-top: 10px;
        }

        .login-container .links a {
            color: #007bff;
            text-decoration: none;
        }

            .login-container .links a:hover {
                text-decoration: underline;
            }
    </style>
</head>
<body>
    <div class="container">
        <h2>SnackIt</h2>
        <form action="/" method="post">
            <div class="input-group">
                <label for="username">Username:</label>
                <input type="text" id="username" name="UserName" required>
            </div>
            <div class="input-group">
                <label for="password">Password:</label>
                <input type="password" id="password" name="Password" required>
            </div>
            <div class="input-group">
                <label for="ReEnteredPassword">Confirm Password:</label>
                <input type="password" id="ReEnteredPassword" name="ReEnteredPassword" required>
            </div>
            <button type="submit">Sign Up</button>
        </form>
        <div class="links">
            Already have account?
            <a href="/Users/Login">Login</a>
        </div>
    </div>
</body>
</html>

@*<!DOCTYPE html>

    <html>
    <head>
        <meta name="viewport" content="width=device-width" />
        <title>Index</title>
    </head>
    <body>
        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/bundles/jqueryval")
        @Scripts.Render("~/bundles/bootstrap")
        @Using (Html.BeginForm())
            @Html.AntiForgeryToken()

            @<div class="form-horizontal">
                <h4>UserSignUp</h4>
                <hr />
                @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
                <div class="form-group">
                    @Html.LabelFor(Function(model) model.UserName, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.UserName, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.UserName, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.Password, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.Password, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.Password, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    @Html.LabelFor(Function(model) model.ReEnteredPassword, htmlAttributes:=New With {.class = "control-label col-md-2"})
                    <div class="col-md-10">
                        @Html.EditorFor(Function(model) model.ReEnteredPassword, New With {.htmlAttributes = New With {.class = "form-control"}})
                        @Html.ValidationMessageFor(Function(model) model.ReEnteredPassword, "", New With {.class = "text-danger"})
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <input type="submit" value="Create" class="btn btn-info" />
                    </div>
                </div>
            </div>
        End Using

        <div>
            @Html.ActionLink("Back to List", "Index")
        </div>
    </body>
    </html>*@
