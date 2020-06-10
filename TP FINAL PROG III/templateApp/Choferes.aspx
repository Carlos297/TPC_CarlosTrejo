<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Choferes.aspx.cs" Inherits="templateApp.productos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Productos</title>
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

                    <table class="table table-hover">
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
                            { %>
                        <tr>
                            <td><% = item.IdChofer %></td>
                            <td><% = item.Legajo %></td>
                            <td><% = item.Nombre %></td>
                            <td><% = item.Apellido %> </td>
                            <td><% = item.Sexo %> </td>
                            <td><% = item.FechaNacimiento.ToString() %> </td>
                            
                            <td><% = item.Estado %> </td>
                            <td>
                                <a class="btn btn-app">
                                   
                                    <i class="fa fa-remove"></i>Eliminar
                                </a>
                                <a class="btn btn-app">
                                    <i class="fa fa-edit"></i>Editar
                                </a>
                            </td>
                        </tr>
                        <% } %>
                    </table>
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
