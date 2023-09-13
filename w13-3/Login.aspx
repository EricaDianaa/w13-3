<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="w13_3.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div id="login" class="bg-dark h-100 p-5">
     <div id="CIAO" class="d-flex flex-column justify-content-center border border-dark text-white text-center  border border-white rounded-5  m-5 p-3">
     <h4>Inserisci nome</h4>0
     <asp:TextBox ID="Nome" runat="server"></asp:TextBox>
     <h4>Inserisci Password</h4>
     <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
         <br />
     <asp:Button CssClass="btn btn-success" ID="Button1" runat="server" Text="Invia" Onclick="Button1_Click"/>
  
         
   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="Nome" runat="server" 
   ErrorMessage="Il campo nome non è stato compilato" CssClass="fw-bold text-danger"></asp:RequiredFieldValidator>

   <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Password" runat="server" 
   ErrorMessage="Il campo password non è stato compilato" CssClass="fw-bold text-danger"></asp:RequiredFieldValidator>
</div>

 </div>
</asp:Content>
