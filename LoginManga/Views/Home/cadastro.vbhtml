@code
    ViewData("Title") = "Cadastro"
End Code

<!DOCTYPE html>
<html>
<head>
  <title>Página de Cadastro</title>
  <style>
    * {
      box-sizing: border-box;
    }

    body {
      font-family: Arial, sans-serif;
      background-color: #CADDD6;
      margin: 0;
      display: flex;
      align-items: center;
      justify-content: center;
      min-height: 100vh;
      overflow: hidden;
    }

    .container {
      max-width: 400px;
      padding: 40px;
      background-color: #fff;
      border-radius: 4px;
      box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
    }

    h1 {
      font-size: 24px;
      text-align: center;
      margin-bottom: 20px;
    }

    form {
      margin-bottom: 20px;
    }

    label {
      display: block;
      font-weight: bold;
      margin-bottom: 5px;
    }

    input[type="text"],
    input[type="password"],
    input[type="email"] {
      width: 100%;
      padding: 10px;
      border: 1px solid #ccc;
      border-radius: 4px;
      margin-bottom: 10px;
    }

    button {
      width: 100%;
      padding: 10px;
      background-color: #4caf50;
      color: #fff;
      border: none;
      border-radius: 4px;
      cursor: pointer;
    }

    p {
      text-align: center;
      margin-bottom: 5px;
    }

    a{
      text-decoration: none;
      color: #000;
      font-weight: bold;
      margin-left: 5px;
    }
  </style>
</head>
<body>
  <div class="container">
    <h1>Cadastre-se</h1>
    <form action="cadastrar" method="post">
      <label for="nome">Nome:</label>
      <input type="text" id="nome" name="nome">
      <label for="email">E-mail:</label>
      <input type="email" id="email" name="email">
      <label for="senha">Senha:</label>
      <input type="password" id="senha" name="senha">
      <button type="submit">Cadastrar</button>
    </form>
    <p>Já possui uma conta? <a href="~/Home/index">Faça login!</a></p>
  </div>
</body>
</html>