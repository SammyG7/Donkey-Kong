Module MarioStuff
    Structure Character
        Dim speed As Point
        Dim floatTime As Integer
        Dim picNum As Integer
        Dim facingRight As Boolean
        Dim floating As Boolean
        Dim onLadder As Boolean
        Dim Death As Boolean
    End Structure
    Structure floor
        Dim b As Double
        Dim slope As Double
        Dim finish As Integer
        Dim start As Integer
        Dim low As Integer
        Public Function getX(ByVal y As Integer)
            Dim X As Double
            X = (y - b) / slope
            Return X
        End Function
        Public Function gety(ByVal x As Integer)
            Dim Y As Double
            Y = slope * x + b
            Return Y
        End Function
    End Structure
End Module
