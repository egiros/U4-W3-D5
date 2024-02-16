﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dettaglio.aspx.cs" Inherits="U4_W3_D5.Dettaglio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Dettaglio Prodotto</title>
    <link rel="stylesheet" href="Content/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h1 class="text-center fw-bold mb-5">Dettaglio Prodotto</h1>

            <div class="mb-3">
                <asp:Image ID="imgProdotto" runat="server" CssClass="img-fluid mb-4" />
                <h2><asp:Label ID="lblNomeProdotto" runat="server" CssClass="text-dark" /></h2>
                <p><strong>Prezzo:</strong> <asp:Label ID="lblPrezzoProdotto" runat="server" CssClass="text-success" /></p>
                <p><strong>Descrizione:</strong> <asp:Label ID="lblDescrizioneProdotto" runat="server" CssClass="text-secondary" /></p>
            </div>
            <asp:Label ID="lblMessaggio" runat="server" CssClass="alert alert-success" Visible="false"></asp:Label>
            <div class="text-center my-3">
            
            <asp:Button ID="btnTornaDefault" runat="server" Text="Torna a Prodotti" CssClass="btn btn-secondary" OnClick="btnTornaDefault_Click" />
            <asp:Button ID="btnAggiungiAlCarrello" runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-success" OnClick="btnAggiungiAlCarrello_Click" />
            <asp:Button ID="btnVaiAlCarrello" runat="server" Text="Vai al Carrello" CssClass="btn btn-danger" OnClick="btnVaiAlCarrello_Click"/>
        </div>
        </div>
    </form>
    <footer class="text-center">
    <hr class="my-4">
    <p>&copy; 2024 EPISTORE. Tutti i diritti riservati.</p>
</footer>
</body>
</html>