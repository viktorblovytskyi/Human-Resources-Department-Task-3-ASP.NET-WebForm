using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HumanResourcesDepartment;

namespace HumanResourcesDepartmentWebApplication
{
    public partial class AddChangeEmployeeForm : System.Web.UI.Page
    {
        private Company company;

        protected void Page_Load(object sender, EventArgs e)
        {
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
            ArrayList positions = new ArrayList();
            positions.Add("Developer");
            positions.Add("QA");
            positions.Add("Project manager");
            positions.Add("Business analyst");
            positions.Add("Product owner");
            Position.DataSource = positions;
            Position.DataBind();
            Employeer.DataSource = this.ReturnEmployerList(this.company);
            Employeer.DataValueField = "Key";
            Employeer.DataTextField = "Value";
            Employeer.DataBind();
        }

        private SortedList ReturnEmployerList(Company company)
        {
            SortedList productOwnerSortList = new SortedList();
            var productOwners = from empl in company.Employees
                                where empl.Position == "Product owner"
                                select empl;
            foreach(var po in productOwners)
            {
                productOwnerSortList.Add(po.id, po.FirstName + " " + po.LastName);
            }
            return productOwnerSortList;
        }

        
    }
}