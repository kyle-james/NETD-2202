Option Strict On
Public Class Person

    Public numberOfPeople As Integer = 0
    Private personFirstName As String = ""
    Private personLastName As String = ""
    Private personAge As Integer = 0

    Public Sub New()
        numberOfPeople += 1
    End Sub

    Public Sub New(first As String, last As String, age As Integer)
        Me.New()
        personFirstName = first
        personLastName = last
        personAge = age
    End Sub

    Public Property FirstName() As String
        Get
            Return personFirstName
        End Get
        Set(value As String)
            personFirstName = value
        End Set
    End Property

    Public Property LastName() As String
        Get
            Return personLastName
        End Get
        Set(value As String)
            personLastName = value
        End Set
    End Property

    Public Property Age() As Integer
        Get
            Return personAge
        End Get
        Set(value As Integer)
            personAge = value
        End Set
    End Property

    Public ReadOnly Property PeopleCount() As Integer
        Get
            Return numberOfPeople
        End Get
    End Property
End Class