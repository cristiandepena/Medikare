<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFRevision.aspx.cs" Inherits="FormularioMedico.WFRevision" MasterPageFile="~/MasterPage.Master" %>
        
        <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
        
    <fieldset>
        <legend>Revision por sistemas</legend>
        <asp:Label ID="Label4" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="tbIdRevision" runat="server" TextMode="SingleLine"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
        <br/>
        <asp:Label ID="Label1" runat="server" Text="Fecha"></asp:Label>
        <asp:TextBox ID="tbFecha" runat="server" TextMode="SingleLine"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Paciente"></asp:Label>
            <asp:DropDownList ID="ddlPaciente" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Label runat="server">Sistemas</asp:Label>
        <asp:DropDownList runat="server" ID="ddlSistemas"></asp:DropDownList>
        <asp:Label ID="Label3" runat="server" Text="Estado"></asp:Label>
        <asp:TextBox ID="tbEstado" runat="server" Width="477px"></asp:TextBox>
        <asp:Button ID="btnAgregar" runat="server" OnClick="btnAgregar_Click" Text="Agregar" />
        <div>
            <asp:GridView ID="gvRevision" runat="server" Width="751px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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
    </fieldset>
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </form>
    </asp:Content>
