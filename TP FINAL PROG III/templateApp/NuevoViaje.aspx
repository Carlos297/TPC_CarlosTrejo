<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="NuevoViaje.aspx.cs" Inherits="templateApp.NuevoViaje" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">




    <div>

        <div>



            <div>

                <h3>Nuevo Viaje</h3>


                <h5> Codigo de Viaje </h5>
                <div>
                    <asp:TextBox class="form-control" placeholder="Codigo del Viaje" ID="txtCodViaje" runat="server"></asp:TextBox>

                </div>

                <div class="form-group">
                    <asp:Label Text="Chofer" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlChoferes" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div>
                </div>

                <div class="form-group">
                    <asp:Label Text="Micro" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlMicros" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label Text="Origen" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlTerminalOrigen" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <div class="form-group">
                    <asp:Label Text="Destino" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlTerminalDestino" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <h5>Fecha Viaje  </h5>
                <div>
                    <asp:TextBox class="form-control" placeholder="Fecha del Viaje" ID="txtFechaViaje" TextMode="Date" runat="server"></asp:TextBox>

                </div>
                <div>
                </div>
                <h5> Precio Viaje </h5>
                <div>
                    <asp:TextBox class="form-control" placeholder="Precio" ID="txtPrecio" runat="server"></asp:TextBox>

                </div>

            </div>
        </div>

    </div>
    <asp:Button class="btn btn-block btn-success" ref="Viajes.aspx" ID="btnGuardarViaje" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR"></asp:Button>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
