Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.IO
Imports System.Xml

Public Class Form1




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '' create a new instance of the object to search for. as newSearchComponents
        Dim newSearchComponents As New SearchComponents
        newSearchComponents.getUserEnteredCity = txtBoxCityNameSearch.Text
        newSearchComponents.getSelectedState = CStr(ComboBoxDropDownState.SelectedItem())


        '' check to see if this is working 
        MessageBox.Show(newSearchComponents.ToString)

        '' request conditions for the String city that the user enters 

        ' so we will need a string to add to the end of the url request. 
        Dim user_EnterCityToSearchFor As String
        txtBoxCityNameSearch.Text = user_EnterCityToSearchFor

        Dim testURL As String = "http://api.wunderground.com/api/ede6553743c4d570/conditions/q/MN/Minneapolis.xml"

        ' dim a web request 
        Dim webRequestWeatherRequest As WebRequest = WebRequest.Create(testURL)


        '' the response from the website will come back as a stream. So this variable will store it. 
        '  Dim conditionsResponseStream As Stream = webRequestWeatherRequest.GetResponse.GetResponseStream()


        '' this variable stores the document as an xml document to get the info from. 
        'Dim xmlWeatherReader As XmlDocument
        'xmlWeatherReader.Load(conditionsResponseStream)



        ''build the URL reuqest starting with the necessary componenets minus the state and city.  
        'Dim urlRequest_State As String = ComboBoxDropDownState.SelectedText '  
        'Dim urlRequest_city As String = txtBoxCityNameSearch.Text
        'Dim url_RequestFullyBuilt As String

        'Dim url_Built_readyToSendrequest As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/" + urlRequest_State + "/" + urlRequest_city + ".json"
        ' '' this is the url + state from the selected dropbox 

        '' need code for the dropdown box. So lets build a function to get the selected results in the dropdown state box  ** TESTING wORK IN PROGRESS **
    End Sub


   


End Class

'' still need to confirm that i have built the city request right 
'' get the api url request for 3 day for cast 
'' interpet the information. 