
Imports System.Web.UI.WebControls.Expressions

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        registro.viewPort = "Index"
        Return View()
    End Function

    Function forgotPassword() As ActionResult
        registro.viewPort = "forgotPassword"
        Return View()
    End Function

    Function cadastro() As ActionResult
        registro.viewPort = "Cadastro"
        Return View()
    End Function

    <HttpPost>
    Function cadastrar(registro As registro) As ActionResult

        If (registro.viewPort = "Cadastro") Then

            Dim nome As String = registro.Nome
            Dim email As String = registro.Email
            Dim senha As String = registro.Senha

            Dim usuario As New UsuarioRepository

            usuario.AdicionarUsuario(nome, email, senha)

            Return RedirectToAction("Sucesso")

        ElseIf (registro.viewPort = "Index") Then

            Dim email As String = registro.Email
            Dim senha As String = registro.Senha

            Dim usuario As New UsuarioRepository

            If (Not usuario.ObterUsuarios(email, senha)) Then

                MsgBox("Usuario ou Senha Inválidos")
                Return View("Index")


            End If

            Return RedirectToAction("Sucesso")

        ElseIf (registro.viewPort = "forgotPassword") Then

            Dim email As String = registro.Email

            Dim usuario As New UsuarioRepository

            If (Not usuario.ObterUsuarios(email, Nothing)) Then

                MsgBox("Usuario inválido")
                Return View("forgotPassword")


            End If

            Return RedirectToAction("Sucesso")

        Else

            Return RedirectToAction("erro")

        End If

    End Function

    Function Sucesso() As ActionResult
        Return View()
    End Function

    Function erro() As ActionResult
        Return View()
    End Function

End Class
