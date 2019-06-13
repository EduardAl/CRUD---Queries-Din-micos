<%@ Page Title="Contact" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Vergrid.aspx.vb" Inherits="Guía4_ASp.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="200px" Width="1046px">
    <Columns>
        <asp:ImageField DataImageUrlField="Foto" DataImageUrlFormatString="~/capturas/{0}" HeaderText="Imagen" ControlStyle-Width="100px" ControlStyle-Height="100px">
<ControlStyle Height="100px" Width="100px"></ControlStyle>
        </asp:ImageField>
        <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" />
    </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
        <RowStyle BackColor="White" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
</asp:Content>
