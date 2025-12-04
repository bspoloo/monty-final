using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for SegipService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class SegipService : System.Web.Services.WebService
{
    private MedicosDAO medicosDAO = new MedicosDAO();
    public SegipService()
    {
    }

    [WebMethod]
    public Boolean VerificarCI(String CI)
    {
        //var medico = medicos.FirstOrDefault(m => m.CI == CI);
        Medico medico = medicosDAO.VerificarPorCI(CI);
        if (medico != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
