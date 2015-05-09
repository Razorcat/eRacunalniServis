<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="eRacunalniServis_Web.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>eRačunalni Servis</h2>
    </hgroup>

    <article>
        <p>        
            PEP
        </p>

        <p>        
            3059
        </p>

        <p>        
            Seminarski rad
        </p>
    </article>

    <aside>
        <h3>Izbornik</h3>
        <p>        
            Navigacija
        </p>
        <ul>
            <li><a runat="server" href="~/">Početna stranica</a></li>
            <li><a runat="server" href="~/About">O nama</a></li>
            <li><a runat="server" href="~/Contact">Kontakt</a></li>
        </ul>
    </aside>
</asp:Content>