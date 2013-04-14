Public Class scheduleInfo

    Public eventName As String
    Public eventDate As String
    'Public ID As Integer
    'Public CreditLimit As Decimal

    Sub New(ByRef en As String, ByRef et As String)

        Me.eventName = en
        Me.eventDate = et
        'Me.ID = ID
        'Me.CreditLimit = limit
    End Sub


    Public Overrides Function ToString() As String

        Return eventName + " " + eventDate
    End Function

    'public override bool Equals(object obj)
    '{
    'Customer other;

    '    if ((obj == null) || (!(obj is Customer)))
    '        return false;

    '    other = (Customer)obj;
    '    return me.ID == other.ID;
    '}

    'public override int GetHashCode()
    '{
    '    return me.ID.GetHashCode();
    '}
End Class
