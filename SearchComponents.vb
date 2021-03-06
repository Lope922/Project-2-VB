﻿Public Class SearchComponents


    '' need to have a city and state for each search string. 

    Dim state As String
    Dim city As String

    Public Property getSelectedState() As String '' this may need to be converted to a url type later 

        Get
            Return state
        End Get
        Set(value As String)
            state = value
        End Set
    End Property

    Public Property getUserEnteredCity() As String
        Get
            Return city
        End Get
        Set(value As String)
            city = value
        End Set
    End Property

    '' need to measure city name and if it is longer than 3 characters add an underscore if there is a space between words. 

    '' also if city entered has a space at the end remove it. becuase when it it put into the url builder the request will sent the wrong name ?


    '' need to override the tostring to get this object as a string. 
    Public Overrides Function ToString() As String
        Return city & "/" & state
    End Function



End Class
