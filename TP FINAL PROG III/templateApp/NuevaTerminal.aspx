﻿<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="NuevaTerminal.aspx.cs" Inherits="templateApp.NuevaTerminal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="contain">

        <div class="jumbotron">

            <div class="row">

                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Nueva Terminal</h3>
                    </div>

                    <div>
                        <asp:TextBox class="form-control" placeholder="Codigo Terminal" ID="txtCodTerminal" runat="server"></asp:TextBox>
                        
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Nombre Terminal" ID="txtNomTermianl" runat="server"></asp:TextBox>
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




                <asp:Button class="btn btn-block btn-success" ref="Terminales.aspx" ID="btnGuardarTerminal" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR">  </asp:Button>

                <%--<asp:Button class="btn btn-block btn-success" ref="Choferes.aspx" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR">  </asp:Button>--%>

                

            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>