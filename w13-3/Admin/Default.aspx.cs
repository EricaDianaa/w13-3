using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace w13_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public string NomePizza { get; set; }
        public string NomeAggiunta { get; set; }
        public string Aggiunte { get; set; }
        public double Prezzo { get; set; }
        public double sum { get; set; } = 0;
        public double sum2 { get; set; } = 0;
        public double Tot { get; set; } = 0;
        public double Total { get; set; } = 0;

        public double PrezzoAggiunta { get; set; }

        public WebForm1() { }
        public WebForm1(string pizza, double prezzo,string Nomepizza, double Nomeprezzo) 
        {
            NomePizza = pizza;
            Prezzo=prezzo;
            NomeAggiunta = Nomepizza;
            PrezzoAggiunta = Nomeprezzo;
        }

        
        

        public List<WebForm1> ListOrdine=new List<WebForm1>();
        public List<double> ListAggiunte = new List<double>();
        public List<double> ListCostoPizza = new List<double>();
        public List<double> TotaleOrdine = new List<double>();



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
    if (IsPostBack)
            {

            WebForm1 pizza = new WebForm1();
               pizza.NomePizza = DropDownList1.SelectedItem.Text;
               pizza.Prezzo =Convert.ToDouble(DropDownList1.SelectedItem.Value);

            for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
               
                    double prezzoaggiunta=Convert.ToDouble(CheckBoxList1.Items[i].Value);

                    pizza.NomeAggiunta = CheckBoxList1.Items[i].Text;
                    pizza.PrezzoAggiunta = Convert.ToDouble(CheckBoxList1.Items[i].Value);
                    ListAggiunte.Add(prezzoaggiunta);
                   
                   
                }
            }
            
            ListOrdine.Add(pizza);
                    ListCostoPizza.Add(pizza.Prezzo);
            for (int i = 0; i < ListAggiunte.Count; i++)
            {
                
                sum += ListAggiunte[i];
            }

            for (int i = 0; i < ListCostoPizza.Count; i++)
            {

                sum2 += ListCostoPizza[i];
            }

            Tot = sum += sum2;
            TotaleOrdine.Add(Tot);

            for (int i = 0; i < TotaleOrdine.Count; i++)
            {

             Total += TotaleOrdine[i];
            }
            }
        }

        protected void Ordine_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                WebForm1 pizza = new WebForm1();
                pizza.NomePizza = DropDownList1.SelectedItem.Text;
                pizza.Prezzo = Convert.ToDouble(DropDownList1.SelectedItem.Value);

                for (int i = 0; i <= CheckBoxList1.Items.Count - 1; i++)
                {
                    if (CheckBoxList1.Items[i].Selected)
                    {

                        double prezzoaggiunta = Convert.ToDouble(CheckBoxList1.Items[i].Value);

                        pizza.NomeAggiunta = CheckBoxList1.Items[i].Text;
                        pizza.PrezzoAggiunta = Convert.ToDouble(CheckBoxList1.Items[i].Value);
                        ListAggiunte.Add(prezzoaggiunta);


                    }
                }

                ListOrdine.Add(pizza);
                ListCostoPizza.Add(pizza.Prezzo);

                for (int i = 0; i < ListAggiunte.Count; i++)
                {

                    sum += ListAggiunte[i];
                }

                for (int i = 0; i < ListCostoPizza.Count; i++)
                {

                    sum2 += ListCostoPizza[i];
                }

                Tot = sum += sum2;
                TotaleOrdine.Add(Tot);

                for (int i = 0; i < TotaleOrdine.Count; i++)
                {

                    Total += TotaleOrdine[i];
                }
            }
        
        Dettagli.InnerHtml = $"Il totale è: {Total}";


        }
    }
}