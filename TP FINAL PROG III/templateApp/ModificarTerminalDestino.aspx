<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="ModificarTerminalDestino.aspx.cs" Inherits="templateApp.ModificarTerminalDestino" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    
    <div>

        <div >

            <div >

                <div >
                    <div class="box-header">
                        <h3 class="box-title">Modificar Terminal Destino</h3>
                    </div>

                    <div>
                        <asp:TextBox class="form-control" ID="txtID" visible="false" runat="server"></asp:TextBox>

                    </div>
                    <h5> Codigo Terminal </h5>
                    <div>
                        <asp:TextBox class="form-control" ID="txtCodTerminal" runat="server"></asp:TextBox>

                    </div>
                    <h5> Nombre Terminal </h5>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Apellido" ID="txtNomTerminal" runat="server"></asp:TextBox>

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
                <asp:Button class="btn btn-block btn-success" ref="TerminalDestino.aspx" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR"></asp:Button>

            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
