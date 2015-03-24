Imports System.Net
Imports System.Net.WebRequestMethods

Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getSelectedState()
        '' request conditions for the String city that the user enters 

        ' so we will need a string to add to the end of the url request. 
        Dim user_EnterCityToSearchFor As String
        txtBoxCityNameSearch.Text = user_EnterCityToSearchFor

        Dim testURL As String = http://api.wunderground.com/api/ede6553743c4d570/conditions/q/MN/Minneapolis.xml

        ' dim a web request 
        Dim webRequestWeatherRequest As WebRequest = WebRequest.Create(testURL)

        'build the URL reuqest starting with the necessary componenets minus the state and city.  
        Dim urlRequest_State As String = ComboBoxDropDownState.SelectedText '  
        Dim urlRequest_city As String = txtBoxCityNameSearch.Text
        Dim url_RequestFullyBuilt As String

        Dim url_Built As String = "http://api.wunderground.com/api/ede6553743c4d570/conditions/q/" + urlRequest_State + "/" + urlRequest_city + ".xml"
        '' this is the url + state from the selected dropbox 

        '' need code for the dropdown box. So lets build a function to get the selected results in the dropdown state box  ** TESTING wORK IN PROGRESS **
    End Sub


    Public Function getSelectedState() As String '' this may need to be converted to a url type later 
        ' dim state as a two letter string 
        Dim urlStateSelected As String '' just initialized. Should not fall out of 
        If ComboBoxDropDownState.SelectedItem Is "State" Then
            '' If urlStateSelected = "--" Then
            MessageBox.Show("Please select a state before continueing", "Error! ")

        Else

            ComboBoxDropDownState.SelectedItem = urlStateSelected

        End If
        Return urlStateSelected
    End Function


End Class

'' still need to confirm that i have built the city request right 
'' get the api url request for 3 day for cast 
'' interpet the information. 