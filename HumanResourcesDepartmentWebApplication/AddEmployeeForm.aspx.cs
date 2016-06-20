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
        private int id;

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
                if (!string.IsNullOrEmpty(Request.QueryString["id"]))
                {
                    this.id = int.Parse(Request.QueryString["id"]);
                    this.SetDataOnForm(id);
                    this.ChangeButtons();
                }
            }
            else
            {                
                HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
                this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
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
            if (Employeer.SelectedValue == "None")
            {
                this.company.AddEmployee(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.SelectedSubdivision);
            }
            else
            {
                this.SelectedEmployerId = int.Parse(Employeer.SelectedValue);
                this.company.AddEmployee(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.SelectedSubdivision, this.SelectedEmployerId);
            }
            
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));
            Response.Redirect("Default");
        }

        /// <summary>
        /// This method change employee's information. 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        protected void ChangeEmployee(object sender, EventArgs e)
        {
            this.SelectedPosition = Position.SelectedValue;
            this.SelectedSubdivision = Subdivision.SelectedValue;
            Employee emp = this.company.FindById(int.Parse(Emp_id.Text));
            if (Employeer.SelectedValue == "None")
            {
                emp.ChangeAllData(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.company.FindSubdivisionByName(this.SelectedSubdivision), null);
            }
            else
            {
                this.SelectedEmployerId = int.Parse(Employeer.SelectedValue);
                emp.ChangeAllData(FirstName.Text, LastName.Text, ContactDetails.Text, this.SelectedPosition, this.company.FindSubdivisionByName(this.SelectedSubdivision), this.company.FindById(SelectedEmployerId));
            }

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
            productOwnerSortList.Add(99, "None");
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

        /// <summary>
        /// This method loads data on form.
        /// </summary>
        /// <param name="id">int</param>
        private void SetDataOnForm(int id)
        {
            Emp_id.Text = id.ToString();
            Employee emp = company.FindById(id);
            FirstName.Text = emp.FirstName;
            LastName.Text = emp.LastName;
            ContactDetails.Text = emp.ContactDetails;
            Position.SelectedValue = emp.Position;
            if(emp.Subdivision != null)
                Subdivision.SelectedValue = emp.Subdivision.Name;
        }

        /// <summary>
        /// This method change property visible.
        /// </summary>
        private void ChangeButtons()
        {
            SubmitButton.Visible = !SubmitButton.Visible;
            ChangeButton.Visible = !ChangeButton.Visible;
        }

        

        
    }
}