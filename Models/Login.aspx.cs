using System;

namespace YourNamespace
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["username"] != null)
                {
                    Response.Redirect("secondaPagina.aspx");
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                Response.Write("<script>alert('Inserire username e password.')</script>");
                return;
            }
            Response.Cookies["username"].Value = txtUsername.Text;
            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(30);
            Response.Redirect("secondaPagina.aspx");
        }
    }
}
