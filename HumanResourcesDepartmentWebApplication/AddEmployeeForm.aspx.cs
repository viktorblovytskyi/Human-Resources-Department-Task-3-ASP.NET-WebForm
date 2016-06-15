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
                positions.Add("Product owner");
                positions.Add("Developer");
                positions.Add("QA");
                positions.Add("Project manager");
                positions.Add("Business analyst");
                
                Position.DataSource = positions;
                Position.DataBind();
                Employeer.DataSource = this.ReturnEmployerList(this.company);
                Employeer.DataValueField = "Key";
                Employeer.DataTextField = "Value";
                Employeer.DataBind();
                Subdivision.DataSource = this.ReturnSubdivisions(this.company);
                Subdivision.DataBind();
                SubmitButton.Visible = true;
            }
            else
            {
                HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
                this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
                EditButton.Visible = true;
            }
        }

        /// <summary>
        /// This method adds employee.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        protected void AddEmployee(object sender, EventArgs e)
        {
            this.SelectedPosition = Position.SelectedValue;
            this.SelectedSubdivision = Subdivision.SelectedValue;
            this.SelectedEmployerId = int.Parse(Employeer.SelectedValue);
            this.company.AddEmployee(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.SelectedSubdivision, this.SelectedEmployerId);
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));
            Response.Redirect("Default");
        }

        /// <summary>
        /// This method returns SortedList of Employee.
        /// </summary>
        /// <param name="company">Company</param>
        /// <returns>SortedList</returns>
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

        /// <summary>
        /// This method returns ArrayList of Subdivisions.
        /// </summary>
        /// <param name="company">Company</param>
        /// <returns>ArrayList</returns>
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