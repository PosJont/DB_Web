using Microsoft.AspNetCore.Mvc;
using DB_WEB.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using DB_WEB;

namespace DB_WEB.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form = null)
        {
            Comm comm = new Comm();
            try
            {
                string sComm;
                sComm = "Data Source="+form["Sql_Code"] +";";
                sComm += "Initial Catalog=" + form["DB_Code"] + ";";
                sComm += "User ID=" + form["usr_Code"] + ";";
                sComm += "Password=" + form["usr_password"] + ";";
                string sPath = System.Environment.CurrentDirectory;
                if (comm.Chk_DBConnection(sComm)) {
                    using (StreamWriter outFile = new StreamWriter(Path.Combine(sPath, "SettingConn.config")))
                    {
                        outFile.WriteLine(sComm);
                    }
                    return Redirect("Home");
                }  
            }
            catch
            {
                
                return View();
            }

            return View();
        }

       
    }
}
