<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="eRacunalniServis_Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1><%: Title %>.</h1>
                <h2>eProdaja 3059</h2>
            </hgroup>
            <p>
                3059</p>
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
            <td>            
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
     
     <table>
         <tr>
             <td>
    <asp:DataGrid ID="dgProizvodi" runat="server" AllowPaging="True" AllowCustomPaging="True" AutoGenerateColumns="False" PageSize="3" OnPageIndexChanged="dgProizvodi_PageIndexChanged" OnItemDataBound="dgProizvodi_ItemDataBound" DataKeyField="ProizvodID" OnItemCommand="dgProizvodi_ItemCommand">
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
                </td> 
             <td>
                 <h4>Najpopularniji proizvodi</h4>      
    <asp:GridView ID="gwPopularniProizvodi" runat="server" CellPadding="4" DataSourceID="SqlDataSourceEprodaja" ForeColor="#333333" GridLines="None" Width="247px" AutoGenerateColumns="False" AllowPaging="True">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Naziv" HeaderText="Naziv" SortExpression="Naziv" />
            <asp:BoundField DataField="Cijena" HeaderText="Cijena" SortExpression="Cijena" />
            <asp:BoundField DataField="Ocjena" HeaderText="Ocjena" SortExpression="Ocjena" />
            <asp:ImageField DataImageUrlField="SlikaThumb" DataImageUrlFormatString="jpeg" HeaderText="Slika">
            </asp:ImageField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
                 <asp:SqlDataSource ID="SqlDataSourceEprodaja" runat="server" ConnectionString="<%$ ConnectionStrings:eProdajaConnectionString %>" SelectCommand="esp_Proizvodi_GetPopularne" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
             </td>  
         </tr>
    </table> 
        
</asp:Content>
