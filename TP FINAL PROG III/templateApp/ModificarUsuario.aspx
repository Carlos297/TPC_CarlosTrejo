<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarUsuario.aspx.cs" Inherits="templateApp.ModificarUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <div class="contain">

        <div class="jumbotron">

            <div class="row">

                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Modificar Usuarios</h3>
                    </div>
                    
                    <div>
                        <asp:TextBox class="form-control" ID="txtIDUsuario" runat="server"></asp:TextBox>

                    </div>

                    <div>
                        <asp:TextBox class="form-control" ID="txtCodUsuario" runat="server"></asp:TextBox>
                        
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Tipo Usuario" ID="txtTipoUsuario" runat="server"></asp:TextBox>

                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Email" ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Sexo" ID="txtSexo" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha Registracion" ID="txtFechaReg" runat="server" TextMode="DateTime"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha Nacimiento" ID="txtFechaNac" runat="server" TextMode="DateTime"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Clave" ID="txtClave" runat="server"></asp:TextBox>
                    </div>
                    <%--<div>
                        <asp:TextBox class="form-control" placeholder="Estado" ID="txtEstado" runat="server"></asp:TextBox>
                    </div>--%>


                    <%--<input class="form-control" placeholder="Legajo" id=txtLegajo>
            <input type="text" class="form-control" placeholder="Apellido" id="txtApellido">
            <input type="text" class="form-control" placeholder="Nombre" id="txtNombre">
            <input type="text" class="form-control" placeholder="Sexo" id="txtSexo">
            <input type="text" class="form-control" placeholder="Fecha Nacimiento" id="txtFechaNac">
            <input type="text" class="form-control" placeholder="Estado" id="txtEstado">--%>
                </div>
                <%--<a href="Choferes.aspx" class="btn btn-app" id="btnGuardar">--%>




                <%--<asp:Button class="btn btn-app" ref="Choferes.aspx" ID="btnGuardarChoferModific" runat="server" OnClick="btnGuardarChoferModific_Click" Text="GUARDAR">  </asp:Button >--%>
                <asp:Button class="btn btn-block btn-success" ref="Usuarios.aspx" ID="btnActualizarUsuarios" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR"></asp:Button>

            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
