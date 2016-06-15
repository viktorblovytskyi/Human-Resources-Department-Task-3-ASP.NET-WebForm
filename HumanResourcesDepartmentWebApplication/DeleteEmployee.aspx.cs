using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HumanResourcesDepartment;

namespace HumanResourcesDepartmentWebApplication
{
    public partial class DeleteEmployee : System.Web.UI.Page
    {
        private Company company;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
            menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));
           
            try
            {
                int int_id = int.Parse(Request.QueryString["id"]);
                Employee emp = this.company.FindById(int_id);
                this.company.RemoveEmloyee(emp);
               
                menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));
            }
            catch (NullReferenceException exp)
            {
                
            }
            catch(ArgumentNullException exp)
            {

            }
            Response.Redirect("Default");
        }
    }
}