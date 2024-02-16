<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="U4_W3_D5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Default</title>
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


    </style>
</head>
<body class="bg-light">
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <div class="container">
                <a class="navbar-brand" href="#">EPISTORE</a>
                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>
                <div class="collapse navbar-collapse" id="navbarNav">
                    <ul class="navbar-nav ml-auto">
                        <li class="nav-item">
                            <a class="nav-link" href="#">Dove Siamo</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Chi Siamo</a>
                        </li>
                        <li class="nav-item">
                            <a class="nav-link" href="#">Contatti</a>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
         <div class="container mt-5">
             <h1 class="text-center d-5 mb-5">EPISTORE</h1>
            <h2>Prodotti in Vendita</h2>

            <div class="row">
                <% foreach (var prodotto in Prodotti) { %>
                    <div class="col-md-4">
                        <div class="card shadow mb-2">
                            <img src="<%= prodotto.Immagine %>" alt="<%= prodotto.Nome %>" class="card-img-top immagine-prodotto"/>
                            <div class="card-body">
                                <h5 class="card-title"><%= prodotto.Nome %></h5>
                                <p class="card-text"><strong>Prezzo:</strong> <%= string.Format("{0:C}", prodotto.Prezzo) %></p>
                                <a href="Dettaglio.aspx?id=<%= prodotto.Id %>" class="btn btn-dark">Dettagli</a>
                            </div>
                        </div>
                    </div>
                <% } %>
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
