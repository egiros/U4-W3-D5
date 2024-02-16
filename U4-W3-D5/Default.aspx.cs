using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace U4_W3_D5
{
    public partial class Default : System.Web.UI.Page
    {
        // Definizione di una classe prodotto
        public class Prodotto
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal Prezzo { get; set; }
            public string Immagine { get; set; }
            public string Descrizione { get; set; }
        }

        // Lista di prodotti
        public List<Prodotto> Prodotti = new List<Prodotto>
        {
            new Prodotto { Id = 1, Nome = "Airpods Pro", Prezzo = 299.90m, Immagine = "./Content/img/airpods-pro.jpg", Descrizione = "AirPods Pro seconda generazione con cancellazione attiva del rumore e trasparenza adattiva. Audio spaziale personalizzato. Tre taglie incluse. Chip Apple H2. Autonomia 6 ore di ascolto. Custodia di ricarica MagSafe." },
            new Prodotto { Id = 2, Nome = "iMac 24", Prezzo = 1699.90m, Immagine = "./Content/img/imac-24.jpg", Descrizione = "iMac 24\" Display Retina 4,5K. Chip Apple M3 8-core CPU e 10-core GPU, 256GB SSD. Magic Keyboard, Due porte Thunderbolt." },
            new Prodotto { Id = 3, Nome = "iPad 2022", Prezzo = 599.90m, Immagine = "./Content/img/ipad-10.jpg", Descrizione = "Display Liquid Retina 10.9\" con design all-screen. Chip A14 Bionic. Fotocamera frontale orizzontale da 12MP con ultra-grandangolo e Inquadratura automatica." },
            new Prodotto { Id = 4, Nome = "iPad Pro", Prezzo = 1299.90m, Immagine = "./Content/img/ipad-pro.jpg", Descrizione = "Display Liquid Retina da 11\". Tecnologie ProMotion, True Tone e ampia gamma cromatica P3. Chip Apple M2. Fotocamere pro con scanner LiDAR, e fotocamera frontale con ultra-grandangolo e Inquadratura automatica" },
            new Prodotto { Id = 5, Nome = "Macbook Air M2", Prezzo = 1399.90m, Immagine = "./Content/img/macbook-air-13.jpg", Descrizione = "Display Liquid Retina con True Tone. Chip Apple M2 con CPU 8-core, GPU 10-core e Neural Engine 16-core. 8GB di memoria unificata. Archiviazione SSD da 512GB. Magic Keyboard. Touch ID. Trackpad Force Touch. Due porte Thunderbolt / USB 4." },
            new Prodotto { Id = 6, Nome = "Macbook Pro M1", Prezzo = 999.90m, Immagine = "./Content/img/macbook-air-13-soc.jpg", Descrizione = "Display Retina con True Tone. Chip Apple M1 con CPU 8-core, GPU 7-core e Neural Engine 16-core. 8GB di memoria unificata. Archiviazione SSD da 256GB. Magic Keyboard. Touch ID. Trackpad Force Touch. Due porte Thunderbolt / USB 4." },
            new Prodotto { Id = 7, Nome = "Mac Mini", Prezzo = 699.90m, Immagine = "./Content/img/mac-mini.jpg", Descrizione = "Chip Apple M2 con CPU 8-core, GPU 10-core e Neural Engine 16-core. 8GB di memoria unificata. Archiviazione SSD da 512GB. Due porte Thunderbolt / USB 4, due porte USB-A (fino a 5 Gbps), porta HDMI, porta Gigabit Ethernet e jack da 3,5 mm per cuffie." },
            new Prodotto { Id = 8, Nome = "iPhone 15", Prezzo = 899.90m, Immagine = "./Content/img/iphone-15.jpg", Descrizione = "Apple iPhone 15 128GB" },
            new Prodotto { Id = 8, Nome = "iPhone 15 Plus", Prezzo = 1099.90m, Immagine = "./Content/img/iphone-15plus.jpg", Descrizione = "Apple iPhone 15 Plus 128GB" },
            new Prodotto { Id = 9, Nome = "iPhone 15 Pro", Prezzo = 1299.90m, Immagine = "./Content/img/iphone-15pro.jpg", Descrizione = "Apple iPhone 15 Pro 128GB" },
            new Prodotto { Id = 10, Nome = "iPhone 15 Pro Max", Prezzo = 1499.90m, Immagine = "./Content/img/iphone-15promax.jpg", Descrizione = "Apple iPhone 15 Pro Max 512GB" },


        };

        protected void Page_Load(object sender, EventArgs e)
        {
            // Carica i dati nella pagina solo al primo caricamento
            if (!IsPostBack)
            {
                CaricaProdotti();
            }
        }

        private void CaricaProdotti()
        {
            // Carica la lista di prodotti nel controllo di sessione
            Session["Prodotti"] = Prodotti;
        }

    }
}