    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFConsultaPaciente.aspx.cs" Inherits="FormularioMedico.WFConsultaPaciente" MasterPageFile="~/MasterPage.Master" %>
    
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="row">
    <div class="col-lg-12">
    
        <asp:DropDownList ID="ddlFiltros" runat="server">
            <asp:ListItem>Nombre</asp:ListItem>
            <asp:ListItem>Apellido</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="tbFiltro" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
        <asp:GridView ID="gvPaciente" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Height="259px" Width="700px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    
    </div>
        </div>
    </form>
    </asp:Content>
    <asp:Content ID="Content1" runat="server" contentplaceholderid="head">
        <style type="text/css">
            #form1 {
                height: 285px;
                width: 792px;
            }
        </style>
    </asp:Content>
