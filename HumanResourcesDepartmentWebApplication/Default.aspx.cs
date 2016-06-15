using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HumanResourcesDepartment;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Collections;
using System.ComponentModel.DataAnnotations;


namespace HumanResourcesDepartmentWebApplication
{
    public partial class _Default : Page
    {
        private Company company;
        private Subdivision subdivision;

        /// <summary>
        /// This method loads all data from file. 
        /// </summary>
        /// <param name="sender">EventArgs</param>
        /// <param name="e">object</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            this.company = menu.LoadObject("Google", Server.MapPath(@"~\App_Data"));
            if (!IsPostBack)
            {
                SubdivisionDropList.DataSource = this.ReturnSubdivisions(this.company);
                SubdivisionDropList.DataBind();
            }
        }

        /// <summary>
        /// This method saves object and redirect on AddEmployeeForm. 
        /// </summary>
        /// <param name="sender">EventArgs</param>
        /// <param name="e">object</param>
        protected void AddEmployee(object sender, EventArgs e)
        {
            HumanResourcesDepartment.Menu menu = new HumanResourcesDepartment.Menu();
            menu.SaveObject(this.company, Server.MapPath(@"~\App_Data"));          
            Response.Redirect("AddEmployeeForm");
        }
        

        /// <summary>
        /// This method builds table with data.
        /// </summary>
        /// <returns>string</returns>
        protected string PrintTableHtml()
        {
            StringBuilder html = new StringBuilder();
            List<Employee> employees;
            if (this.subdivision != null)
            {
                employees = subdivision.Employees;
            }
            else
            {
                employees = company.Employees;
            }
            foreach (var emp in employees)
            {
                html.Append(this.PrintEmployee(emp));
            }
            return html.ToString();
        }

        /// <summary>
        /// This method build row for table and retun it.
        /// </summary>
        /// <param name="empObj">Emoloyee</param>
        /// <returns>string</returns>
        private string PrintEmployee(Employee empObj)
        {
            if (empObj.Employer != null && empObj.Subdivision != null)
                return String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href =\"AddEmployeeForm?id={0}\">Edit</a>  <a href =\"DeleteEmployee?id={0}\">Delete</a></td>",
                    empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.ContactDetails, empObj.Subdivision.Name, empObj.Employer.FirstName + " " + empObj.Employer.LastName, empObj.Employer.id);
            else if (empObj.Employer == null && empObj.Subdivision != null)
                return String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href =\"AddEmployeeForm?id={0}\">Edit</a>  <a href =\"DeleteEmployee?id={0}\">Delete</a></td>",
                    empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.ContactDetails, empObj.Subdivision.Name,  " ", " ");
            else if (empObj.Subdivision == null && empObj.Employer != null)
                return String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href =\"AddEmployeeForm?id={0}\">Edit</a>  <a href =\"DeleteEmployee?id={0}\">Delete</a></td>",
                    empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.ContactDetails, " ", empObj.Employer.FirstName + " " + empObj.Employer.LastName, empObj.Employer.id);
            else
                return String.Format("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td>{5}</td><td>{6}</td><td>{7}</td><td><a href =\"AddEmployeeForm?id={0}\">Edit</a>  <a href =\"DeleteEmployee?id={0}\">Delete</a></td>",
                    empObj.id, empObj.FirstName, empObj.LastName, empObj.Position, empObj.ContactDetails, " ", " ", " ");
        }

        /// <summary>
        /// This method returns ArrayList of Subdivisions.
        /// </summary>
        /// <param name="company">Company</param>
        /// <returns>ArrayList</returns>
        private ArrayList ReturnSubdivisions(Company company)
        {
            ArrayList SubdivisionArrayList = new ArrayList();
            SubdivisionArrayList.Add("All");
            foreach (var sub in company.Subdivisions)
            {
                SubdivisionArrayList.Add(sub.Name);
            }
            return SubdivisionArrayList;
        }

        /// <summary>
        /// This method select subdivision.
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        protected void SelectSubdivision(object sender, EventArgs e)
        {
            string nameOfSubdivision = SubdivisionDropList.SelectedValue;
            if (nameOfSubdivision == "All")
                this.subdivision = null;
            else
                subdivision = company.FindSubdivisionByName(nameOfSubdivision);
        }


    }
}