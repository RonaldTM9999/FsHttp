
#load "./bin/Debug/netstandard2.0/FsHttp.fsx"

open FsHttp
open FsHttp.DslCE

post "https://reqres.in/api/users" {
    CacheControl "no-cache"
    body
    json """
    {
        "name": "morpheus",
        "job": "leader"
    }
    """
}
|> Request.send


http {
    POST "http://www.csm-testcenter.org/test"
    multipart
    filePart "c:\\temp\\test.txt"
    filePart "c:\\temp\\test.txt"
}


http {
    GET "https://reqres.in/api/users"
}



http {
    POST "https://reqres.in/api/users"
    CacheControl "no-cache"
    body
    json """
    {
        "name": "morpheus",
        "job": "leader"
    }
    """
}

// shortcuts

get "https://reqres.in/api/users" {go}
