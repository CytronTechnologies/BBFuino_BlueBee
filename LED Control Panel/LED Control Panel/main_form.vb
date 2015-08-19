Imports System
Imports System.IO.Ports
Imports System.Threading
Public Class main_form
    Dim COMport As New SerialPort
    Private Sub main_form_Load(ByVal sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cbbaud.Items.Add(9600)
        cbbaud.Items.Add(19200)
        cbbaud.Items.Add(38400)
        cbbaud.Items.Add(115200)
        cbbaud.Text = cbbaud.Items.Item(0)

        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            cbcom.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
        cbcom.Text = cbcom.Items.Item(0)
        btndisconnect.Enabled = False
        btnledon.Enabled = False
        btnledoff.Enabled = False
        btnledblink.Enabled = False
    End Sub

    Private Sub btnsearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsearch.Click
        cbcom.Items.Clear()
        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            cbcom.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
    End Sub

    Private Sub btnconnect_Click_1(sender As System.Object, e As System.EventArgs) Handles btnconnect.Click
        btnconnect.Enabled = False
        btnsearch.Enabled = False
        COMport.PortName = cbcom.Text
        COMport.BaudRate = cbbaud.Text
        COMport.DataBits = 8
        COMport.Parity = Parity.None
        COMport.StopBits = StopBits.One
        COMport.WriteTimeout = 500
        COMport.ReadTimeout = 500
        Try
            COMport.Open()
            btnledon.Enabled = True
            btnledoff.Enabled = True
            btnledblink.Enabled = True
            btnconnect.Enabled = False
            btndisconnect.Enabled = True
            txtcom.Text = COMport.PortName & " is connected"
        Catch ex As Exception
            COMport.Close()
            MsgBox("The choosen COM port is not available")
            txtcom.Text = "Please choose other COM ports"
            btnsearch.Enabled = True
            btnconnect.Enabled = True
            btndisconnect.Enabled = False
            btnledon.Enabled = False
            btnledoff.Enabled = False
            btnledblink.Enabled = False
        End Try
    End Sub

    Private Sub btndisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndisconnect.Click
        COMport.Close()
        btnsearch.Enabled = True
        btndisconnect.Enabled = False
        btnconnect.Enabled = True
        btnledon.Enabled = False
        btnledoff.Enabled = False
        btnledblink.Enabled = False
        txtstatus.Clear()
        txtcom.Text = COMport.PortName & " is disconnected"
    End Sub

    Private Sub btnledon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnledon.Click
        If (COMport.IsOpen) Then
            btnledon.Enabled = False
            btnledoff.Enabled = True
            btnledblink.Enabled = True
            Dim send As Byte = 1
            Dim rec_data As String
            Try
                COMport.Write(send)
            Catch ex As Exception
                MsgBox("Cannot send!")
            End Try

            Try
                rec_data = COMport.ReadLine()
                txtstatus.Text = rec_data
            Catch ex As Exception
                MsgBox("Received Failed")
            End Try
        End If
    End Sub

    Private Sub btnledoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnledoff.Click
        If (COMport.IsOpen) Then
            btnledon.Enabled = True
            btnledoff.Enabled = False
            btnledblink.Enabled = True
            Dim send As Byte = 2
            Dim rec_data As String
            Try
                COMport.Write(send)
            Catch ex As Exception
                MsgBox("Cannot send!")
            End Try

            Try
                rec_data = COMport.ReadLine()
                txtstatus.Text = rec_data
            Catch ex As Exception
                MsgBox("Received Failed")
            End Try
        End If
    End Sub

    Private Sub btnledblink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnledblink.Click
        If (COMport.IsOpen) Then
            btnledon.Enabled = True
            btnledoff.Enabled = True
            btnledblink.Enabled = False
            Dim send As Byte = 3
            Dim rec_data As String

            Try
                COMport.Write(send)
            Catch ex As Exception
                MsgBox("Cannot send!")
            End Try

            Try
                rec_data = COMport.ReadLine()
                txtstatus.Text = rec_data
            Catch ex As Exception
                MsgBox("Received Failed")
            End Try
        End If
    End Sub

    Private Sub cbbaud_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbbaud.SelectedValueChanged
        If COMport.IsOpen = True Then
            If String.Compare(cbbaud.Text, COMport.BaudRate) Then
                MsgBox("Change COM while connected is not allowed")
                cbbaud.Text = COMport.BaudRate
            End If
        End If
    End Sub

    Private Sub cbcom_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbcom.SelectedValueChanged
        If COMport.IsOpen = True Then
            If String.Compare(cbcom.Text, COMport.PortName) Then
                MsgBox("Change COM while connected is not allowed")
                cbcom.Text = COMport.PortName
            End If
        End If
    End Sub

End Class
