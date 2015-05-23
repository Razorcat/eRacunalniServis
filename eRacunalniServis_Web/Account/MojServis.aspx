<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MojServis.aspx.cs" Inherits="eRacunalniServis_Web.Account.MojServis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>            
            <td>
                <asp:DataGrid ID="dgMojiServis" runat="server" AllowPaging="True" AllowCustomPaging="True" AutoGenerateColumns="False" PageSize="10">
                 <PagerStyle Mode="NumericPages" />
                <Columns>            
                    <asp:BoundColumn DataField="Naziv" HeaderText="Proizvod "> </asp:BoundColumn>
                    <asp:BoundColumn DataField="Datum" HeaderText="Datum "> </asp:BoundColumn>                   
                    <asp:BoundColumn DataField="Opis" HeaderText="Stanje "> </asp:BoundColumn>
                    <asp:TemplateColumn>                
                    </asp:TemplateColumn>
               </Columns>
            </asp:DataGrid>
                           
        </tr>
    </table>
</asp:Content>
