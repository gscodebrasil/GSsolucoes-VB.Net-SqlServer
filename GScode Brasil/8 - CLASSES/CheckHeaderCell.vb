Public Class CheckHeaderCell

#Region "Ref. local"

    Inherits DataGridViewColumnHeaderCell
    Private l As New Point(18, 15)
    Private s As New Size(12, 12)
    Private _isChecked As Boolean

#End Region

    Public Property isChecked() As Boolean
        Get
            Return _isChecked
        End Get
        Set(ByVal value As Boolean)
            _isChecked = value
            Me.DataGridView.EndEdit()
            For x As Integer = 0 To Me.DataGridView.Rows.Count - 1
                If Me.DataGridView.Rows(x).IsNewRow Then Continue For
                Me.DataGridView.Rows(x).Cells(Me.OwningColumn.Index).Value = value
            Next
        End Set
    End Property

    Protected Overrides Sub Paint(
         ByVal graphics As Graphics,
         ByVal clipBounds As Rectangle,
         ByVal cellBounds As Rectangle,
         ByVal rowIndex As Integer,
         ByVal dataGridViewElementState As DataGridViewElementStates,
         ByVal value As Object,
         ByVal formattedValue As Object,
         ByVal errorText As String,
         ByVal cellStyle As DataGridViewCellStyle,
         ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle,
         ByVal paintParts As DataGridViewPaintParts)
        Dim spaces As New String(" "c, 0)
        MyBase.Paint(
                graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState,
                spaces & value.ToString.Trim, spaces, errorText, cellStyle, advancedBorderStyle, paintParts)
        CheckBoxRenderer.DrawCheckBox(graphics, New Point(cellBounds.X + 18, 15), If(isChecked, VisualStyles.CheckBoxState.CheckedNormal, VisualStyles.CheckBoxState.UncheckedNormal))
    End Sub
    Protected Overrides Sub OnMouseClick(ByVal e As DataGridViewCellMouseEventArgs)
        If New Rectangle(l, s).Contains(e.Location) Then
            isChecked = Not isChecked
        End If
        MyBase.OnMouseClick(e)
    End Sub

End Class
