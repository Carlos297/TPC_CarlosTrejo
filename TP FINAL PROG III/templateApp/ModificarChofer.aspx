<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarChofer.aspx.cs" Inherits="templateApp.ModificarChofer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <div >

        <div >

            <div >

                <div >
                    <div class="box-header">
                        <h3 class="box-title">Modificar Chofer</h3>
                    </div>
                    
                    <div>
                        <asp:TextBox class="form-control" ID="txtID" runat="server" Visible = "false"></asp:TextBox>

                    </div>
                    <h5> Legajo </h5>
                    <div>
                        <asp:TextBox class="form-control" ID="txtLegajo" runat="server"></asp:TextBox>
                        
                    </div>
                    <h5> Apellido </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Apellido" ID="txtApellido" runat="server"></asp:TextBox>

                    </div>
                    <h5> Nombre </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Nombre" ID="txtNombre" runat="server"></asp:TextBox>
                    </div>
                    <h5> Sexo </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Sexo" ID="txtSexo" runat="server"></asp:TextBox>
                    </div>
                    <h5> Fecha de Nacimiento </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha Nacimiento" ID="txtFechaNac" runat="server" TextMode="DateTime"></asp:TextBox>
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


                <div>   </div>

                <%--<asp:Button class="btn btn-app" ref="Choferes.aspx" ID="btnGuardarChoferModific" runat="server" OnClick="btnGuardarChoferModific_Click" Text="GUARDAR">  </asp:Button >--%>
                <asp:Button class="btn btn-block btn-success" ref="Choferes.aspx" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR"></asp:Button>

            </div>
        </div>
    </div>


</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
