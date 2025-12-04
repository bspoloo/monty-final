using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Response
/// </summary>
public class Response<E>
{
    public E Data { get; set; }
    public String Message { get; set; }
    public Boolean Success { get; set; }
    public Response()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}