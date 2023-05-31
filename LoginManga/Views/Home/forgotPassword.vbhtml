@Code
    ViewData("Title") = "forgotPassword"
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>

    <style>

        *
        {
            box-sizing: border-box;
        }

        body
        {   

            margin: 0;
            font-family: Arial, sans-serif;
            background-color: #CADDD6;
            display: flex;
            align-items: center;
            justify-content: center;
            min-height: 100vh;
            overflow: hidden;

        }

        .container
        {

            max-width: 400px;
            padding: 40px;
            border-radius: 4px;
            background-color: #fff;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);

        }

        h1
        {

            text-align: center;

        }

        label
        {

            display: block;
            font-weight: bold;
            margin-bottom: 5px;

        }

        input[type="email"]
        {
            
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 4px;
            margin-bottom: 10px;

        }

        button 
        {
            width: 100%;
            padding: 10px;
            background-color: #4caf50;
            color: #fff;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

        p 
        {
            text-align: center;
            margin-bottom: 5px;
        }

        a {
            text-decoration: none;
            color: #000;
            font-weight: bold;
            margin-left: 5px;
        }

    </style>
</head>
<body>
    <div class="container">

        <h1>Vamos recuperar a sua conta?</h1>

        <form action="cadastrar" method="post">

            <label for="email">Email:</label>
            <input type="email" id="email" name="email">
            <button type="submit">Enviar</button>

        </form>

        <p>Não tem uma conta? <a href="~/Home/cadastro">Cadastre-se!</a></p>
        <p>Já possui uma conta? <a href="~/Home/index">Faça login!</a></p>

    </div>
</body>
</html>