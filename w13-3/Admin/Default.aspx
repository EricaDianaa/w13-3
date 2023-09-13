<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="w13_3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1"  runat="server">
    <asp:DropDownList ID="DropDownList1" runat="server"   >
          <asp:ListItem Value="6" Text="Margherita" />
  <asp:ListItem Value="8"  Text="Napoli" />
  <asp:ListItem Value="10"  Text="Quattro stagioni" />
  <asp:ListItem Value="8"  Text="Salsiccia secca" />
  <asp:ListItem Value="15"  Text="Frutti di mare" />
  <asp:ListItem Value="12"  Text="Salsa rosa e gamberetti" />
  <asp:ListItem Value="9"  Text="Ortolana" />
  <asp:ListItem Value="8"  Text="Diavola" />

    </asp:DropDownList>
      
 <h3 class="Text-center">Aggiunte:</h3>
      <asp:CheckBoxList CssClass="m-3 d-flex justify-content-center" ID="CheckBoxList1" runat="server" RepeatColumns="2" on>
      <asp:ListItem Value="2" Text="Prosciutto cotto (+2,00)" />
      <asp:ListItem Value="3"  Text=" Salsiccia secca (+3,00)" />
      <asp:ListItem Value="4"  Text=" Bacon (+4,00)" />
      <asp:ListItem Value="2"  Text=" Funghi (+2,00)" />
      <asp:ListItem Value="3"  Text="Speck (+3,00)" />
      <asp:ListItem Value="1"  Text=" Capperi(+1,00)" />
  </asp:CheckBoxList>
 
 <asp:Button ID="Aggiungi" runat="server" Text="Aggiungi piatto"  OnClick="Aggiungi_Click"/>
 <asp:Button ID="Ordine" runat="server" Text="Concludi ordini" Onclick="Ordine_Click"/>

 
 <div id="Dettagli" runat="server">
     <h3>Dettaglio Ordine</h3>
 </div>

</asp:Content>
