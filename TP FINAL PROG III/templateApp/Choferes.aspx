<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Choferes.aspx.cs" Inherits="templateApp.productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="jumbotron">

        <div class="row">
            <div class="col-xs-12">
                <div class="box">
                    <div class="box-header">
                        <h3 class="box-title">Choferes</h3>
                    </div>
                    <!-- /.box-header -->




                    <%--<asp:Repeater runat="server" ID="repetidor" OnItemCommand="repetidor_ItemCommand">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                    <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<%#Eval("IdArt")%>">Seleccionar</a>
                    <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("IdArt")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />
                </div>
            </ItemTemplate>
        </asp:Repeater>--%>
                    <%------------esta es una tabla bonita que vino con el template----------------%>
                    <%--<table class="table table-hover">
                        <tr>
                            <th>ID</th>
                            <th>Legajo</th>
                            <th>Nombre</th>
                            <th>Apellido</th>
                            <th>Sexo</th>
                            <th>Nacimiento</th>
                            <th>Estado</th>

                        </tr>
                        <% foreach (var item in listaChoferes)
                            { 

                        %>
                        <tr>
                            <td><% = item.IdChofer %></td>
                            <td><% = item.Legajo %></td>
                            <td><% = item.Nombre %></td>
                            <td><% = item.Apellido %> </td>
                            <td><% = item.Sexo %> </td>
                            <td><% = item.FechaNacimiento.ToString() %> </td>

                            <td><% = item.Estado %> </td>
                            <td>
                                <asp:Button class="btn btn-app" ref="Choferes.aspx" ID="btnBajaChofer" runat="server"  Text="ELIMINAR"></asp:Button>

                                <asp:Button class="btn btn-app" ref="Choferes.aspx" ID="btnEditarChofer" runat="server"  Text="EDITAR"></asp:Button>


                            </td>
                        </tr>
                        <%  %>
                        <% } %>
                    </table>--%>



                    <style>
                        .oculto {
                            display: none;
                        }
                    </style>



                    <asp:GridView class="table table-hover" ID="dgvChoferes" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="dgvChoferes_SelectedIndexChanged" OnRowCommand="dgvChoferes_RowCommand">


                        <Columns>

                            <asp:BoundField HeaderText="Id" DataField="IdChofer" ItemStyle-CssClass="oculto" HeaderStyle-CssClass="oculto" />
                            <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                            <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                            <asp:BoundField HeaderText="Sexo" DataField="Sexo" />
                            <asp:BoundField HeaderText="Fecha Nacimiento" DataField="FechaNacimiento" />
                            <asp:BoundField HeaderText="Estado" DataField="Estado" />
                            <asp:ButtonField HeaderText="Opcion" ButtonType="Link" Text="Eliminar" CommandName="Eliminar" />     
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="lkbActualizar" runat="server" Text="Modificar" OnClick="lkbActualizar_Click"></asp:LinkButton>
                                </ItemTemplate>

                            </asp:TemplateField>      


                        </Columns>
                    </asp:GridView>





                </div>
                <!-- /.box-body -->

            </div>

            <!-- /.box -->
        </div>
    </div>



    <%-- Esto reemplaza el foreach. Vean que cambia la forma de pasar el argumento a cada tag.
            En este caso se usa el numeral (#) y la función Eval que recibe por parámetro como string
            el nombre de la property de tu objeto. El repeater va a iterar lo que esté dentro de la colección
             que le asignamos en el LOAD. Se lo asignamos directamente por ID, en este caso, repetidor.--%>


    <%--<asp:Repeater runat="server" ID="repetidor" OnItemCommand="repetidor_ItemCommand">
            <ItemTemplate>
                <div class="card">
                    <img src="<%#Eval("UrlImagen") %>" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title"><%#Eval("Nombre")%></h5>
                        <p class="card-text"><%#Eval("Descripcion")%></p>
                    </div>
                    <a class="btn btn-primary" href="PokemonDetail.aspx?idpkm=<%#Eval("IdArt")%>">Seleccionar</a>
                    <asp:Button ID="btnArgumento" CssClass="btn btn-primary" Text="Argumento to Back" CommandArgument='<%#Eval("IdArt")%>' CommandName="idPokemon" runat="server" OnClick="btnArgumento_Click" />
                </div>
            </ItemTemplate>
        </asp:Repeater>--%>
</asp:Content>
