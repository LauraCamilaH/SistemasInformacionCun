Public Class AdministradorHistorico : Inherits AdministradorDB
    Public Sub New() 'constructor
        MyBase.New("BDHistorico.csv", 5)
    End Sub

End Class
