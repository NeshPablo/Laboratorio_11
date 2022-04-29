<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Alumnos</h1>
        <p>Universidad&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Mesoamericana</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Alumnos:</p>
        <p>Carne:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_carne" runat="server"></asp:TextBox>
        </p>
        <p>Nombre:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
        </p>
        <p>Apellido:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
        </p>
        <p>Notas:</p>
        <p>Curso:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_curso" runat="server"></asp:TextBox>
        </p>
        <p>Punteo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_punteo" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar Nota" />
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Agregar Alumno a la Universidad" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Agregar Universidad con sus Alumnos" />
        </p>
    </div>

    <div class="row">
    </div>

</asp:Content>
