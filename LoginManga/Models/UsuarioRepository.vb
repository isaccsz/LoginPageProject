Imports System.Data.SqlClient

Public Class UsuarioRepository
    Private connectionString As String = "Data Source=DESKTOP-PO0D22K\SQLEXPRESS01;Initial Catalog=myDataBase;Integrated Security=True"

    Public Sub AdicionarUsuario(nome As String, email As String, senha As String)
        Using connection As New SqlConnection(connectionString)
            Dim query As String = "INSERT INTO users (nome, email, senha) VALUES (@Nome, @Email, @Senha)"
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Nome", nome)
                command.Parameters.AddWithValue("@Email", email)

                'armazenar senha dessa forma deveria ser crime! Sei que esta errado, vou melhorar :/
                command.Parameters.AddWithValue("@Senha", senha)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ObterUsuarios(email As String, senha As String) As Boolean

        Dim usuarios As New List(Of registro)()

        Using connection As New SqlConnection(connectionString)
            Dim query As String = "SELECT * FROM users"
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim usuario As New registro()
                    usuario.Email = reader("email").ToString()
                    usuario.Senha = reader("senha").ToString()

                    If (senha = Nothing) Then


                        If (usuario.Email = email) Then

                            Return True

                        End If


                    Else

                        If (usuario.Email = email And usuario.Senha = senha) Then

                            Return True

                        End If

                    End If

                End While
            End Using
        End Using

        Return False

    End Function
End Class