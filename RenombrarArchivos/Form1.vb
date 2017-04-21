Imports System
Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btngenerar.Enabled = False


    End Sub

    Private Sub btnorigen_Click(sender As Object, e As EventArgs) Handles btnorigen.Click

        Dim archivos As String()
        Dim item As String
        Dim contador As Integer = 0

        Dim ext As String

        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtorigen.Text = FolderBrowserDialog.SelectedPath
            archivos = Directory.GetFiles(txtorigen.Text)

            For Each item In archivos
                contador = contador + 1

                Dim partes_a As String() = item.Split(New Char() {"\"c})

                Dim nombre_archivo As String = partes_a.Last

                Dim partes_nombre As String() = nombre_archivo.Split(New Char() {"."c})

                txtext.Text = partes_nombre.Last

            Next

            lblcantidadarchivos.Text = "Cantidad de archivos :" & contador.ToString()
            progreso.Minimum = 0
            progreso.Maximum = contador
            progreso.Value = 0

            cbofolio.SelectedIndex = 0

        End If

        If txtorigen.Text IsNot "" And txtdestino.Text IsNot "" Then
            btngenerar.Enabled = True
        End If

    End Sub

    Private Sub btndestino_Click(sender As Object, e As EventArgs) Handles btndestino.Click

        Dim archivos() As String

        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            txtdestino.Text = FolderBrowserDialog.SelectedPath
        End If

        If txtorigen.Text IsNot "" And txtdestino.Text IsNot "" Then
            btngenerar.Enabled = True
        End If
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click

        Dim archivos_origen As String()
        Dim nombre_archivo_final As String
        Dim contador_pos As Integer
        Dim folio As String
        Dim cero As String
        Dim contador_progreso As Integer

        archivos_origen = Directory.GetFiles(txtorigen.Text)

        contador_pos = txtiniciosecuencia.Value.ToString()

        If IsDirectoryWritable(txtdestino.Text) Then

            For Each archivo In archivos_origen

                    If cbofolio.Text = "Con 0" Then

                        If archivos_origen.Length < 10 Then
                            cero = Microsoft.VisualBasic.Right("0" & contador_pos, 1)
                        ElseIf archivos_origen.Length < 100 Then
                            cero = Microsoft.VisualBasic.Right("00" & contador_pos, 2)
                        ElseIf archivos_origen.Length < 1000 Then
                            cero = Microsoft.VisualBasic.Right("000" & contador_pos, 3)
                        ElseIf archivos_origen.Length < 10000 Then
                            cero = Microsoft.VisualBasic.Right("0000" & contador_pos, 4)
                        End If

                    Else
                        folio = contador_pos
                        cero = ""
                    End If

                    nombre_archivo_final = txtdestino.Text & "\" & txtprefijo.Text & cero & folio & txtsufijo.Text & "." & txtext.Text

                System.IO.File.Copy(archivo, nombre_archivo_final, chksobreescribir.Checked)

                contador_pos = contador_pos + 1
                contador_progreso = contador_progreso + 1
                progreso.Value = contador_progreso

                Next

        Else
                MsgBox("No tiene los permisos necesarios para escribir en el directorio de destino.", vbOKOnly + vbExclamation, "Error de sistema")
        End If

    End Sub

    Private Function IsDirectoryWritable(ByVal path As String)
        Dim info As New DirectoryInfo(path)
        Return (info.Attributes And FileAttributes.ReadOnly) <> FileAttributes.ReadOnly
    End Function

End Class
