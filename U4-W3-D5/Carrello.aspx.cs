using System;
using System.Collections.Generic;
using System.Web.UI;

namespace U4_W3_D5
{
    public partial class Carrello : System.Web.UI.Page
    {
        public static List<Default.Prodotto> ProdottiNelCarrello { get; set; } = new List<Default.Prodotto>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CaricaCarrello();
            }
        }

        private void CaricaCarrello()
        {
            // Recupera il carrello dalla sessione
            List<Default.Prodotto> carrello = Session["Carrello"] as List<Default.Prodotto>;

            // Verifica se il carrello è nullo
            if (carrello != null)
            {
                // Visualizza i prodotti nel carrello utilizzando il Repeater
                ProdottiNelCarrello = carrello;
                rptCarrello.DataSource = carrello;
                rptCarrello.DataBind();
            }
        }

        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            // Svuota il carrello e aggiorna la visualizzazione
            Session["Carrello"] = null;
            ProdottiNelCarrello.Clear();
            CaricaCarrello();
            AggiungiMessaggio("Carrello svuotato con successo!");

            // Script per eseguire un redirect dopo 1,5 secondi
            ScriptManager.RegisterStartupScript(this, GetType(), "redirectScript", "setTimeout(function() { window.location.href = 'Carrello.aspx'; }, 1500);", true);
        }

        protected void btnTornaIndietro_Click(object sender, EventArgs e)
        {
            // Reindirizza alla pagina di default
            Response.Redirect("Default.aspx");
        }
        private void AggiungiMessaggio(string messaggio)
        {
            // Imposta il testo del controllo Label con il messaggio fornito
            lblMessaggio.Text = messaggio;

            // Rendi visibile il controllo Label sulla pagina
            lblMessaggio.Visible = true;
        }
    }
}
