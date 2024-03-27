@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>SnackIt - Login</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .login-container {
            background-color: #fff;
            border-radius: 8px;
            padding: 20px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            max-width: 400px;
            width: 100%;
        }

            .login-container h2 {
                text-align: center;
                margin-bottom: 20px;
                font-family: 'League Spartan', sans-serif;
                color: brown;
            }

            .login-container input[type="text"],
            .login-container input[type="password"],
            .login-container input[type="submit"] {
                width: calc(100% - 40px);
                padding: 10px;
                margin-bottom: 10px;
                border-radius: 4px;
                border: 1px solid #ccc;
                outline: none;
                box-sizing: border-box;
            }

            .login-container input[type="submit"] {
                background-color: #007bff;
                color: #fff;
                cursor: pointer;
                transition: background-color 0.3s;
            }

                .login-container input[type="submit"]:hover {
                    background-color: #0056b3;
                }

            .login-container .links {
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
    <link href="https://fonts.googleapis.com/css2?family=League+Spartan&display=swap" rel="stylesheet">
</head>
<body>
    <div class="login-container">
        <h2>SnackIt</h2>
        <form action="/Users/Login" method="post">
            <input type="text" name="UserName" placeholder="Username" required>
            <input type="password" name="Password" placeholder="Password" required>
            <input type="submit" value="Login">
        </form>
        <div class="links">New here? 
            <a href="/Users/SignUp">Sign Up</a>
        </div>
    </div>
</body>
</html>