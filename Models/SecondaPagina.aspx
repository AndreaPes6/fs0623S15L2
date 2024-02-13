<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="secondaPagina.aspx.cs" Inherits="YourNamespace.secondaPagina" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Seconda Pagina</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Hai eseguito il login correttamente</h2>
            <asp:Label ID="lblUsername" runat="server"></asp:Label>
            <div>
                <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            </div>
        </div>
    </form>
</body>
</html>
