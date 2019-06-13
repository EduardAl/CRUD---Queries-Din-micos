<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="IngresarPersona.aspx.vb" Inherits="Guía4_ASp.IngresarPersona" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Registro de Personas.</h1>
         <div class="row" id="form" runat="server">
        <div class="col-md-12">
            <div class="form-group">
            <asp:Label CssClass="form-control label label-primary" ID="Label1" runat="server" Text="Nombre: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="TxtNombre" runat="server" require="required"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label CssClass="form-control label label-primary" ID="Label2" runat="server" Text="Apellido"></asp:Label>                
                <asp:TextBox CssClass="form-control" ID="TxtApellido" runat="server" require="required"></asp:TextBox>

            </div>
            <div class="form-group">
                <br />
                <asp:Label CssClass="form-control label label-primary" ID="Label3" runat="server" Text="Correo: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="TxtCorreo" runat="server" require="required"></asp:TextBox>
            </div>
            <div class="form-group">
                <br />
                <asp:Label CssClass="form-control label label-primary" ID="Label4" runat="server" Text="Edad: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="TxtEdad" runat="server" require="required"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TxtEdad" Type="Double" MaximumValue="120" MinimumValue="1" ErrorMessage="El valor debe estar entre 1 y 120"></asp:RangeValidator>
            </div>
            <div class="form-group">
                <br />
                <asp:Label CssClass="form-control label label-primary" ID="Label5" runat="server" Text="Sexo: "></asp:Label><br />
                <asp:DropDownList ID="DDLSexo" runat="server" CssClass="input form-control">
                    <asp:ListItem Selected="True" Value="M">Masculino</asp:ListItem>
                    <asp:ListItem Value="F">Femenino</asp:ListItem>
                </asp:DropDownList>
            </div>
            <p>
                <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Guardar" />
                <span ID="span" runat="server" style="color:red"></span>
            </p>
        </div>
    </div>
        </div>
</asp:Content>
