<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="NuevoUsuario.aspx.cs" Inherits="templateApp.NuevoUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="contain">

        <div class="jumbotron">

            <div class="row">

                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Nuevo Usuario</h3>
                    </div>

                    <div>
                        <asp:TextBox class="form-control" placeholder="Codigo de Usuario" ID="txtCodUsuario" runat="server"></asp:TextBox>
                        
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Tipo de Usuario" ID="txtTipoUsuario" runat="server"></asp:TextBox>
                       
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Email" ID="txtEmail" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Sexo" ID="txtSexo" runat="server"></asp:TextBox>
                    </div>
                    <h5>  Fecha Registracion  </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha de Registracion" ID="txtFechaReg" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <h5>  Fecha Nacimiento  </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha de Nacimiento" ID="txtFechaNac" runat="server" TextMode="Date"></asp:TextBox>
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




                <asp:Button class="btn btn-block btn-success" ref="Usuarios.aspx" ID="btnGuardarUsuario" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR">  </asp:Button>

                <%--<asp:Button class="btn btn-block btn-success" ref="Choferes.aspx" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR">  </asp:Button>--%>

                

            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
