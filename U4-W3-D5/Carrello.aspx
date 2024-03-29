﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="U4_W3_D5.Carrello" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Carrello</title>
     <link rel="stylesheet" href="Content/bootstrap.min.css" />
    <style>
        .card {
            transition: transform 0.2s;
        }

        .card:hover {
            transform: scale(1.02);
        }

        .immagine-prodotto {
            max-height: 200px;
            object-fit: cover;
        }

        .carrello-container {
            margin-top: 50px;
        }
    </style>
</head>
<body class="bg-light">
   <form id="form1" runat="server">
        <div class="container mt-5">
            <h1 class="text-center fw-bold mb-5">EPISTORE - Carrello</h1>
            <div class="d-flex align-items-center justify-content-center my-3">
                <asp:Label ID="lblMessaggio" runat="server" CssClass="alert alert-success fs-5" Visible="false"></asp:Label>
            </div>
            
            <div class="row carrello-container">
                <asp:Repeater ID="rptCarrello" runat="server">
                    <ItemTemplate>
                        <div class="col-md-4">
                            <div class="card shadow-lg mb-2">
                                <img src="<%# Eval("Immagine") %>" alt="<%# Eval("Nome") %>" class="card-img-top immagine-prodotto" />
                                <div class="card-body">
                                    <h5 class="card-title"><%# Eval("Nome") %></h5>
                                    <p class="card-text"><strong>Prezzo:</strong> <%# string.Format("{0:C}", Eval("Prezzo")) %></p>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
            <div class="row mt-4">
                <div class="col-md-6 text-center">
                    <asp:Button ID="btnTornaIndietro" runat="server" Text="Torna Indietro" OnClick="btnTornaIndietro_Click" CssClass="btn btn-dark" />
                </div>
                <div class="col-md-6 text-center">
                    <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Svuota Carrello" OnClick="btnSvuotaCarrello_Click" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </form>
    <div class="container mt-5">
        <footer class="text-center">
            <hr class="my-4">
            <p>&copy; 2024 EPISTORE. Tutti i diritti riservati.</p>
        </footer>
    </div>
</body>
</html>