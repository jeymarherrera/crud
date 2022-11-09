Imports MySql.Data.MySqlClient 'Conexion con Mysql'
Imports System.IO 'Generar archivo local'
Public Class frmContactos

#Region "Variables"
    'variables a utilizar '
    Private cmb As MySqlCommandBuilder
    Dim con As New MySqlConnection
    Dim data As New DataSet
    Dim adapter As New MySqlDataAdapter
    Dim list As Byte

#End Region

#Region "Base de Datos"
    Public Sub Conectar()
        Try
            'conexion a base de datos con datos personales'
            con.ConnectionString = "server=localhost;user=root;password=;database=sistema_registros"
            con.Open()
            Dim query As String
            query = "SELECT * FROM contacto"
            adapter = New MySqlDataAdapter(query, con)
            data = New DataSet
            adapter.Fill(data, "contacto")
            dgvContactos.DataSource = data
            dgvContactos.DataMember = "contacto"
            MsgBox("Conexión Exitosa")
        Catch ex As Exception
            MsgBox("Error de Conexión" + ex.ToString)
            Me.Close()
        End Try
    End Sub
#End Region

#Region "Load"
    'Llamar a la conexion de la bd'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar()
    End Sub
#End Region

#Region "Nuevo"
    'Ingresar un nuevo contanto'
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        BorrarCampos()
        btnAgregar.Enabled = True
    End Sub
#End Region

