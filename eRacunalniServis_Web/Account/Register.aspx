<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="eRacunalniServis_Web.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>Registracija.</h1>
        <h2>Unesite podatke za registraciju.</h2>
    </hgroup>

    
                    <p class="message-info">
                       Lozinka treba da sadrži minimalno <%: Membership.MinRequiredPasswordLength %> karektera.
                    </p>

                    <p class="validation-summary-errors">
                        <asp:Literal runat="server" ID="ErrorMessage" />
                    </p>

                    <fieldset>
                        <legend>Registration Form</legend>
                        <ol>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbIme">Ime</asp:Label>
                                <asp:TextBox runat="server" ID="txtbIme" MaxLength="50" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbIme"
                                    CssClass="field-validation-error" ErrorMessage="Ime je obavezno!" />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbPrezime">Prezime</asp:Label>
                                <asp:TextBox runat="server" ID="txtbPrezime" MaxLength="50" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbPrezime"
                                    CssClass="field-validation-error" ErrorMessage="Prezime je obavezno!" />
                            </li>                           


                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbEmail">Email</asp:Label>
                                <asp:TextBox runat="server" ID="txtbEmail" TextMode="Email" MaxLength="250" >netko@email.com</asp:TextBox>
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbEmail"
                                    CssClass="field-validation-error" ErrorMessage="The email je obavezan!" />
                            </li>

                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbKorisnickoIme">Korisničko ime</asp:Label>
                                <asp:TextBox runat="server" ID="txtbKorisnickoIme" MaxLength="50" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbKorisnickoIme"
                                    CssClass="field-validation-error" ErrorMessage="Korisnočko ime je obavezno!" />
                            </li>
                            
                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbLozinka">Lozinka</asp:Label>
                                <asp:TextBox runat="server" ID="txtbLozinka" TextMode="Password" MaxLength="50" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbLozinka"
                                    CssClass="field-validation-error" ErrorMessage="Lozinka je obavezna!" SetFocusOnError="True" />
                            </li>
                            <li>
                                <asp:Label runat="server" AssociatedControlID="txtbLozinkaPotvrda">Potvrdi lozinku</asp:Label>
                                <asp:TextBox runat="server" ID="txtbLozinkaPotvrda" TextMode="Password" MaxLength="50" />
                                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtbLozinkaPotvrda"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Potvrda lozinke je obavezna!" />
                                <asp:CompareValidator runat="server" ControlToCompare="txtbLozinka" ControlToValidate="txtbLozinkaPotvrda"
                                     CssClass="field-validation-error" Display="Dynamic" ErrorMessage="Lozinka i potvrda se ne slažu!" />
                            </li>
                        </ol>
                        <asp:Button runat="server" CommandName="MoveNext" Text="Register" OnClick="on_btnRegistriraj_Click" />
                    </fieldset>
                
</asp:Content>