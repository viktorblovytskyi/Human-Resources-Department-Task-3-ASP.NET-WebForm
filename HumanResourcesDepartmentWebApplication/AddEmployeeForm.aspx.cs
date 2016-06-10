using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HumanResourcesDepartmentWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList positions = new ArrayList();
            positions.Add("Developer");
            positions.Add("QA");
            positions.Add("Project manager");
            positions.Add("Business analyst");
            positions.Add("Product owner");
            Position.DataSource = positions;
            Position.DataBind();
        }
    }
}