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
        private string SelectedPosition;
        private string SelectedSubdivision;
        private int SelectedEmployerId;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                Subdivision.DataSource = this.ReturnSubdivisions(this.company);
                Subdivision.DataBind();
            }
            else
            {
                HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
                this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
            }
        }

        protected void AddEmployee(object sender, EventArgs e)
        {
            this.company.AddEmployee(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.SelectedSubdivision, this.SelectedEmployerId);
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));
        }

        protected void SelectPosition(object sender, EventArgs e)
        {
            this.SelectedPosition = Position.SelectedValue;
        }

        protected void SelectSubdivision(object sender, EventArgs e)
        {
            this.SelectedSubdivision = Subdivision.SelectedValue;
        }
        protected void SelectEmployerId(object sender, EventArgs e)
        {
            this.SelectedEmployerId = int.Parse(Employeer.SelectedValue);
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

        private ArrayList ReturnSubdivisions(Company company)
        {
            ArrayList SubdivisionArrayList = new ArrayList();
            foreach(var sub in company.Subdivisions)
            {
                SubdivisionArrayList.Add(sub.Name);
            }
            return SubdivisionArrayList;
        }

        

        
    }
}