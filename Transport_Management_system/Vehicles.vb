
Public Class Vehicles
    Private Sub VehicleDGV_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles VehicleDGV.CellContentClick
        LPlateTb.Text = VehicleDGV.SelectedRows(0).Cells(1).Value.ToString()
        MarkCb.SelectedItem = VehicleDGV.SelectedRows(0).Cells(2).Value.ToString()
        ModelTb.Text = VehicleDGV.SelectedRows(0).Cells(3).Value.ToString()
        VYearCb.SelectedItem = VehicleDGV.SelectedRows(0).Cells(4).Value.ToString()
        EngTypeCb.SelectedItem = VehicleDGV.SelectedRows(0).Cells(5).Value.ToString()
        ColorTb.Text = VehicleDGV.SelectedRows(0).Cells(6).Value.ToString()
        MilleageTb.Text = VehicleDGV.SelectedRows(0).Cells(7).Value.ToString()
        TypeCb.SelectedItem = VehicleDGV.SelectedRows(0).Cells(8).Value.ToString()
        BookedCb.SelectedItem = VehicleDGV.SelectedRows(0).Cells(9).Value.ToString()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        SqlConnection Dim = New SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\parth\OneDrive\Documents\TransportDb.mdf;Integrated Security=True;Connect Timeout=30");

        If LPlateTb.Text Is "" OrElse MarkCb.SelectedIndex = -1 OrElse ModelTb.Text Is "" OrElse VYearCb.SelectedIndex = -1 OrElse EngTypeCb.SelectedIndex = -1 OrElse ColorTb.Text Is "" OrElse MilleageTb.Text Is "" OrElse TypeCb.SelectedIndex = -1 OrElse BookedCb.SelectedIndex = -1 Then
            MessageBox.Show("Missing Information")
        Else
            Try
                Dim.Open()
                Dim cmd As SqlCommand = New SqlCommand("insert into VehiclesTb1 (VLp,Vmark,Vmodel,VYear,VEngType,VColor,VMilleage,VType,Booked,Driver) values(@VP,@Vma,@Vmo,@VY,@VEng,@VCo,@VMi,@VTy,@VB,@DR)", Con)
                cmd.Parameters.AddWithValue("@VP", LPlateTb.Text)
                cmd.Parameters.AddWithValue("@Vma", MarkCb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@Vmo", ModelTb.Text)
                cmd.Parameters.AddWithValue("@VY", VYearCb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@VEng", EngTypeCb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@VCo", ColorTb.Text)
                cmd.Parameters.AddWithValue("@VMi", MilleageTb.Text)
                cmd.Parameters.AddWithValue("@VTY", TypeCb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@VB", BookedCb.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@DR", DriverCb.SelectedValue.ToString())

                cmd.ExecuteNonQuery()
                MessageBox.Show("Vehicle Recorded")
                Dim.Close()
                ShowVehicles()
                Clear()
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try

        End If
    End Sub
End Class