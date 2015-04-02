Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.IO
Imports System.Xml

Public Class Form1


    '' when this button is clicked it should build a string and update the lables to show the string built 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("button has been clicked")
        ' create a new instance of the object to search for. as newSearchComponents
        Dim newSearchComponents As New SearchComponents
        '' call the class methods to get the necessary property values 
        newSearchComponents.getUserEnteredCity = txtBoxCityNameSearch.Text
        Try
            newSearchComponents.getSelectedState = CStr(ComboBoxDropDownState.SelectedItem())
        Catch noStateSelected As NullReferenceException
            MessageBox.Show("Please select a state from the state dropdown box")
        End Try
        '' we have the information in the textbox if inputted correctly. ask the background worker to make the request 

        'Dim url_Built_readyToSendrequest As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/" + newSearchComponents.ToString + ".xml"


        Dim searchCityForLable As String = ("Search City : " + newSearchComponents.getUserEnteredCity + " State: " + newSearchComponents.getSelectedState + " results")

        cityToBeDisplayedLabel.Text = searchCityForLable
        '' request conditions for the String city that the user enters 

        '' update the label for user to know something is happening. 
        cityToBeDisplayedLabel.Text = CStr(searchCityForLable)
        statusLabel.Text = ("Sending Request....")

        ' '' check to see if this is working 
        ' ''    MessageBox.Show(newSearchComponents.ToString)
        'cityToBeDisplayedLabel.Text = searchCityForLable
        ' '' request conditions for the String city that the user enters 

        '' so we will need a string to add to the end of the url request. 
        'Dim user_EnterCityToSearchFor As String
        'txtBoxCityNameSearch.Text = user_EnterCityToSearchFor
        '' the original url sample used in class ( returns xml ) 
        ''        Dim testURL As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/MN/Minneapolis.xml"

        ' dim a web request 
        '      Dim webRequestWeatherRequest As WebRequest = WebRequest.Create(testURL)


        '' the response from the website will come back as a stream. So this variable will store it. 
        'Try
        '    '    Dim forecastResponseStream As Stream = webRequestWeatherRequest.GetResponse.GetResponseStream()
        'Catch connectionProblem As WebException
        '    '' MessageBox.Show("Problem establishing connection")
        'End Try


        '' this variable stores the document as an xml document to get the info from. 
        'Dim xmlWeatherReader As XmlDocument
        'xmlWeatherReader.Load(conditionsResponseStream)


        ''      cityToBeDisplayedLabel.Text = CStr(searchCityForLable)
        ''build the URL reuqest starting with the necessary componenets minus the state and city.  
        'Dim urlRequest_State As String = ComboBoxDropDownState.SelectedText '  
        'Dim urlRequest_city As String = txtBoxCityNameSearch.Text
        'Dim url_RequestFullyBuilt As String


        '' builds the request for the forcast with user input.                           //! DOES NOT CHECK FOR ANY USER ERRORS YET !//
        ''    Dim url_Built_readyToSendrequest As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/" + newSearchComponents.ToString + ".xml"
        ' '' this is the url + state from the selected dropbox 

        ''  MessageBox.Show("Here is the link to your weather forecast :. " + url_Built_readyToSendrequest)

        '' do work handler 

        Dim url_Built_readyToSendrequest As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/MN/Minneapolis.xml"
        'If Not currentWeatherBackgroundWorker.IsBusy Then
        '    currentWeatherBackgroundWorker_DoWork.RunWorkerAsync(url_Built_readyToSendrequest)
        'End If
        Dim webIconRequest As WebRequest = WebRequest.Create(url_Built_readyToSendrequest)
        Dim webIconReSPONSE As Stream = webIconRequest.GetResponse.GetResponseStream()

        '' prepare a spot for the image 
        Dim iconImage As Image = Image.FromStream(webIconReSPONSE)
        '' the result of this even will be an image. display that image. 
        Dim forcastIconImage As Image = CType(iconImage, Image)
        PictureBox1(forcastIconImage)
        PictureBox1.Size.Height = 600
        PictureBox1.Size.Width = 600



    End Sub

    '' now start reading in the 3 day forecast for the requested city. 
    Private Function Forecast() As String
        Throw New NotImplementedException
    End Function





    Private Sub currentWeatherBackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles currentWeatherBackgroundWorker.DoWork

        '' create a new instance of the object to search for. as newSearchComponents
        'Dim newSearchComponents As New SearchComponents
        'newSearchComponents.getUserEnteredCity = txtBoxCityNameSearch.Text
        'newSearchComponents.getSelectedState = CStr(ComboBoxDropDownState.SelectedItem())

        'Dim searchCityForLable As String = ("Search City : " + newSearchComponents.getUserEnteredCity + " State: " + newSearchComponents.getSelectedState + " results")

        '' check to see if this is working 
        ''    MessageBox.Show(newSearchComponents.ToString)
        'cityToBeDisplayedLabel.Text = searchCityForLable
        ' '' request conditions for the String city that the user enters 

        ' '' update the label for user to know something is happening. 
        'cityToBeDisplayedLabel.Text = CStr(searchCityForLable)

        '   Dim url_Built_readyToSendrequest As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/" + newSearchComponents.ToString + ".xml"
        '' pass the built url and convert it to a string 

        '' this builds the request for the icon image 
        '' still need to build the request for the icon image for that specific day 
        ''do i need to build a hashtalbe map of how the arguments should be requested ?
        ''
        ''      Dim weatherIconURL As String CStr(e.Argument)  // ~~~~~~~~~~~~~~~~~~ FIX THIS STATEMENT AND  LINK IT TO THE WEATHER ICON URL 

        '' from slide 30
        '' here is the test url 
        Dim url As String = CStr(e.Argument)

        '    Dim webIconRequest As WebRequest = WebRequest.Create(Forecast)
        '    Dim webIconReSPONSE As Stream = webIconRequest.GetResponse.GetResponseStream()

        '    '' prepare a spot for the image 
        '    Dim iconImage As Image = Image.FromStream(webIconReSPONSE)
        '    '' the result of this even will be an image. display that image. 
        '    Try
        '        e.Result = iconImage
        '    Catch errorDisplayingImage As BadImageFormatException
        '    End Try
        'End Sub

        '    Dim url_built As String = "http://api.wunderground.com/api/ede6553743c4d570/forecast/q/" + newSearchComponents.toString + ".xml"
        '    url_built = CStr(e.Argument)
        '    '' crerate the web request to send 
        '    Dim webForecastRequestConditions As WebRequest = WebRequest.Create(url_built)
        '    '' create a variable to hand the response using previously built conditions request. 
        '    Dim forecastResponseStream As Stream = webForecastRequestConditions.GetResponse.GetResponseStream()

        '    '' create a new xmlDocument to read the results and extract information from WUndeground API
        '    Dim xmlWeatherReader As New XmlDocument
        '    '' load the response stream into the xml document
        '    xmlWeatherReader.Load(forecastResponseStream)

        '    Dim forecastPicPointer As XmlNode = xmlWeatherReader.SelectSingleNode("//icon")
        '    Dim forcastDescripLabel As XmlNode = xmlWeatherReader.SelectSingleNode("//fctext")

        '    Dim resultDescriptionLabel As String = "Here is the weather description for " + 
    End Sub

    Private Sub currentWeatherBackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles currentWeatherBackgroundWorker.RunWorkerCompleted
        statusLabel.Text = ("Run worker Completed")
    End Sub
End Class




'' still need to confirm that i have built the city request right 

'' interpet the information. to do/ write to file to display the results from json 3day for cast. Then interpreting them to display a png image of the forecast. Labels should be easy to re-adjust from there 
'' we'll need to make use of background worker and then start to handle multiple tasks depending on the button click.  