<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="NuevoMicro.aspx.cs" Inherits="templateApp.NuevoMicro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
      <div class="contain">

        <div class="jumbotron">

            <div class="row">

                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Nuevo Micro</h3>
                    </div>

                    <div>
                        <asp:TextBox class="form-control" placeholder="Patente" ID="txtPatente" runat="server"></asp:TextBox>
                        
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Modelo" ID="txtModelo" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Fecha Fabricacion" ID="txtFechaFabr" runat="server" TextMode="Date"></asp:TextBox>
                    </div>
                    <div>
                        <asp:TextBox class="form-control" placeholder="Cantidad Asientos" ID="txtCanAsientos" runat="server"></asp:TextBox>
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




                <asp:Button class="btn btn-block btn-success" ref="Micros.aspx" ID="btnGuardarMicro" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR">  </asp:Button>

                <%--<asp:Button class="btn btn-block btn-success" ref="Choferes.aspx" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="ACTUALIZAR">  </asp:Button>--%>

                

            </div>
        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
