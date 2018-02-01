Sub GetGSA()
    Dim xmlhttp As Object
    Dim URI, result
    'URI = "https://inventory.data.gov/api/action/datastore_search?resource_id=8ea44bc4-22ba-4386-b84c-1494ab28964b"
    URI = "http://inventory.data.gov/api/action/datastore_search?resource_id=8ea44bc4-22ba-4386-b84c-1494ab28964b&filters=%7B%22FiscalYear%22:%222017%22,%22Zip%22:%2210036%22%7D"
    'URI = "https://chima.mdanderson.org/"
    Set xmlhttp = CreateObject("MSXML2.serverXMLHTTP")
    xmlhttp.Open "GET", URI, False
    xmlhttp.setRequestHeader "Content-Type", "application/json"
    xmlhttp.Send
    result = xmlhttp.responseText
    MsgBox (result)
    Set xmlhttp = Nothing
End Sub