#Region "Agregar"
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'validar campos vacios'
        If (txtID.Text = "") Or (txtNombre.Text = "") Or (txtApellido.Text = "") Or (txtFecha.Text = "") Or (cbxGenero.Text = "") Or (txtTelefono.Text = "") Or (txtDireccion.Text = "") Then
            MsgBox("No pueden haber campos vacios", MsgBoxStyle.Information, "Confirmar")
        Else
            'validar si el contacto no existe ya en la bd'
            Try
                Dim consultas As String = "SELECT * FROM contacto WHERE identificacion='" & txtID.Text & "'"
                Dim adaptador As New MySqlDataAdapter(consultas, con)
                Dim data As New DataSet
                adaptador.Fill(data, "contacto")
                list = data.Tables("contacto").Rows.Count

                If list <> 0 Then
                    MsgBox("Contacto existente, no puede ingresar a la misma persona", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()
                Else
                    'insercion efectiva'
                    Dim entrada As String = "INSERT INTO contacto (identificacion, nombre, apellido, fecha_nac, genero, telefono, direccion) 
                    VALUES ('" + txtID.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtFecha.Text + "','" + cbxGenero.Text + "','" + txtTelefono.Text + "','" + txtDireccion.Text + "')"
                    Dim dataTable As New DataTable
                    Dim adaptador2 As New MySqlDataAdapter(entrada, con)
                    adaptador2.Fill(dataTable)
                    con.Close()
                    MsgBox("Se han insertado los datos de manera exitosa", MsgBoxStyle.Information, "Confirmar")
                    BorrarCampos()
                    MostrarDatos()
                End If
            Catch ex As Exception
                MsgBox("Error, inserción fallida", MsgBoxStyle.Critical, "Error" + ex.Message)
            Finally
                con.Dispose()
            End Try
        End If
    End Sub
#End Region

#Region "Modificar"
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'verificar que se haya seleccionado algun campo en el dgv'
        If (txtID.Text = "") Or (txtNombre.Text = "") Or (txtApellido.Text = "") Or (txtFecha.Text = "") Or (cbxGenero.Text = "") Or (txtTelefono.Text = "") Or (txtDireccion.Text = "") Then
            MsgBox("No pueden modificarse, seleccione el campo que desea que se modifique", MsgBoxStyle.Information, "Confirmar")
        Else
            'modificacion efectiva'
            Dim comando As New MySqlCommand("UPDATE contacto SET nombre='" & txtNombre.Text & "', apellido='" & txtApellido.Text & "', fecha_nac='" & txtFecha.Text & "', genero='" & cbxGenero.Text & "', telefono='" & txtTelefono.Text & "', direccion='" & txtDireccion.Text & "' WHERE identificacion=" & Conversion.Int(txtID.Text) & "", con)
            comando.ExecuteNonQuery()
            MsgBox("Actualización Exitosa", MsgBoxStyle.Information, "Confirmar")
            BorrarCampos()
            MostrarDatos()
            btnAgregar.Enabled = True

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End If

    End Sub
#End Region

#Region "Eliminar"
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        'verificar que se haya seleccionado un campo en el dgv'
        If (txtID.Text = "") Or (txtNombre.Text = "") Or (txtApellido.Text = "") Or (txtFecha.Text = "") Or (cbxGenero.Text = "") Or (txtTelefono.Text = "") Or (txtDireccion.Text = "") Then
            MsgBox("No puede eliminarse, seleccione el campo que desea que se elimine", MsgBoxStyle.Information, "Confirmar")
        Else
            'eliminacion efetiva'
            Dim comando As New MySqlCommand("DELETE FROM contacto WHERE identificacion=" & Conversion.Int(txtID.Text) & "", con)
            comando.ExecuteNonQuery()
            MsgBox("Eliminacion Exitosa", MsgBoxStyle.Information, "Confirmar")
            BorrarCampos()
            MostrarDatos()
            btnAgregar.Enabled = True

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End If
    End Sub
#End Region

#Region "Guardar"
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'llamada al metodo'
        GuardarDatos()
    End Sub

    Private Sub GuardarDatos()
        Dim archivo_escritura As StreamWriter
        Dim linea As String
        'crear y asignar archivo en el que se guardaran los datos'
        archivo_escritura = New StreamWriter("./datos.txt")
        'recorrido del dgv y concatenacion de celda'
        With dgvContactos
            For y = 0 To .RowCount - 1
                linea = .Rows(y).Cells(0).Value & ";" &
                    .Rows(y).Cells(1).Value & ";" &
                    .Rows(y).Cells(2).Value & ";" &
                    .Rows(y).Cells(3).Value & ";" &
                    .Rows(y).Cells(4).Value & ";" &
                    .Rows(y).Cells(5).Value & ";" &
                    .Rows(y).Cells(6).Value & ";"
                archivo_escritura.WriteLine(linea)
            Next
            MsgBox("Datos guardados exitosamente", MsgBoxStyle.Information, "Informacion")
        End With
        archivo_escritura.Close()
    End Sub
#End Region

#Region "Salir"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        'confirmacion de salida'
        Dim confirmacion As String
        confirmacion = MsgBox("Antes de salir. ¿Deseas guardar los datos de manera local?", MsgBoxStyle.YesNo, "Informacion")
        If confirmacion = vbYes Then
            GuardarDatos()
        End If
        Me.Close()
    End Sub
#End Region

#Region "Borrar Texto de Text Box"
    'poner en blanco los textbox'
    Public Sub BorrarCampos()
        txtID.Text = ""
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtFecha.Text = ""
        cbxGenero.Text = ""
        txtTelefono.Text = ""
        txtDireccion.Text = ""
    End Sub
#End Region

#Region "Mostrar Datos en Data Grid View"
    'limpiar el dgv y sus controladores'
    Public Sub Consulta(ByVal sql As String, ByVal table As String)
        data.Tables.Clear()
        adapter = New MySqlDataAdapter(sql, con)
        cmb = New MySqlCommandBuilder(adapter)
        adapter.Fill(data, table)

    End Sub
    'traer datos de la bd al dgv'
    Public Sub MostrarDatos()
        Consulta("SELECT * FROM contacto", "contacto")
        dgvContactos.DataSource = data.Tables("contacto")

    End Sub
#End Region

#Region "Seleccionar Datos del Data Grid View"
    'permitir la seleccion de cada campo del dgv'
    Private Sub dgvContactos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvContactos.CellClick
        Dim i As Integer = dgvContactos.CurrentRow.Index
        txtID.Text = dgvContactos(0, i).Value
        txtNombre.Text = dgvContactos(1, i).Value
        txtApellido.Text = dgvContactos(2, i).Value
        txtFecha.Text = dgvContactos(3, i).Value
        cbxGenero.Text = dgvContactos(4, i).Value
        txtTelefono.Text = dgvContactos(5, i).Value
        txtDireccion.Text = dgvContactos(6, i).Value
        btnAgregar.Enabled = False
    End Sub


#End Region

#Region "Buscar Datos"

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        'buscar en la bd el contacto segun dato suministrado '
        Dim entrada As String = "SELECT * FROM contacto WHERE identificacion LIKE '%" & txtBusqueda.Text & "%' Or nombre LIKE '%" & txtBusqueda.Text & "%' Or apellido LIKE '%" & txtBusqueda.Text & "%' Or fecha_nac LIKE '%" & txtBusqueda.Text & "%' Or telefono LIKE '%" & txtBusqueda.Text & "%'"
        Dim adapter As New MySqlDataAdapter(entrada, con)
        data = New DataSet
        adapter.Fill(data)

        If con.State = ConnectionState.Closed Then
            con.Close()
        End If

        Try
            dgvContactos.DataSource = data.Tables(0)
        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class
