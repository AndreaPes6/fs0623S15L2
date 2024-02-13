using System;

namespace YourNamespace
{
    public partial class secondaPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                lblUsername.Text = "Username: " + Request.Cookies["username"].Value;
            }
            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Cookies["username"].Expires = DateTime.Now.AddDays(-1);

            Response.Redirect("login.aspx");
        }
    }
}
