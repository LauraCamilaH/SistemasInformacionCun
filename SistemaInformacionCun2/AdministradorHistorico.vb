﻿Public Class AdministradorHistorico : Inherits AdministradorDB
    Public Sub New() 'constructor
        MyBase.New("BDHistorico.csv", {})
    End Sub

End Class
