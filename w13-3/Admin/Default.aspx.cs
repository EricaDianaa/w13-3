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
        public int Id { get;set; }

        public double PrezzoAggiunta { get; set; }

        public WebForm1() { }

        public WebForm1(int id, string pizza, double prezzo)
        {
            Id = id;
            NomePizza = pizza;
            Prezzo = prezzo;
         
        }
        public WebForm1(int id, string pizza, double prezzo,string Nomepizza, double Nomeprezzo) 
        {
            Id = id;
            NomePizza = pizza;
            Prezzo=prezzo;
            NomeAggiunta = Nomepizza;
            PrezzoAggiunta = Nomeprezzo;
        }

        
        

        public static  List<WebForm1> ListOrdine=new List<WebForm1>();
        public static  List<WebForm1> ListPizza = new List<WebForm1>();



        public static List<double> ListAggiunte = new List<double>();
        public static  List<double> ListCostoPizza = new List<double>();
        public static  List<double> TotaleOrdine = new List<double>();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            WebForm1 pizza1 = new WebForm1(1,"Margherita",6.00);
            WebForm1 pizza2 = new WebForm1(2, "Napoli", 8.00);
            WebForm1 pizza3 = new WebForm1(3, "Quattro Stagioni", 10.00);
            WebForm1 pizza4 = new WebForm1(4, "Salsiccia secca", 8.00);
            WebForm1 pizza5 = new WebForm1(5, "Frutti di mare", 15.00);
            WebForm1 pizza6 = new WebForm1(6, "Salsa rosa e gamberetti", 12.00);
            WebForm1 pizza7 = new WebForm1(7, "Ortolana", 9.00);
            WebForm1 pizza8 = new WebForm1(8, "Diavola", 8.00);

            ListPizza.Add(pizza1);
            ListPizza.Add(pizza2);
            ListPizza.Add(pizza3);
            ListPizza.Add(pizza4);
            ListPizza.Add(pizza5);
            ListPizza.Add(pizza6);
            ListPizza.Add(pizza7);
            ListPizza.Add(pizza8);


            WebForm1.ListPizza.Clear();


            }
         
        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            WebForm1.ListPizza.Clear();
            WebForm1.ListCostoPizza.Clear();
            WebForm1.ListOrdine.Clear();
            WebForm1.ListAggiunte.Clear();
            WebForm1.ListPizza.Clear();

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
          
            }        

        protected void Ordine_Click(object sender, EventArgs e)
        {
         
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

            for (int i = 0; i < ListOrdine.Count; i++)
            {
              Dettagli.InnerHtml = $" <div class='bg-info m-2 rounded-4'><h3>Dettaglio Ordine</h3>" +
                // $" <p>Pizze ordinate: {ListOrdine.Count}</p>"+
                 $" <p>Pizza: {ListOrdine[i].NomePizza} Prezzo: {ListOrdine[i].Prezzo.ToString("c2")}</p>"+
                 $" <p>{ListOrdine[i].NomeAggiunta}</p> <br> </div> <p class='bg-info m-2 rounded-4'>Il totale dell'ordine è: {Total.ToString("c2")}</p>";
            }
                


        }


        
    }
}