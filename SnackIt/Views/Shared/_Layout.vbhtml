<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>SnackIt</title>
    <style>
        body, h1, h2, ul, li {
            margin: 0;
            padding: 0;
            list-style: none;
        }

        .app-container {
            font-family: Arial, sans-serif;
        }

        .app-header {
            background-color: #FF5722;
            color: white;
            padding: 10px;
            text-align: center;
        }

        .app-nav ul {
            display: flex;
            justify-content: center;
            padding-top: 10px;
        }

        .app-nav li {
            margin: 0 10px;
        }

        .app-nav a {
            text-decoration: none;
            color: white;
        }

        .app-main {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
            background-color: #EEEEEE;
            padding: 20px;
        }

        .category {
            flex-basis: 100%;
            display: flex;
            justify-content: space-around;
            margin-bottom: 20px;
        }

        .food-item {
            text-align: center;
            flex-basis: 30%;
            background-color: white;
            margin: 10px;
            padding: 10px;
            border-radius: 5px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }

            .food-item img {
                width: 100px;
                height: auto;
            }

            .food-item h2 {
                color: #FF5722;
                margin-top: 10px;
            }

        h2 {
            text-align: center;
            font-family: 'League Spartan', sans-serif;
            color: White;
        }

        .app-nav li.selected{
            font-weight: 700;
            text-decoration: underline;
        }
    </style>
</head>
<body>
    <div class="app-container">
        <header class="app-header">
            <h2>SnackIt</h2>
            <nav class="app-nav">
                <ul>
                    @Code
                        Dim foodsClass As String = String.Empty
                        Dim drinksClass As String = String.Empty
                        Dim desertsClass As String = String.Empty
                        Dim myCartClass As String = String.Empty

                        Select Case ViewBag.FoodType
                            Case "Foods"
                                foodsClass = "selected"
                            Case "Drinks"
                                drinksClass = "selected"
                            Case "Deserts"
                                desertsClass = "selected"
                        End Select
                    End Code
                    <li class="@foodsClass"><a href="/Home/Foods">Foods</a></li>
                    <li class="@drinksClass"><a href="/Home/Drinks">Drinks</a></li>
                    <li class="@desertsClass"><a href="/Home/Deserts">Deserts</a></li>
                    <li><a href="#">MyCart</a></li>
                </ul>
            </nav>
        </header>
        @RenderBody()
    </div>
</body>
</html>