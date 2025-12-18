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
            foreach (var item in mängud)
            {
                Console.WriteLine(item);
            }
          //kui järjend sisaldab (Contains()) "mario kart" siis küsi kui vana ta on, sarkatiliselt.
          //kui järjend sisaldab "gta 6" siis küsi kust ta ajamasina sai, et rockstar lõpuks asjaga valmis sai
          //kui järjand sisaldab "pong" siis ütle "88ndad" tahavad vanureid tagasi, toimub boomerite recall.
          //kui järjend on tühi siis programm lähev edasi

            //küsi kasutajalt kas talle ei meeldi mängus, ning löase tal vastata sõnaga jah või ei, kontrolli kasutaja sisestus .ToUpper() või .ToLower()iga
            //kui talle ei meeldi, siis ütle, kahju
            //kui ta vastab jah, siis ütle "aga miks siis ei sisestanud?"
            //kui vastus on midagi muud siis ütle "ei saa aru :/".
        }
    }
}
