Imports System

Module Program
    Sub Main(args As String())
        Dim pessoa As New Pessoa("Cauã", 22, "cauamendes.dev@gmail.com")
        Dim empresa As New Empresa("Empresa1", "100200300000121", "Rua dos patos, 777")
        Dim cliente As New Cliente("Roberto", 33, "robertinho@gmail.com", empresa.CodigoEmpresa)

        Console.WriteLine(pessoa.ToString & vbCrLf & empresa.ToString & vbCrLf & cliente.ToString)
    End Sub
End Module