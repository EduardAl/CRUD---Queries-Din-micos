<%@ Page Title="Editar" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.vb" Inherits="Guía4_ASp.Editar" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="title">
        <h1>Editor de Album.</h1>
    </div>
    <div class="row form-group">
        <div class="col-md-12">
            <div class="form-group">
                <asp:Image ID="Image1" runat="server" /><br />
                <br />
                <asp:Label CssClass="label label-primary form-control" ID="Label1" runat="server" Text="Título de Foro: "></asp:Label><br />
                <asp:TextBox CssClass="form-control" ID="TitulFoto" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label CssClass="label label-primary form-control" ID="Label2" runat="server" Text="Foto"></asp:Label>
            </div>
            <div class="form-group">
                <asp:FileUpload CssClass="form-control" ID="ArchivoFoto" runat="server" />
            </div>
            <div class="form-group">
                <br />
                <asp:Label CssClass="label label-primary form-control" ID="Label3" runat="server" Text="Descripción: "></asp:Label><br />
                <asp:TextBox ID="DescripFoto" CssClass="form-control" TextMode="MultiLine" runat="server"></asp:TextBox>
            </div>
            <p>
                <asp:Button ID="Button1" runat="server" Text="Guardar" CssClass="btn btn-prymary" />
            </p>
        </div>
    </div>
</asp:Content>
