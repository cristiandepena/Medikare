<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFRegistroPaciente.aspx.cs" Inherits="FormularioMedico.WFRegistroPaciente" MasterPageFile="~/MasterPage.Master" %>

    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
        <asp:TextBox ID="tbBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="tbNombre" runat="server"></asp:TextBox>
        <br />
        Apellido<asp:TextBox ID="tbApellido" runat="server"></asp:TextBox>
        <br />
        Direccion<asp:TextBox ID="tbDireccion" runat="server"></asp:TextBox>
        <br />
        Telefono<asp:TextBox ID="tbTelefono" runat="server"></asp:TextBox>
        <br />
        Celular<asp:TextBox ID="tbCelular" runat="server"></asp:TextBox>
        <br />
        Cedula<asp:TextBox ID="tbCedula" runat="server"></asp:TextBox>
        <br />
        Fecha Nacimiento<asp:TextBox ID="tbFechaNacimiento" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbFechaNacimiento" ErrorMessage="Fecha invalida" ValidationExpression="^(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$">*</asp:RegularExpressionValidator>
        <br />
        Sexo<asp:DropDownList ID="ddlSexo" runat="server">
            <asp:ListItem Value="M">Masculino</asp:ListItem>
            <asp:ListItem Value="F">Femenino</asp:ListItem>
        </asp:DropDownList>
        <br />
        Ocupacion<asp:TextBox ID="tbOcupacion" runat="server"></asp:TextBox>
        <asp:Button ID="btnGuardar" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </form>
        </asp:Content>