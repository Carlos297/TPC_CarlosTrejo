<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="SacarPasajes.aspx.cs" Inherits="templateApp.SacarPasajes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">


    <div>

        <div>



            <div>

                <h3>Sacar Pasajes</h3>



                <div>
                    <asp:TextBox class="form-control" placeholder="Codigo del Boleto" ID="txtCodBoleto" runat="server"></asp:TextBox>

                </div>

                <div class="form-group">
                    <asp:Label Text="Viaje" runat="server" />
                    <asp:DropDownList runat="server" ID="ddlViajes" CssClass="form-control">
                    </asp:DropDownList>
                </div>

                <div>
                    <asp:TextBox class="form-control" placeholder="Cantidad de Boletos" ID="txtCantBoletos" runat="server"></asp:TextBox>

                </div>

               

                <div>
                </div>


            </div>
        </div>

    </div>
    <asp:Button class="btn btn-block btn-success" ref="Pasajes.aspx" ID="btnGuardarPasaje" runat="server" OnClick="btnGuardar_Click" Text="GUARDAR"></asp:Button>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
