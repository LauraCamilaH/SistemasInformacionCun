Public Class AdministradorHistorico : Inherits AdministradorDB
    Public Sub New() 'constructor
        MyBase.New("asignacion", {"Operacion", "Elemento", "ID_persona", "ID_elemento"})
    End Sub

End Class
