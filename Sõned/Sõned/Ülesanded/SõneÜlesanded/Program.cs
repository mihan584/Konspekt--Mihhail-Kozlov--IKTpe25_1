namespace SõneÜlesanded
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //kirjuta program mis küsib kasutajalt tsüklis, millised mängud talle meeldivad
          //küsiniste tulemus hoia järjendis
          List<string> mängud =new List<string>();
            Console.WriteLine("Tere kasutaja, millised mängud sulle meeldivad?");
            string mäng = "";
            while (mäng != "ei ole")
            {
                Console.WriteLine("Palun sisesta järgmine mäng, kui ei ole kirjuta \"ei ole\"");
               mäng =  Console.ReadLine();
                if (mäng != "ei ole")
                {
mängud.Add(mäng);
                }
                
            }
            //foreach (var item in mängud)
            //{
            //    Console.WriteLine(item);
            //}
          //kui järjend sisaldab (.Contains()) "mario kart" siis küsi kui vana ta on, sarkatiliselt.
          if (mängud.Contains("mario kart"))
            {
                Console.WriteLine("kui vana sa oled????! mingi kuus vä?");
            }
            //kui järjend sisaldab "gta 6" siis küsi kust ta ajamasina sai, et rockstar lõpuks asjaga valmis sai
            if (mängud.Contains("gta6"))

            {
                Console.WriteLine("Kust ajamasina sail? Kuidas rockstar arendusaega juurde sai?");
            }
            //kui järjand sisaldab "pong" siis ütle "88ndad" tahavad vanureid tagasi, toimub boomerite recall.
            if (mängud.Contains("pong")) ;
            Console.WriteLine("88ndad tahavad vanureid tagasi, toimub boomerite recall");
          //kui järjend on tühi siis programm lähev edasi

            //küsi kasutajalt kas talle ei meeldi mängus, ning löase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestus .ToUpper() või .ToLower()iga
            if (!mängud.Any())
            {
                Console.WriteLine("Kas sulle ei meeldi mängud? Vasta kas jah või ei");
                string jahvõiei = Console.ReadLine().ToLower();
                if (jahvõiei.Contains("jah"))
                {
//kui ta vastab jah, siis ütle "aga miks siis ei sisestanud?"
                    Console.WriteLine("aga miks siis ei sisestanud?");
                }
                else if (jahvõiei.Contains("ei"))
                {
//kui talle ei meeldi, siis ütle, kahju
                    Console.WriteLine("kahju :");                   
                }
                else
                {
                    //kui vastus on midagi muud siis ütle "ei saa aru :/".
                    Console.WriteLine("ei saa aru :/");
                }
            }                        
           
        }
    }
}
