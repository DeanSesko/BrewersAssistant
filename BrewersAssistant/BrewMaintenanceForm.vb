Imports System.Data.SqlServerCe
Imports System.Configuration.ConfigurationManager

Public Class BrewMaintenanceForm
    Private Sub BrewMaintenanceForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataControl As String = "BeerName"
        Dim mysqlString As String = "Select BeerName from  BeerData"
        GetSQLDBData(mysqlString, DataControl)
        DataControl = "GrainName"
        mysqlString = "Select GrainName from Grains"
        GetSQLDBData(mysqlString, DataControl)
        DataControl = "Weights"
        mysqlString = "Select Mass from Weights"
        GetSQLDBData(mysqlString, DataControl)
        DataControl = "HopNames"
        mysqlString = "Select HopName from Hops order by HopName"
        GetSQLDBData(mysqlString, DataControl)
        DataControl = "WortNames"
        mysqlString = "Select WortAdditionName from WortAdditions order by WortAdditionName"
        GetSQLDBData(mysqlString, DataControl)
    End Sub
    Private Sub BeerNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BeerNameComboBox.SelectedIndexChanged
        HopDataGridView.DataSource = Nothing
        GrainDataGridView.DataSource = Nothing
        Dim BeernameString As String = BeerNameComboBox.Text
        BeernameString = BeernameString.Replace("'", "''")
        Dim mysqlString As String = "Select * from  beerdata where Beername='" & BeernameString & "'"
        Dim DataControl As String = "BeerData"
        GetSQLDBData(mysqlString, DataControl)
        mysqlString = "Select GrainBill.GrainBillID, Grains.GrainName, Grainbill.weight as Weight, Weights.mass as UNits, Grains.potentialsg, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
        DataControl = "Grains"
        LoadData(mysqlString, DataControl)
        mysqlString = "SELECT HopBill.HopBillID, Hops.HOPName as Name , Weights.Mass  as Units, HopBill.Weight, HopBill.AdditionTime as Time FROM Hops INNER JOIN HopBill ON Hops.HOPID = HopBill.HopID INNER JOIN BeerData ON HopBill.BeerID = BeerData.BeerID INNER JOIN Weights ON HopBill.WeightID = Weights.WeightID where BeerData.BeerID=' " & BeerIDTextBox.Text & "' order by AdditionTime desc"

        DataControl = "Hops"
        LoadData(mysqlString, DataControl)
        mysqlString = "Select WortAdditionBill.WortAdditionBillID, WortAdditions.WortAdditionName as Item, WortAdditionBill.Weight, Weights.Mass as Units , WortAdditionBill.AdditionTime as Time   FROM   WortAdditionBill INNER JOIN Weights ON WortAdditionBill.WeightID = Weights.WeightID INNER JOIN WortAdditions ON WortAdditionBill.WortAdditionID = WortAdditions.WortAdditionsID where WortAdditionBill.BeerID='" & BeerIDTextBox.Text & "'"
        DataControl = "Wort"
        LoadData(mysqlString, DataControl)
        DataControl = "GrainPotenialSQ"
        mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"

        GetSQLDBData(mysqlString, DataControl)
        mysqlString = "Select  stepmashID, RestTemp as Temperature , restTime from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'"
        DataControl = "StepMash"
        LoadData(mysqlString, DataControl)

    End Sub
    Private Sub DeleteBrewSessionData()
        If MessageBox.Show("Are you sure you want to delete this record? ", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
        ElseIf (Windows.Forms.DialogResult.Yes) Then
            If Not BeerNameComboBox.Text = "" Then
                Dim mysqlString As String = "Select SessionID from Brewsessions where beerID='" & BeerIDTextBox.Text & "'"
                Dim DataControl As String = "DeleteTemps"
                GetSQLDBData(mysqlString, DataControl)
                mysqlString = "Delete from HopBill where BeerID='" & BeerIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                mysqlString = "Delete from GrainBill where BeerID='" & BeerIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                mysqlString = "Delete from GrainBill where BeerID='" & BeerIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                mysqlString = "Delete from BrewSessions where BeerID='" & BeerIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                mysqlString = "Delete from beerdata where BeerID='" & BeerIDTextBox.Text & "'"
                UpdateDBSql(mysqlString)
                mysqlString = "Select BeerName from  beerdata"
                BeerNameComboBox.Items.Clear()
                BeerNameComboBox.Text = ""
                BeerIDTextBox.Text = ""
                GrainDataGridView.ClearSelection()
                HopDataGridView.ClearSelection()
                ClearAllFields()
                DataControl = "BeerName"
                GetSQLDBData(mysqlString, DataControl)
            End If
        End If
    End Sub
    Private Sub UpdateBrewsessiondata()
        Dim BeernameString As String = BeerNameComboBox.Text
        BeernameString = BeernameString.Replace("'", "''")
        Dim mysqlString As String = "Select * from  beerdata where Beername='" & BeernameString & "'"
        Dim MyDataSet As New DataSet
        Dim MyDataAdapter = New SqlCeDataAdapter(mysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCeCommandBuilder = New SqlCeCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        MyDataAdapter.Fill(MyDataSet, "beerdata")
        Dim BeerRow As DataRow = MyDataSet.Tables("beerdata").Rows(0)

        If DigitChecker(BatchSizeTextBox.Text) = True Then
            BeerRow("BatchSize") = BatchSizeTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Batch Size")
            GoTo MyExit
        End If

        If DigitChecker(WaterToGrainRatioTextBox.Text) = True Then
            BeerRow("WatertoGrainRatio") = WaterToGrainRatioTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Water to Grain Ratio")
            GoTo MyExit
        End If

      



        If DigitChecker(BoilTimeTextBox.Text) = True Then
            BeerRow("BoilTime") = BoilTimeTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Boil Temp")
            GoTo MyExit
        End If



        If DigitChecker(SpargeTemptextbox.Text) = True Then
            BeerRow("SpargeTemp") = SpargeTemptextbox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Sparge Temperature")
            GoTo MyExit

        End If
        If DigitChecker(VersionTextBox.Text) = True Then
            BeerRow("Version") = VersionTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Version Number")
            GoTo MyExit

        End If
        If DigitChecker(FermentationTempBox.Text) = True Then
            BeerRow("FermentationTemp") = FermentationTempBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Fermentation Temperature")
            GoTo MyExit

        End If
        If DigitChecker(FGravityTextBox.Text) = True Then
            BeerRow("RequiredFinalGravity") = FGravityTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Final Gravity")
            GoTo MyExit

        End If
        If DigitChecker(OGravityTextBox.Text) = True Then
            BeerRow("RequiredOriginalGravity") = OGravityTextBox.Text
        Else
            MsgBox("Please Enter A Valid Value for:  Original Gravity")
            GoTo MyExit
        End If

        If DigitChecker(BrewhouseEfficiencyBox.Text) = True Then
            BeerRow("BrewHouseEfficiencies") = (BrewhouseEfficiencyBox.Text / 100)
        Else
            MsgBox("Please Enter A Valid Value for:  Brewhouse Efficiency")
            GoTo MyExit
        End If

        If Not NotesTextBox.Text = "" Then
            BeerRow("Notes") = NotesTextBox.Text
        End If
        If Not MashTypeComboBox.Text = "" Then

            BeerRow("MashType") = MashTypeComboBox.Text
        End If

        Try
            MyDataAdapter.Update(MyDataSet, "beerdata")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MyDataSet = Nothing
        MyDataAdapter = Nothing

MyExit:
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        UpdateBrewsessiondata()
    End Sub
    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        DeleteBrewSessionData()
    End Sub
    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
    Private Sub ClearAllFields()
        BeerNameComboBox.Text = ""
        BatchSizeTextBox.Text = ""
        WaterToGrainRatioTextBox.Text = ""
        SpargeTemptextbox.Text = ""
        BoilTimeTextBox.Text = ""
        VersionTextBox.Text = ""
        BeerIDTextBox.Text = ""
        FermentationTempBox.Text = ""
        OGravityTextBox.Text = ""
        FGravityTextBox.Text = ""
        NotesTextBox.Text = ""
        SpargeTemptextbox.Text = ""
    End Sub
    Private Sub cleargraininfo()
        OriginLabel.Text = ""
        TypeLabel.Text = ""
        SRMLabel.Text = ""
        PotentialSG.Text = ""
    End Sub
    Private Sub GrainListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim mysqlString As String = "Select * from  BeerGrainBillView where GrainName='" & GrainWeightComboBox.Text & "'"
        Dim DataControl As String = "GrainBillID"
        GetSQLDBData(mysqlString, DataControl)
    End Sub
    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        NewBrewRecord()
    End Sub
    Private Sub NewBrewRecord()
        Dim NewBeerName As String = InputBox("Please Enter a New Name for this Beer")
        NewBeerName = NewBeerName.Replace("'", "''")
        If Not NewBeerName = "" Then
            Dim mysqlString As String = "Insert into beerdata(BeerName) Values('" & NewBeerName & "')"
            UpdateDBSql(mysqlString)
            BeerNameComboBox.Items.Clear()
            ClearAllFields()
            cleargraininfo()
            Dim DataControl As String = "BeerName"
            mysqlString = "Select BeerName from  BeerData"
            GetSQLDBData(mysqlString, DataControl)
        End If

    End Sub


    Private Sub GrainNameComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrainNameComboBox.SelectedIndexChanged
        cleargraininfo()
        Dim mysqlString As String = "Select * from  Grains where GrainName='" & GrainNameComboBox.Text & "'"
        Dim DataControl As String = "Grains"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub WeightComboBox_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrainWeightComboBox.SelectedIndexChanged
        Dim mysqlString As String = "Select * from  Weights where mass='" & GrainWeightComboBox.Text & "'"
        Dim DataControl As String = "GrainWeightsID"
        GetSQLDBData(mysqlString, DataControl)
    End Sub
   
    Private Sub RemoveGrainButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveGrainButton.Click
        Try
            Dim mysqlString As String = "Delete From GrainBill where GrainBillID='" & GrainDataGridView.Item(0, GrainDataGridView.CurrentRow.Index).Value & "'"
            UpdateDBSql(mysqlString)
            mysqlString = "Select GrainBillID , GrainName as Name, GrainBill.weight as Weight, Mass as Units, GrainBill.weightid  FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"

            Dim DataControl As String = "Grains"
            LoadData(mysqlString, DataControl)
            DataControl = "GrainPotenialSQ"
            mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"


            GetSQLDBData(mysqlString, DataControl)
        Catch
        End Try

    End Sub

    Private Sub RemoveSelectedHopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveSelectedHopButton.Click
        Dim mysqlString As String = "Delete From HopBill where HopBillID='" & HopDataGridView.Item(0, HopDataGridView.CurrentRow.Index).Value & "'"
        UpdateDBSql(mysqlString)
        mysqlString = "SELECT HopBill.HopBillID, Hops.HOPID, Hops.HOPName as Hop , BeerData.BeerID, HopBill.WeightID, Weights.Mass  as Units , HopBill.Weight, HopBill.AdditionTime as Time FROM Hops INNER JOIN HopBill ON Hops.HOPID = HopBill.HopID INNER JOIN BeerData ON HopBill.BeerID = BeerData.BeerID INNER JOIN Weights ON HopBill.WeightID = Weights.WeightID where BeerData.BeerID=' " & BeerIDTextBox.Text & "' order by AdditionTime desc"
        Dim DataControl As String = "Hops"
        LoadData(mysqlString, DataControl)
    End Sub
    Private Sub GetSQLDBData(ByVal MySqlString As String, ByVal DataControl As String)
        Dim sqlConnection As New SqlCeConnection(My.Settings.BrewHelperDBConnectionString)
        Dim sqlCommand As New SqlCeCommand()
        sqlConnection.Open()
        sqlCommand.Connection = sqlConnection
        sqlCommand.CommandText = MySqlString
        Dim myReader As SqlCeDataReader = sqlCommand.ExecuteReader()


        If DataControl = "BeerName" Then
            While myReader.Read()
                BeerNameComboBox.Items.Add(myReader.Item("BeerName"))
            End While
        

        ElseIf DataControl = "DeleteTemps" Then
            While myReader.Read()

                MySqlString = "Delete from Temperatures where SessionID='" & myReader.Item("SessionID") & "'"
                UpdateDBSql(MySqlString)
            End While
        ElseIf DataControl = "BeerData" Then
            While myReader.Read()
                BeerIDTextBox.Text = myReader.Item("BeerID").ToString
                BatchSizeTextBox.Text = myReader.Item("BatchSize").ToString
                WaterToGrainRatioTextBox.Text = myReader.Item("WatertoGrainRatio").ToString
               BoilTimeTextBox.Text = myReader.Item("BoilTime").ToString
                VersionTextBox.Text = myReader.Item("Version").ToString
                NotesTextBox.Text = myReader.Item("Notes").ToString
                SpargeTemptextbox.Text = myReader.Item("SpargeTemp").ToString
                OGravityTextBox.Text = myReader.Item("RequiredOriginalGravity").ToString
                FGravityTextBox.Text = myReader.Item("RequiredFinalGravity").ToString
                FermentationTempBox.Text = myReader.Item("FermentationTemp").ToString
                MashTypeComboBox.Text = myReader.Item("MashType").ToString
            End While
        ElseIf DataControl = "GrainName" Then
            While myReader.Read()
                GrainNameComboBox.Items.Add(myReader.Item("GrainName"))
            End While

        ElseIf DataControl = "GrainPotenialSQ" Then
          
            Dim MYGrainptsindex As Decimal = 0
            Dim myGrainWeight2 As Decimal = 0
            Dim myWeightID As Integer
            Dim GrainPotential As Decimal
            Dim MYTotalGrainpts As Decimal

            While myReader.Read()
                myWeightID = myReader.Item("weightID")
                MYGrainptsindex = myReader.Item("potentialSG")
                If Not MYGrainptsindex = 0 Then
                    MYGrainptsindex = (MYGrainptsindex - 1) * 1000
                End If
                If myWeightID = 1 Then
                    myGrainWeight2 = myGrainWeight2 + myReader.Item("Weight")
                    GrainPotential = (MYGrainptsindex * myReader.Item("Weight")) / CDec(BatchSizeTextBox.Text)
                ElseIf myWeightID = 2 Then
                    myGrainWeight2 = myGrainWeight2 + (myReader.Item("Weight") / 16)
                    GrainPotential = (MYGrainptsindex * (myReader.Item("Weight") / 16)) / CDec(BatchSizeTextBox.Text)
                End If
                MYTotalGrainpts = MYTotalGrainpts + GrainPotential
                MYGrainptsindex = 0
                GrainPotential = 0
            End While
            Dim myGrainPotentialSG As Decimal = Math.Round(MYTotalGrainpts / 1000, 3) * (CDec(BrewhouseEfficiencyBox.Text) / 100) + 1
            GrainPotentialLabel.Text = Math.Round(myGrainPotentialSG, 3)


        ElseIf DataControl = "Grains" Then


                While myReader.Read()
                OriginLabel.Text = myReader.Item("Origin").ToString
                    OriginLabel.Visible = True
                    OriginLabel.Text = myReader.Item("Type").ToString
                    TypeLabel.Visible = True
                    SRMLabel.Text = myReader.Item("ColorSRM").ToString
                    SRMLabel.Visible = True
                    PotentialSG.Text = myReader.Item("PotentialSG").ToString
                    PotentialSG.Visible = True
                    GrainID.Text = myReader.Item("GrainID").ToString
                End While
        ElseIf DataControl = "GrainWeight" Then
                Dim myGrainWeight As Decimal = 0
                Dim myWeightID As Integer
                While myReader.Read()
                    Try
                        myWeightID = myReader.Item("weightID")

                        If myWeightID = 1 Then
                            myGrainWeight = myGrainWeight + myReader.Item("Weight")
                        ElseIf myWeightID = 2 Then
                            myGrainWeight = myGrainWeight + (myReader.Item("Weight") / 16)
                        End If

                    Catch
                    End Try
                End While
                GrainWeightLabel.Text = Math.Round(myGrainWeight, 2)

        ElseIf DataControl = "HopWeight" Then
                Dim myHopWeight As Decimal = 0
                Dim myWeightID As Integer
                While myReader.Read()
                    Try
                        myWeightID = myReader.Item("weightID")
                        If myWeightID = 1 Then
                            myHopWeight = myHopWeight + (myReader.Item("Weight") * 16)
                        ElseIf myWeightID = 2 Then
                            myHopWeight = myHopWeight + myReader.Item("Weight")
                        End If
                    Catch
                    End Try

                End While
                hopWeightLabel.Text = Math.Round(myHopWeight, 2)
        ElseIf DataControl = "Weights" Then
                While myReader.Read()

                    GrainWeightComboBox.Items.Add(myReader.Item("Mass").ToString)
                    HopsWeightComboBox.Items.Add(myReader.Item("Mass").ToString)
                    MiscWortAddWeightUnitComboBox.Items.Add(myReader.Item("Mass").ToString)
                End While
        ElseIf DataControl = "GrainWeightsID" Then
                While myReader.Read()

                    GrainWeightID.Text = myReader.Item("WeightID").ToString
                End While
        ElseIf DataControl = "HopWeightsID" Then
                While myReader.Read()

                    HopWeightIDLabel.Text = myReader.Item("WeightID").ToString
                End While

        ElseIf DataControl = "MiscWortWeightsID" Then
                While myReader.Read()

                    MiscWeightIDLabel.Text = myReader.Item("WeightID").ToString
                End While

        ElseIf DataControl = "HopNames" Then
                While myReader.Read()
                    HopNameComboBox.Items.Add(myReader.Item("HopName").ToString)
                End While

        ElseIf DataControl = "Hops" Then
                While myReader.Read()
                    HopIDLabel.Text = myReader.Item("HopID").ToString
                End While
        ElseIf DataControl = "WortNames" Then
                While myReader.Read()
                    MiscWortAddNameComboBox.Items.Add(myReader.Item("WortAdditionName").ToString)
                End While
        ElseIf DataControl = "WortItems" Then
                While myReader.Read()
                    MiscWortIDLabel.Text = myReader.Item("WortAdditionsID").ToString

                End While
        End If

                myReader = Nothing

                sqlConnection.Close()
    End Sub
    Private Sub HopComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HopNameComboBox.SelectedIndexChanged
        Dim HopName As String = HopNameComboBox.Text
        HopName = HopName.Replace("'", "''")
        Dim mysqlString As String = "Select * from  Hops where HopName='" & HopName & "'"
        Dim DataControl As String = "Hops"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub HopsWeightComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HopsWeightComboBox.SelectedIndexChanged
        Dim mysqlString As String = "Select * from  Weights where mass='" & HopsWeightComboBox.Text & "'"
        Dim DataControl As String = "HopWeightsID"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub AddHopsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddHopsButton.Click
        If Not HopNameComboBox.Text = "" Then
            If Not HopWeightTextBox.Text = "" Then
                If DigitChecker(HopWeightTextBox.Text) Then
                    If DigitChecker(HopWeightIDLabel.Text) Then
                        If DigitChecker(HopTimeTextBox.Text) Then
                            Try
                                Dim mysqlString As String = "Insert into HopBill(BeerID,HopID,Weight,WeightID,AdditionTime) Values('" & CInt(BeerIDTextBox.Text) & "','" & CInt(HopIDLabel.Text) & "','" & CDec(HopWeightTextBox.Text) & "','" & CDec(HopWeightIDLabel.Text) & "','" & CDec(HopTimeTextBox.Text) & "')"
                                UpdateDBSql(mysqlString)
                                mysqlString = "SELECT BeerData.BeerID, HopBill.WeightID, HopBill.Weight, HopBill.AdditionTime FROM Hops INNER JOIN HopBill ON Hops.HOPID = HopBill.HopID INNER JOIN BeerData ON HopBill.BeerID = BeerData.BeerID INNER JOIN Weights ON HopBill.WeightID = Weights.WeightID where BeerData.BeerID=' " & BeerIDTextBox.Text & "' order by AdditionTime desc"

                                Dim DataControl As String = "Hops"
                                LoadData(mysqlString, DataControl)
                            Catch
                                MsgBox("Hop Add Problem")
                            End Try
                        Else
                            MsgBox("Please Enter A valid time for the Addition of the Hop")
                        End If
                    Else
                        MsgBox("Please Select a Valid Wight Unit of Measurement")
                    End If
                Else
                    MsgBox("Please Enter A Weight")
                End If

            Else
                MsgBox("Please Enter A Weight")
            End If
        Else
            MsgBox("Please Enter A Valid Hop Name")
        End If
    End Sub
    Private Sub AddGrainstoBeerButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddGrainsButton.Click
        If Not BeerNameComboBox.Text = "" Then
            If Not GrainWeightTextBox.Text = "" Then
                If Not GrainWeightID.Text = "" Then
                    Try
                        Dim mysqlString As String = "Insert into GrainBill(BeerID,GrainID,Weight,WeightID) Values('" & CInt(BeerIDTextBox.Text) & "','" & CInt(GrainID.Text) & "','" & CDec(GrainWeightTextBox.Text) & "','" & CDec(GrainWeightID.Text) & "')"
                        UpdateDBSql(mysqlString)
                        '  mysqlString = "Select GrainBillID , GrainName as 'Grain Name', weight as 'Weight', Mass as 'Units', WeightID from  BeerGrainBillView where BeerID='" & BeerIDTextBox.Text & "'"
                        mysqlString = "Select GrainBill.GrainBillID, Grains.GrainName as  Name,  GrainBill.weight, Weights.Mass as Units  FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where GrainBill.BeerID='" & BeerIDTextBox.Text & "'"

                        Dim DataControl As String = "Grains"
                        LoadData(mysqlString, DataControl)
                        DataControl = "GrainPotenialSQ"
                        mysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"
                        GetSQLDBData(mysqlString, DataControl)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub AddMiscWortItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddMiscWortItemButton.Click
        If Not MiscWortAddNameComboBox.Text = "" Then
            If Not MiscWortAmountTextBox.Text = "" Then
                If IsNumeric(MiscWortAmountTextBox.Text) Then
                    If IsNumeric(MiscWeightIDLabel.Text) Then
                        If IsNumeric(MiscWortTimeTextBox.Text) Then
                            Try
                                Dim mysqlString As String = "Insert into WortAdditionBill(BeerID,WortAdditionID,Weight,WeightID,AdditionTime) Values('" & _
                                CInt(BeerIDTextBox.Text) & "','" & CInt(MiscWortIDLabel.Text) & "','" & CDec(MiscWortAmountTextBox.Text) & "','" & CDec(MiscWeightIDLabel.Text) & "','" & CDec(MiscWortTimeTextBox.Text) & "')"
                                UpdateDBSql(mysqlString)
                                mysqlString = "Select WortAdditionBillID, WortAdditionName as 'Item Name', Weight, Mass as 'Units'from  BeerWortBillView where BeerID='" & BeerIDTextBox.Text & "'"
                                Dim DataControl As String = "Wort"
                                LoadData(mysqlString, DataControl)
                            Catch
                                MsgBox("Wort Add Problem")
                            End Try
                        Else
                            MsgBox("Please Enter A valid time for the Addition of the Item")
                        End If
                    Else
                        MsgBox("Please Select a Valid Wight Unit of Measurement")
                    End If
                Else
                    MsgBox("Please Enter A Weight")
                End If

            Else
                MsgBox("Please Enter A Weight")
            End If
        Else
            MsgBox("Please Enter A Valid Item Name")
        End If
    End Sub

    Private Sub MiscWortAddNameComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscWortAddNameComboBox.SelectedIndexChanged
        Dim MiscWOrtItem As String = MiscWortAddNameComboBox.Text
        MiscWOrtItem = MiscWOrtItem.Replace("'", "''")
        Dim mysqlString As String = "Select * from  WortAdditions where WortAdditionName='" & MiscWOrtItem & "'"
        Dim DataControl As String = "WortItems"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub MiscWortAddWeightUnitComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiscWortAddWeightUnitComboBox.SelectedIndexChanged
        Dim mysqlString As String = "Select * from  Weights where mass='" & MiscWortAddWeightUnitComboBox.Text & "'"
        Dim DataControl As String = "MiscWortWeightsID"
        GetSQLDBData(mysqlString, DataControl)
    End Sub

    Private Sub RemoveMiscWortItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveMiscWortItemButton.Click
        Dim mysqlString As String = "Delete From WortAdditionBill where WortAdditionBillID='" & MiscWortDataGridView.Item(0, MiscWortDataGridView.CurrentRow.Index).Value & "'"
        UpdateDBSql(mysqlString)
        mysqlString = "Select WortAdditionBillID, WortAdditionName as 'Item Name', Weight, Mass as 'Units'from  BeerWortBillView where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControl As String = "Wort"
        LoadData(mysqlString, DataControl)
    End Sub

    Private Sub AddStepMashButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStepMashButton.Click
        If Not StepMashTempBox.Text = "" Then
            If Not StepMashTimeBox.Text = "" Then
                If IsNumeric(StepMashTempBox.Text) Then
                    If IsNumeric(StepMashTimeBox.Text) Then
                        Try
                            Dim mysqlString As String = "Insert into StepMashTable(BeerID,RestTime,RestTemp) Values('" & _
                            CInt(BeerIDTextBox.Text) & "','" & CInt(StepMashTimeBox.Text) & "','" & CDec(StepMashTempBox.Text) & "')"
                            UpdateDBSql(mysqlString)
                            mysqlString = "Select  stepmashID, RestTemp as 'Temperature' , restTime from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'"
                            Dim DataControl As String = "StepMash"
                            LoadData(mysqlString, DataControl)
                        Catch
                            MsgBox("Step Mash Add Problem")
                        End Try
                    Else
                        MsgBox("Please Enter A valid time for the Rest")
                    End If
                Else
                    MsgBox("Please Select a Valid Temperature Unit of Measurement")
                End If

            Else
                MsgBox("Please Enter A valid time for the Rest")
            End If
        Else
            MsgBox("Please Enter A Valid Rest ")
        End If
    End Sub

    Private Sub LoadData(ByVal MysqlString As String, ByVal DataControl As String)
        Dim MyDataAdapter = New SqlCeDataAdapter(MysqlString, My.Settings.BrewHelperDBConnectionString)
        Dim cmd As SqlCeCommandBuilder = New SqlCeCommandBuilder(MyDataAdapter)
        MyDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Dim ds As New DataSet()
        '   Try
        If DataControl = "Hops" Then

            If (MyDataAdapter.Fill(ds) > 0) Then
                HopDataGridView.DataSource = ds.Tables(0)
                HopDataGridView.Columns.Item(0).Visible = False
            End If
            MysqlString = "SELECT BeerData.BeerID, HopBill.WeightID, HopBill.Weight, HopBill.AdditionTime FROM Hops INNER JOIN HopBill ON Hops.HOPID = HopBill.HopID INNER JOIN BeerData ON HopBill.BeerID = BeerData.BeerID INNER JOIN Weights ON HopBill.WeightID = Weights.WeightID where BeerData.BeerID=' " & BeerIDTextBox.Text & "' order by AdditionTime desc"

            DataControl = "HopWeight"
            GetSQLDBData(MysqlString, DataControl)

        ElseIf DataControl = "Grains" Then

            If (MyDataAdapter.Fill(ds) > 0) Then
                GrainDataGridView.DataSource = ds.Tables(0)
                GrainDataGridView.Columns.Item(0).Visible = False
            End If

            MysqlString = "Select Grains.potentialSG, GrainBill.weight, GrainBill.weightID FROM GrainBill INNER JOIN Grains ON GrainBill.GrainID =  Grains.GrainID INNER JOIN Weights ON GrainBill.WeightID = Weights.WeightID  where BeerID='" & BeerIDTextBox.Text & "'"

            DataControl = "GrainWeight"
            GetSQLDBData(MysqlString, DataControl)

        ElseIf DataControl = "Wort" Then

            If (MyDataAdapter.Fill(ds) > 0) Then
                MiscWortDataGridView.DataSource = ds.Tables(0)
                MiscWortDataGridView.Columns.Item(0).Visible = False
            End If

        ElseIf DataControl = "StepMash" Then
            If (MyDataAdapter.Fill(ds) > 0) Then
                StepMashDataGridView.Visible = True
                StepMashDataGridView.DataSource = ds.Tables(0)
                StepMashDataGridView.Columns.Item(0).Visible = False
            Else
                StepMashDataGridView.Visible = False

            End If
        End If
        ' Catch ex As Exception
        '    MessageBox.Show("Error connecting to the database")
        ' End Try
    End Sub


    Private Sub RemoveRestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveRestButton.Click
        Dim mysqlString As String = "Delete From StepMashTable where StepMashID='" & StepMashDataGridView.Item(0, StepMashDataGridView.CurrentRow.Index).Value & "'"
        UpdateDBSql(mysqlString)
        mysqlString = "Select  StepMashID, RestTemp as 'Temperature' , restTime from  StepMashTable where BeerID='" & BeerIDTextBox.Text & "'"
        Dim DataControl As String = "StepMash"
        LoadData(mysqlString, DataControl)

    End Sub


    Private Sub AddCustomHopsButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomHopsButton.Click
        HopNameComboBox.Items.Clear()
        ShowNewForm(CustomHopForm)
    End Sub

    Private Sub AddCustomWortItemButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomWortItemButton.Click
        MiscWortAddNameComboBox.Items.Clear()
        ShowNewForm(CustomWortAdditionForm)
    End Sub
    Private Sub AddCustomGrains_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddCustomGrainsButton.Click
        ShowNewForm(CustomGrainsForm)
    End Sub

 

End Class