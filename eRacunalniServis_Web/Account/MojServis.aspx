<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MojServis.aspx.cs" Inherits="eRacunalniServis_Web.Account.MojServis" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server" >
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <h1><%: Title %></h1>
     <h2>Moj servis</h2>
    <table>
        <tr>            
            <td>
                 <asp:DataGrid ID="dgMojiServis" runat="server" AllowPaging="True" AllowCustomPaging="True" AutoGenerateColumns="false" PageSize="10" OnItemCommand="dgMojiServis_ItemCommand" BorderStyle="Double" BorderWidth="3px">                     
                    <Columns>            
                        <asp:BoundColumn DataField="Naziv" HeaderText="Naziv "> </asp:BoundColumn>
                        <asp:BoundColumn DataField="Datum" HeaderText="Datum "> </asp:BoundColumn>                   
                        <asp:BoundColumn DataField="Popravljeno" HeaderText="Popravljeno "> </asp:BoundColumn>
                        <asp:TemplateColumn>
                            <ItemTemplate>       
                                <asp:LinkButton ID="lbtnDetalji" runat="server" CommandName="cmdDetalji">Detalji</asp:LinkButton>
                            </ItemTemplate> 
                        </asp:TemplateColumn>
                   </Columns>
                </asp:DataGrid>  
              </td> 
            <td>
                <asp:DataGrid ID="dgDetaljiServis" runat="server" AllowPaging="True" AllowCustomPaging="True" AutoGenerateColumns="False" PageSize="10" BorderStyle="Outset" BorderWidth="1px">
                     <Columns>            
                        <asp:BoundColumn DataField="Opis" HeaderText="Opis "> </asp:BoundColumn>
                        <asp:BoundColumn DataField="Datum" HeaderText="Datum "> </asp:BoundColumn>
                     </Columns>
                </asp:DataGrid>
            </td>                        
        </tr>
    </table>
</asp:Content>
