<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormMusica.aspx.cs" Inherits="POO3B3E47.UI.FormMusica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../CSS/global.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500&display=swap" rel="stylesheet" />
    <title>Formulário Música</title>
</head>
<body>
    <div class="container">
        <h1>Formulário Música</h1>
        <div class="error">
            <asp:Label ID="messageError" runat="server" Visible="false" />
        </div>
        <div class="success">
            <asp:Label ID="messageSuccess" runat="server" Visible="false" />
        </div>
        <form id="form1" runat="server">
            <div class="input-group">
                <asp:Label runat="server" Text="Nome" />
                <asp:TextBox ID="txtNome" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Autor" />
               <asp:TextBox ID="txtNomeAutor" runat="server" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="Gravadora" />
                <asp:DropDownList runat="server" ID="drpGravadora" />
            </div>
            <div class="input-group">
                <asp:Label runat="server" Text="CD" />
                <asp:DropDownList runat="server" ID="drpCd"/>
            </div>
            <div class="input-group">
                <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
            <asp:GridView ID="GridMusica" CssClass="table" runat="server" OnRowDeleting="GridMusica_RowDeleting" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCancelingEdit="GridMusica_RowCancelingEdit" OnRowEditing="GridMusica_RowEditing" OnRowUpdating="GridMusica_RowUpdating" OnSelectedIndexChanged="GridMusica_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField />
                    <asp:CommandField ShowEditButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>

            </asp:GridView>
        </form>
    </div>

</body>
</html>