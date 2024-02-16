using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static U4_W3_D5.Default;

namespace U4_W3_D5
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            if (!IsPostBack)
            {
                // Verifica se è presente un parametro "id" nella query string
                if (Request.QueryString["id"] != null)
                {
                    // Ottieni l'ID del prodotto dalla query string
                    int idProdotto;
                    if (int.TryParse(Request.QueryString["id"], out idProdotto))
                    {
                        // Carica e visualizza le informazioni del prodotto
                        CaricaDettagliProdotto(idProdotto);
                    }
                }
            }


        }

        private void CaricaDettagliProdotto(int idProdotto)
        {
            // Recupera la lista di prodotti dalla sessione
            var listaProdotti = Session["Prodotti"] as List<Prodotto>;

            if (listaProdotti != null)
            {
                // Cerca il prodotto nella lista utilizzando TrovaProdottoPerId
                var prodotto = TrovaProdottoPerId(idProdotto, listaProdotti);

                if (prodotto != null)
                {
                    // Visualizza le informazioni del prodotto nella pagina
                    imgProdotto.ImageUrl = prodotto.Immagine;
                    lblNomeProdotto.Text = prodotto.Nome;
                    lblPrezzoProdotto.Text = string.Format("{0:C}", prodotto.Prezzo);
                    lblDescrizioneProdotto.Text = prodotto.Descrizione;
                }
            }
        }

        private Default.Prodotto TrovaProdottoPerId(int idProdotto, List<Default.Prodotto> listaProdotti)
        {
            // Implementa la logica per trovare il prodotto per ID
            return listaProdotti.FirstOrDefault(p => p.Id == idProdotto);
        }

        protected void btnTornaDefault_Click(object sender, EventArgs e)
        {
            // Reindirizza alla pagina di default 
            Response.Redirect("Default.aspx");
        }

        protected void btnVaiAlCarrello_Click(object sender, EventArgs e)
        {
            // Reindirizza alla pagina carello
            Response.Redirect("Carrello.aspx");
        }

        protected void btnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            // Recupera l'ID del prodotto dalla query string
            int idProdotto;
            if (int.TryParse(Request.QueryString["id"], out idProdotto))
            {
                // Trova il prodotto nella lista dei prodotti
                var prodotto = (Session["Prodotti"] as List<Default.Prodotto>)?.FirstOrDefault(p => p.Id == idProdotto);

                // Aggiungi il prodotto al carrello se è stato trovato
                if (prodotto != null)
                {
                    // Recupera il carrello dalla sessione
                    List<Default.Prodotto> carrello = Session["Carrello"] as List<Default.Prodotto>;

                    // Verifica se il carrello è nullo e crea una nuova istanza se necessario
                    if (carrello == null)
                    {
                        carrello = new List<Default.Prodotto>();
                    }

                    // Aggiungi il prodotto al carrello
                    carrello.Add(prodotto);

                    // Aggiorna il carrello nella sessione
                    Session["Carrello"] = carrello;

                    // Aggiungi il messaggio di successo
                    AggiungiMessaggio("Prodotto aggiunto al carrello con successo!");
                }
                else
                {
                    // Aggiungi il messaggio di errore se il prodotto non è stato trovato
                    AggiungiMessaggio("Errore durante l'aggiunta del prodotto al carrello. Riprova più tardi.");
                }
            }
            else
            {
                // Aggiungi il messaggio di errore se l'ID del prodotto non è valido
                AggiungiMessaggio("Errore durante l'aggiunta del prodotto al carrello. Riprova più tardi.");
            }
        }

        private void AggiungiMessaggio(string messaggio)
        {
            // Assegna il messaggio al controllo Label
            lblMessaggio.Text = messaggio;

            // Imposta il controllo Label come visibile
            lblMessaggio.Visible = true;

            // Aggiungere un ritardo nella chiusura del messaggio 
            ScriptManager.RegisterStartupScript(this, GetType(), "HideMessage", "$('.alert').fadeOut(2000);", true);
        }


    }


}