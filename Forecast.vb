Imports System.Net
Imports System.IO
Imports System.Xml

Public Class Forecast
    '' this is experimental trying to set the forecast as a class and send it to the form as what is needed from the xml to build the forecast 

    '' does it need a web request ?
    Dim forecastURL As String = "http://api.wunderground.com/api/ede6553743c4d570/conditions/q/MN/Minneapolis.xml"

    Dim webRequestForecast As WebRequest = WebRequest.Create(forecastURL)

    Dim forecastResponse As Stream = webRequestForecast.GetResponse.GetResponseStream()

    Dim xmlWeatherReader As New XmlDocument




    ''xmlWeatherReader.Load(forecastResponseStream)

    ''Dim weatherforecastPictureNode As XmlNode = xmlWeatherReader.SelectSingleNode("//icon_url")

    '' move this to the form and test it out. 

End Class
