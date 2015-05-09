<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eRacunalniServis_Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>Modify this template to jump-start your ASP.NET application.</h2>
            </hgroup>
            <p>
                To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Katalog proizvoda</h3>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Vrsta"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Naziv"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="ddlVrstaList" runat="server" DataTextField="Naziv" DataValueField="VrstaID"></asp:DropDownList>
            </td>
            <td>
                <asp:TextBox ID="txtbNazivInput" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnTraziSubmit" runat="server" Text="Traži" OnClick="btnTraziSubmit_Click" />
            </td>
        </tr>
    </table>
    <asp:DataGrid ID="dgProizvodi" runat="server" AllowPaging="true" AllowCustomPaging="true" AutoGenerateColumns="false" PageSize="2" OnPageIndexChanged="dgProizvodi_PageIndexChanged" OnItemDataBound="dgProizvodi_ItemDataBound" DataKeyField="ProizvodID" OnItemCommand="dgProizvodi_ItemCommand">
        <PagerStyle Mode="NumericPages" />
        <Columns>
            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:Image ID="imgSlikaThumb" runat="server" BackColor="#FF9999" BorderColor="#9933FF" BorderStyle="Solid" />
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:BoundColumn DataField="Naziv" HeaderText="Naziv "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Sifra" HeaderText="Šifra "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Cijena" HeaderText="Cijena "> </asp:BoundColumn>
            <asp:TemplateColumn>
                <ItemTemplate>
                    <asp:TextBox ID="txtbKolicina" runat="server" Width="20px" Text="1"></asp:TextBox>
                    <asp:LinkButton ID="lbtnDodajUKosaricu" runat="server" CommandName="DodajUKopruCmd">Dodaj u košarici</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>

    </asp:DataGrid>
</asp:Content>
