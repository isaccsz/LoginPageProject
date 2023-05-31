@Code
    ViewData("Title") = "Home Page"

    Dim imagePath = "/Content/manga.png"


End Code

<!DOCTYPE html>
<html>
<body>
    <div class="container">
        <h1>Bem-Vindo à <strong>vanguarda</strong> da inovação tecnológica</h1>
        <img src="@imagePath" alt="Manga" />
        <form action="cadastrar" method="post">
            <label for="login">Login:</label>
            <input type="email" id="email" name="email">
            <label for="senha">Senha:</label>
            <input type="password" id="senha" name="senha">
            <button type="submit">Enviar</button>
        </form>
        <p>Não tem uma conta? <a href="~/Home/cadastro">Cadastre-se!</a></p>
        <p class="forgot-password"><a href="~/Home/forgotPassword">Esqueci minha senha</a></p>
    </div>
</body>
</html>






