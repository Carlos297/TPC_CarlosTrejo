<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="NuevoChofer.aspx.cs" Inherits="templateApp.NuevoChofer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">



    <div class="jumbotron">

        <div class="row">

            <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Nuevo Choferes</h3>
                    </div>

                <div><asp:TextBox ID="txtLegajo" runat="server"></asp:TextBox>  Legajo</div> 
                <div><asp:TextBox ID="txtAApellido" runat="server"></asp:TextBox> Apellidos</div>
                <div><asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>Nombres</div>
                <div><asp:TextBox ID="txtSexo" runat="server"></asp:TextBox>Sexo</div>
                <div><asp:TextBox ID="txtFechaNac" runat="server" TextMode="Date"></asp:TextBox>FechaNac</div>
                <div><asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>Estado</div>


            <%--<input class="form-control" placeholder="Legajo" id=txtLegajo>
            <input type="text" class="form-control" placeholder="Apellido" id="txtApellido">
            <input type="text" class="form-control" placeholder="Nombre" id="txtNombre">
            <input type="text" class="form-control" placeholder="Sexo" id="txtSexo">
            <input type="text" class="form-control" placeholder="Fecha Nacimiento" id="txtFechaNac">
            <input type="text" class="form-control" placeholder="Estado" id="txtEstado">--%>
            
                    
        </div>
            <%--<a href="Choferes.aspx" class="btn btn-app" id="btnGuardar">--%>

            
                
            
            <asp:Button ID="btnGuardarChofer" runat="server" OnClick="btnGuardar_Click" Text="Guardar" />
    </div>
</div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>




