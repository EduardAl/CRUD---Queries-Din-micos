<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Ingresar.aspx.vb" Inherits="Guía4_ASp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron">
        <h1>Registro de fotos.</h1>
         <div class="row" id="form" runat="server">
        <div class="col-md-12">
            <div class="form-group">
            <asp:Label CssClass="form-control label label-primary" ID="Label1" runat="server" Text="Título de Foro: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="TitulFoto" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                    <asp:Label CssClass="form-control label label-primary" ID="Label2" runat="server" Text="Foto"></asp:Label>
                <div>
                    <asp:FileUpload CssClass="form-control" ID="ArchivoFoto" runat="server" />
                </div>
            </div>
            <div class="form-group">
                <br />
                <asp:Label CssClass="form-control label label-primary" ID="Label3" runat="server" Text="Descripción: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="DescripFoto" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <p>
                <asp:Button CssClass="btn btn-primary" ID="Button1" runat="server" Text="Guardar" />
                <span ID="span" runat="server" style="color:red"></span>
            </p>
        </div>
    </div>
        </div>
</asp:Content>
