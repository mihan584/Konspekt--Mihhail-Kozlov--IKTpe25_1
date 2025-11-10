

//1. tuvasta sisu võrdluses tühja stringiga, string andmetüüp
//using System.ComponentModel.Design;
//using System.Reflection;

//Console.WriteLine("Tere kasutaja, kuidas on sinu nimi?:");
//string nimi = Console.ReadLine();

//if (nimi == "")
//{
//    Console.WriteLine("Sa ei sisestanud oma nime, sadface 😔");
//}
//else if (nimi != "")
//{
//    Console.WriteLine("Tere "+nimi+"! häpifeiss 😀😀 おはよう");
//}
//else
//{
//    Console.WriteLine("Tundmatu sisestus.");
//}
////2 - vahemikud
//Console.WriteLine(nimi+", mis on sinu vanus?:");
//int kasutajavanus = int.Parse(Console.ReadLine());

////2.1 mitu tingimust pesastatud ifide abil
////if (kasutajavanus > 0)
////{
////    if (kasutajavanus < 18)
////    {
////        Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
////    }
////    else
////    {
////        Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
////    }
////}

////2.2 mitu tingimust kasutades loogilist tehet "and"
//if (kasutajavanus > 0 && kasutajavanus < 18)
//{
//    Console.WriteLine("Enerksi ei saa, oled alakas, Monsterist ilma 😔");
//}
//else
//{
//    Console.WriteLine("Yippie! saad monsut osta 😀⭐✨");
//}

////2.3 mitu vahemikku if/else-if abil. andmetüüp double/float/decimal
//Console.WriteLine($"Sisesta oma pikkus ka {nimi}!");
//double kasutajaPikkus = double.Parse(Console.ReadLine());

//if (kasutajaPikkus < 1.00d)
//{
//    Console.WriteLine("Oled juntsu (Keemstar)");
//}
//else if (kasutajaPikkus < 1.25d && kasutajaPikkus >= 1.00d)
//{
//    Console.WriteLine("Oled peaaegu allameetrimees");
//}
//else if (kasutajaPikkus < 1.50d && kasutajaPikkus >= 1.25d)
//{
//    Console.WriteLine("OIOI, päkapikk enam ei olegi, "+nimi);
//}
//else if (kasutajaPikkus < 1.75d && kasutajaPikkus >= 1.5d)
//{
//    Console.WriteLine(nimi+", oled enamasti standardpikkuses, kui mitte just natuke lühike");
//}
//else if (kasutajaPikkus < 2.00d && kasutajaPikkus >= 1.75d)
//{
//    Console.WriteLine(nimi+", oled pikk kolge, vaata et sa pead vastu uksepiita ära ei löö 😏'");
//}
//else
//{
//    Console.WriteLine("Täielik tulnukas! Kuidas pilved välja näevad lähedalt?");
//}


////3. kalkulaator ifi ja else-ifiga, int ja string andmetüübid
////Console.WriteLine("tere, sisesta esimene liidetav arv");
////int arv1 = int.Parse(Console.ReadLine());
////Console.WriteLine("tere, sisesta teine liidetav arv");
////int arv2 = int.Parse(Console.ReadLine());
////Console.WriteLine("sisesta tehemärk: / * + - ^");
////string tehtetyyp = Console.ReadLine();

////int tulemus = 0;
////if (tehtetyyp == "+")
////{
////    tulemus = arv1 + arv2;
////}
////if (tehtetyyp == "-")
////{
////    tulemus = arv1 - arv2;
////}
////if (tehtetyyp == "*")
////{
////    tulemus = arv1 * arv2;
////}
////if (tehtetyyp == "/")
////{
////    tulemus = arv1 / arv2;
////}
////if (tehtetyyp == "^")
////{
////    tulemus = (int)Math.Pow(arv1, arv2);
////}

////Console.WriteLine(tulemus);

////4 parool, if ja string andmetüüp
//Console.WriteLine($"Palun vabandust {nimi}, aga programmi edasiseks tööks on parooli vaja");
//string password = Console.ReadLine();
//if (password == "simsalabim")
//{
//    Console.WriteLine("JES, parool on õige, oled sisse lubatud");
//}
//else if (password == "saatana" || password == "1234")
//{
//    Console.WriteLine("Parool on sobimatu, see sinu parool kohe kindlasti ei ole.");
//}
//else
//{
//    Console.WriteLine("Parool on vale");
//}

////5 värvituvastus värvidele: punane oranz kollane roheline
//// helesinine tumesinine lilla roosa pruun must ja valge
//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "oranz")
//{
//    Console.WriteLine("Kahjuks ei ole oranz saadaval");
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.DarkGreen;
//}
//else if (favColour == "helesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Cyan;
//}
//else if (favColour == "tumesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "lilla")
//{
//    Console.BackgroundColor = ConsoleColor.DarkCyan;
//}
//else if (favColour == "roosa")
//{
//    Console.WriteLine("Kahjuks roosat anda ei ole");
//}
//else if (favColour == "pruun")
//{
//    Console.BackgroundColor = ConsoleColor.DarkYellow;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//    Console.ForegroundColor = ConsoleColor.Black;
//}
//else
//{
//    Console.WriteLine("ei tea seda värvi");
//}
//Console.WriteLine("The colour has maybe changed!!!!!");



//int tulemus = 0;

/* ISESEISEV ÜLESANNE */

//# Kolija kalkulaator - Kirjuta programm mis:
//#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
//#    - olenevalt kasutaja sisestusest küsib ta:
//#    - - tünni jaoks:
//#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
//#    - - - tünni kõrgust
//#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
//#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
//#    - - kasti jaoks:
//#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
//#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
//#    - - - - kui on risttahukas siis küsib kasutajalt:
//#    - - - - - pikima külje pikkust, 
//#    - - - - - lühima külje pikkust ja
//#    - - - - - kasti kõrgust
//#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)






//Console.WriteLine("banana");
//// Console -> adresseritav moodul või objekt (Roheline)
//// . -> midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga
////    - komakohtadega andmetüüpidel komakoha tähistamine.
//// WriteLine -> adresseritav funktsioon objektist Console
//// () -> sulupaar mis omab endas funktsioonile vajalikku infot
////     - saab kasutada ka if tingimuslauses oleva tingimuse piiramiseks, ehk teisiõnu "ifi parameeter"
////     - kasutatakse ka matemaatilistes tehetes
//// [] -> tähistab massiive
//// {} -> koodiplokk, tavaliselt pärast tingimust või funktsiooni kirjeldust.
////     - saab ka kasutada teksti sees muutujate kuvamiseks
//// -> taane aitab arendajal aru saada millise koodiploki sees, miski on. Vajalik ka kompilaatorile.
//// "banana" -> parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
//// ; -> iga koodilause lõppeb komakooloniga
//// // -> kommentaaritingmärk üherealise kommentaari jaoks (kaks / märki)

//int muutuja = 3;
//// int -> muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on
//// = -> võrdusmärk omistab sellele muutujale mingisuguse väärtuse
//// 3 -> väärtus mis sellele muutujale omistatakse

//võimalikud lihtandmetüübid:
int a = 1; // täisarv
decimal b = 2.0M; // kümnendsüsteemis olev komakohaga arv
float c = 3.0f; // kümnendsüsteemis olev ujukomaga arv
double d = 4.0d; // kümnendsüsteemis olev komakohaga arv, sarnane decimaliga
char c1 = 'a'; // üksainus täht või tähemärk
string s = "tekst"; // inimloetaval kujul tekst
var x = "abc"; // ebamäärase tüübiga kohalik muutuja. 
var y = 123;
const int z = 3; // konstant-tüüpi muutujaid ei saa muuta, need on read-only

//võimalikud komposiitandmetüübid
// 1. massiiv:
// [] - massiiv on komposiitandmetüübid, mille sees saab olla mitmeid samat tüüpi lihtandmeid. Massiivi tähistatakse kantsuludega.
// Massiive saab olla ükskõik millist lihtandmetüübi massiive.
// Esimene tekitusviis
int[] arvuMassiiv = new int[3];


// 2. loend:
// List <T> - Loend on komposiitandmetüüp, mille sees saab olla mitmeid samat tüüpi liht ja komposiitandmeid. Loend-tüüpi andmeid tähistatakse
// Täiendava andmetüübikirjeldusega "List" mille järel nuulsulgudesse asetatakse mis tüüpi andmed loendis on.
// Loendis tekitamisel, erinevalt massiviist, ei pea ütlema kui pikk loend on. Loendisse saab dünaamiliselt elemente juurde
// lisada, ehk tema pikkus ei ole fikseeritud.
// Sarnaselt massiiviga saab loend omada endas teisi loendeid.


// esimene tekkitusviis:
List<int> arvuNimekiri = new List<int>(); //Andmetüübi kirjeldus "List<>" näitab et tegu on loendiga, List noolsulgude vahel on loendis 
// olevate andmete andmetüüp. muutuja nimeks on "arvuNimekiri".
//Omistame sellese muutujasse laitstud sõna "new" uue tühja täisarvuloendi sätestusega "List<int> ()".
// teine tekitusviis
List<int> arvuNimekiri2 = new List<int>() {1 , 2 , 3}; //teine tekitusviis, muutuja instantseerimine võrdusmärgi ees on sama nagu
//esimesel, juurde tuleb ainult võrdusmärgi taga olevate sätestusele loogelised
//sulud koos juba sinna asetatud elemetiteg. Enam ei ole tegu tühja nimekirjaga,
// vaid loendiga kus on kolm elementi.ö

// kolmas tekitusviis
List<int> arvuNimekiri3 = new List<int>(3); //kolmas loendi tekitusviis kus muutuja instateerimise jääb samaks, aga tavaliste sulguse 
// vahel, sarnaselt massiviga saame anda loendile esialgne suurus. Loend ise ei oma veel 
// andmeid, aga loendis on kolm tühja elementi. Nimelt, on sätestusel, peale andmetüübi
// kirjeldavat noolsulguse, paar tavalisi sulge, mille sisse saab parameetriga panna loendi 
// pikkuse. ()

// ---- Loendi sisemised meetotid:
arvuNimekiri.Add(67); // Loendimeetod "Add() lisab enne punkti olevale järjendile uue elemendi, element mida lisadda, on Add meetodi 
// sulgude vahel. Elementi saab lisada otse (antud juhul 67) või muutujuna näiteks ... Add(A´arv);
int loendiPikkus = arvuNimekiri.Count(); // Loendi meetod "Count()" loeb kokku mitu elemendi järjendis on, meetod tagastab täisarvu 
// mis vastab elementi kogusele.
bool kasSeeArvOn = arvuNimekiri3.Contains(3); // Loendi meetod "Contins(3); otsib kogu järjendi seest elementi, mis vastab sulgude vahel
// olevate parameetrile, tagastab kas true või false on leitud või ei ole. Tegemist on põhimõteliselt foreach tsükliga, mis otsib kindlat parameetrid töödeldes läbi, kogu loendi

arvuNimekiri3.Remove(4) // Loendi meetod "Remove()" eemaldab enne punkti olevast loendist, kindlal asukohal oleva elemendi. Sulguse
    // vahel on parameetriks eemaldava elemendi asukoha´järjekorranumber



//andmetüüp int väljandab et tegu on täisarvutüübi andmega ja kantsulud väljandavad et tegu ühtlasi ka 
     // masiiviga. nimeks on "arvuMassiiv" ja võrdusmärgiga,                            on esimeńe tekitusmoodus öelda et tegu on
          // uue massiiviga kasutades kaitstud sõna "new" ja sellele järgneb massiivi pikkuse sätestus "int[3]"                      
           // see tähendab et siin massiivis on 3 elementi mis on täisarvud
                     


// Teine tekitusviis:
int[] arvuMassiiv2 = [1, 2, 3];  // teine massiivi tekitusviis, kus järjendi pikkuse sätestamine asemel, pannakse elemendid kohe sisse
// järjendi pikkus tuletatakse elementite arvust
// --- massiivi sisemised meetotid
int hasthismany = arvuMassiiv.Length; // massiivi meetod "Length" mille me saame kasutusele võtta punkti abil, loendab kokku, mitu
// elementi järjendis parasjagu on.


////põhilised matemaatilised tehted
//int liitmine = 1 + 1; // liitmine, kaks arvu kokku
//int lahutamine = 1 - 1; // lahutamine, esimene arv maha teisest
//int korrutamine = 1 * 1; //korrutamine, esimene arv korrutatakse teisega
//int jagamine = 1 / 1; //jagamine, esimene arv jagatakse teisega
//double astendamine = Math.Pow(2, 2); //astendamine, esimene arv astendatakse teisega
//double juurimine = Math.Sqrt(2); //ruutjuur, parameetriks arv mida juuritakse


//int arv = 0; // sobib
//string sõne = "abc"; //sobib
////string string = "abc"; //ei sobi

//// muutuja nimeks ei sobi järgnevad sõnad:
////abstract, as, base, bool, break, byte, case,
////catch, char, checked, class, const, continue, decimal,
////default, delegate, do, double, else, enum, event,
////explicit, extern, false, finally, fixed, float, for
////foreach, goto, if, implicit, in, int,
////interface, internal, is, lock, long, namespace, new,
////null, object, operator, out, override, params,
////private, protected, public, readonly, ref, return, sbyte,
////sealed, short, sizeof, stackalloc, static, string, struct,
////switch, this, throw, true, try, typeof, uint,
////ulong, unchecked, unsafe, ushort, using, virtual, void,
////volatile, while.

////Ülesanne, kasutades süntaksiseletust, kirjelda kommentaariga iga koodirida
//Console.WriteLine("tere, sisesta esimene liidetav arv");
////Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum
//// mis asub funktsiooni taga olevate sulgude vahel, antud rida lõppeb lauselõpumärgiga.
//int arv1 = int.Parse(Console.ReadLine());
//// int - Muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on.
//// = - võrdusmärk omistab sellele muutujale mingisuguse väärtuse.
//// int.Parse - väärtus mis sellele muutujale omistatakse.
//// Console - adresseritav moodul või objekt.
//// ReadLine - adresseritav funktsioon objektist Console.
//// () - sulupaar mis omab endas funktsioonile vajalikku infot.
//// ; - iga koodilause lõppeb komakooloniga.
//Console.WriteLine("tere, sisesta teine liidetav arv");
//// Console - adresseritav moodul või objekt.
//// WriteLine -  adresseritav funktsioon objektist Console.
//// () - sulupaar mis omab endas funktsioonile vajalikku infot.
//// " - saab ka kasutada teksti sees muutujate kuvamiseks.
//// ; - iga koodilause lõppeb komakooloniga.
//int arv2 = int.Parse(Console.ReadLine());
//// int - muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on.
//// = - võrdusmärk omistab sellele muutujale mingisuguse väärtuse.
//// . - midagi selle objekti seest, sarnane windowsi kausta pathis oleva slashiga.
//Console.WriteLine("sisesta tehemärk: / * + - ^");
//// ("sisesta tehtemärk: / * + - ^); - parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
//string tehtetyyp = Console.ReadLine();
//// tekitame muutuja "tehtetyyp" mille ette paneme andmetüübiks string ehk ütleme et seal on tekst, ning võrdusmärgi abil omistame talle 
//// konsooli rea pealt loetu info mis saame kasutades "Console" mooduli, ReadLine() funktsiooni. lause lõppeb lauselõpumärkiga ; .
//int tulemus = 0;
//// int - muutuja nime ees olev andmetüübi kirjeldus. See näitab ära mis tüüpi andmed selle muutuja sees on.
//// = - võrdusmärk omistab sellele muutujale mingisuguse väärtuse.
//// 0 - väärtus mis sellele muutujale omistatakse.
//if (tehtetyyp == "+")
//// kasutatakse tingimuslauses if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõna "+".
//// muutuja arv1 ja muutuja arv2 . Lause lõppeb lauselõpumärgiga sulgude sees.
//{
//    tulemus = arv1 + arv2;
//}
//if (tehtetyyp == "-")
//// kasutatakse tingimuslauses if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõna "-".
//// muutuja arv1 ja muutuja arv2 . Lause lõppeb lauselõpumärgiga sulgude sees.
//{
//    // sellega tuvastatakse kas on tegemist lahutamisega.
//    {
//        tulemus = arv1 - arv2;
//    }
//    if (tehtetyyp == "*")
//    // kasutatakse tingimuslauses if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõna "*".
//    //  muutuja arv1 ja muutuja arv2 . Lause lõppeb lauselõpumärgiga sulgude sees. 
//    {
//        tulemus = arv1 * arv2;
//    }
//    if (tehtetyyp == "/")
//    // kasutatakse tingimuslauses if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõna "/".
//    //  muutuja arv1 ja muutuja arv2 . Lause lõppeb lauselõpumärgiga sulgude sees. 
//    {
//        tulemus = arv1 / arv2;
//        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida kus muutujasse tulemus omistatakse nüüd väärtus jagades.
//        // 
//    }
//    if (tehtetyyp == "^")
//    // kasutatakse tingimuslauses if, ning sulgude vahele kirjutame tingimuseks kontrolli, kas muutuja "tehtetüüp" sisu on samal kujul, kui sõna "^".
//    //  muutuja arv1 ja muutuja arv2 . Lause lõppeb lauselõpumärgiga sulgude sees. 
//    {
//        tulemus = (int)Math.Pow(arv1, arv2);
//        // peale tingimust on koodiplokk {} loogeliste sulgude vahel. koodiplokk sisaldab endas ühte rida kus muutujasse tulemus omistatakse nüüd väärtus jagades.
//        // moodulist Math punkti abil funktsiooni "Pow()", selle sees on arv1 asendatavana esimene parameeter, ning arv2 astendajana teine parameeter.
//        // Funktsiooni ees on kiirteisendus kus funktsiooni väljund teisendatakse täisarvuks (int) abil. Lause lõppeb lauselõpumärkiga sulgude sees.
//    }

//    Console.WriteLine(tulemus);
    // Adresseerime moodulit "Console", punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum.
    // lause lõppeb lauselõppumärkiga.
//}// Adresseerime moodulit "Console" punkti abil ütleme et kasutame funktsiooni WriteLine, et kasutajale öelda sõnum.
// Parameeter mis antakse funktsioonile WriteLine töötlemiseks kaasa.
// " - saab ka kasutada teksti sees muutujate kuvamiseks.
// ; - iga koodilause lõppeb komakooloniga.
//
Console.WriteLine("Palun sisesta ostusumma");

double ostusumma = double.Parse(Console.ReadLine());
 
if (ostusumma > 100)

{
    Console.WriteLine("Saa 20% allahindlust!");
}
else if (ostusumma < 101 && ostusumma > 50)
{
    Console.WriteLine("Saad 10% allahindlust!"); }
else if (ostusumma < 51 && ostusumma > 20)
{
    Console.WriteLine("Saad 5% allahindlust");
}
else if (ostusumma < 21)
{
    Console.WriteLine("Allahindlust ei saa");
}
else if (ostusumma < 1)
{

}
    Console.WriteLine("Sisestatud vigane arv");


//* tingimuslause usad */
if (true) { } // kaitstud sõna if kutsub esile tingimuslause, mille tingimus on sulgude vahel ning millele järgneb koodiplokk tingimuse täitumisel teostava koodiga
else if (true) { } // kaitstud sõnad else ja id (else if) kutsuvad esile sekundaarse tingimuslause mille tingimus //on samamoodi sulgude vahel ning millele peab eelnema alati if või else if. tingimuslause täitumisel // ja eelneva tingimuse mittetäitumisel teostatakse koodiploki sees olev kood.
else {} // kaitstud sõna else kutsub esile järeltingimuse, millele peab eelnema kas //if või else if, ning mille koodi plokki sisu täidetakse kõikide if ja else if sees olevate tingimuste läbikukkumisel.

int option = 3; // -------
switch (option) //"switch" on kaitstud sõna alternatiivse tingimuskontrolli jaoks mida saab if else-if asemel kasutada.
    //Sulgude vahele käib muutuja nimi, mille põhjal tingimuslik ümberlülitus toimub. Siin sulgude vahel ei ole tingimus ise, vaid kõigest kontrollitav muutuja, või omakorda sulgude vahel muu tingimus.
    //pärast lülitusvalikut tuleb koodiplokk
   
{
    case 1: //koodiplokki sees on erinevad juhtumid. juhttumit kontrollitakse kaitstud sõna "case abil. Antud juhul kontrollitakse , kas muutuja on väärtus 1 , millele järgneb koolon":"
        //peale koolonit kirjeldatakse tehtav tegevus.

        break; //ja kui tegevus on täidetud, väljutakse kogu switch tegevusest kaitstud sõna "breakiga. Peale breaki on lauselõppumärk.
    case 2:
        break;
    case 3:
        break;
        //juhtumeid võib olla mitmeid, antud juhul on neid kolm kindlat, ja üks mida tehakse igal muul juhul.

    default: //kaitstud sõna "default2 avab juhtumi kui muutujas ei ole mitte ühtegi muud "case juhtumi tingimust.
        break; // ka default lõppeb sõnaga "break"
}

/* Sõne tööriistad ja tekstiga seotud */
string alfa = "a\nb";   // \n - tekitab ühe sõne sisse reamurde, sõne kus on üks "\n" omab kahte rida
string beta = $"{alfa}";  //$ - lubab kasutada muutujaid loogeliste sulgude vahel otse teksti sees.


/* Loogilised tehted */
//&& -"and" loogiline tehe, mida kasutatakse tingimuste kirjutamisel ning mis annab positiivse vastuse (true) juhul kui // mõlemal pool && märki olevad tingimused on täidetud. Kui üks neist ei ole, siis annab negatiivse vastuse (false).
//|| -"or" loogiline tehe, mida kasutatakse tingimuste kirjutamisel, ning mis annab positiivse vastuse (true) siis kui vähemalt üks tingimus on täidetud. negatiivne vastus (false) tagastatakse siis, kui kõik tingimused on täitmata.
// ! -"not" loogiline tehe, mida kasutatakse tingimuse tulemuse inverteerimiseks. Tulemus mis muidu tagastaks true, hüüumärki puhul tagastab false, ja vastupidi - tulemus mis muidu tagastaks false hüüumärgi puhul tagastab true.

/* Võrdlusoperaatorid */
// == - on võrdne. Võrdusmärki ühel pool olev objekt peab vastama täpselt oma olemuselt võrdusmärki teisel pool oleva objektiga. ei ole sama nagu üks võrdusmärk
// üks võrdusmärk omistab kaks võrdleb
// != - ei ole võrdne. Võrdusmärgi ühel pool olev objekt *EI TOHI* olla samal kujul nagu teisel pool olev objekt.
// Võrdusoperaator on kombinatsioon "on võrne" operaatorist ja loogilistest tehtest "not".
// >= - on suurem kui või võrdne kui . Märgist vasakul pool olev objekt peaks olema vähemalt võrdne kui suurem 
// kui paremal poll olev objekt. Operaator on kombinatsioon "on võrdne" ja "on suurem kui" operaatoritest.
// <= - on väiksem kui või võrdne kui. Märgist vasakul pool olev objekt peaks olema vähemalt võrdne või väiksem kui paremal pool olev objekt. Operaator on kombinatsioon "on võrdne" ja "on väiksem kui" operaaatoritest.

/* Omitusoperaatorid */
int arv = 1; // = - üksik võrdusmärk omistab muutujale väärtuse.
arv += 1; // += - võrdusmärk mille ees on pluss, automaatselt liidab muutujale otsa võrdusmärgi teisel pool oleva arvu.
// asendab tehet "arv = arv - 1". on kombinatsioon matemaatilisest tehest "-" ja omistamisest (=")
arv *= 2; // *= - võrdusmärk mille ees on korrutusmärk *. automaatselt korrutab muutuja sisu võrdusmärgi teisel pool oleva arvu kordi. asendab tehet "arv = arv * 2". on kombinatsioon matemaatilisest tehtest "*" ja omistamisest (=)
arv /= 2; // /= - võrdusmärk mille ees on jagamismärk /. automaatselt jagab muutuja sisu võrdusmärgi teisel pool oleva arvu osadeks. asendab tehet "arv = arv / 2". on kombinatsioon matemaatilisest tehtest "/" ja omistamisest (=)
arv++; // ++ - on spetsiifiliselt ühe juurde liitmiseks lühivariant.
arv--; // -- - on spetsiifiliselt ühe maha liitmiseks lühivariant.----


/* Tsüklid */
do // "do" on kaitstud sõna, mis alustab do-while tsüklid pärast mida on koodi plokk , ning ütleb et tee seda koodi
  
{
    d++; 
} while (d !=5); //niikaua kuni while järel olevate sulgute vahel olev tingimus on täidetud.
// 2. while
int i = 1; // tsüklimuutuja mis kontrollib "while" tsükli tööd
while (i < 5)
//antud juhul on selleks i. Tsükli tingimus, mis peale "while" sõna on, sulgude vahel, kontrollibki tingimuse abil, selle muutuja olekut.
// Siin kontrollitakse, et tsükkel ei oleks suurem kui 5, kui ta on, siis tsükkli töö loppeb.
{
    //koodiplokk kus midagi tehakse
    i++; //ning seejärel muudetakse tsüklimuutuja "i" olekut, antud juhul liidetakse 1 juurde.

while (i < 5)
    {

    }//"while" on kaitstud sõna mis alustab while tsükli varianti, ilma do-ta ning vajab tihtipeale välist tsüklimuutujat
 }             




    // 3. for
    int kogus = 6; // muutuja mida tsükkel kasutab töötlemiseks mingisugusel kujul
for (int k = 0; k < kogus; k++) // kaitstud sõna "for" alustab for tsüklit, pärast mida on sulud, mille vahel on kõik tsükli töö jaoks vajalik info. esimene parameeter tekitab tsükli töö jaoks muutuja "int k = 0;", teine parameeter on tingimuslause mis kontrollib tingimuslause täitumist "k < kogus;" ning kolmas inkrementeerib tekitatud muutujad "k++;", pane tähele et iga sulgude vahel oleva osa järel on lauselõpumärk. Tsükli tööd kontrolliv tingimuslause koosneb kolmest reast, mitte ühest nago while, või do-while puhul. koodiplokk kus tehakse mingi tegevus 
{
    Console.WriteLine(k); //antud juhul on tegevuseks muutuja "k" arvu väljakuvamine.
}

//4. foreach
int[] arvuLoend = { 3, 89, 123412, 7, 67 }; //massiiv mida foreach tsükkel kasutab, või töötleb mingil kujul.
foreach (var arvInLoend in arvuLoend) //kaitstud sõna foreach alustab foreach tsükli. pärast mida on sulud, mille vahel tekitakse ajutine muutuja andmetüübiga "var" töödeldava andmekogumi üksikelemendi jaoks. süntaksis olev kaitstud sõna "in" väljendb et tsükkel käib selle loendi elementide kohta, ning var "arvInLoend
                                      //muutuja hoiab endab just peale sõna "in" oleva andmekogumi elementi. Tsüklil ei ole nähtavat tsüklimuutujat ega tingimust., tsükkel toimib niikaua kuni elemente jätkub ehk tsükli töö käib 
                                      //iga üksiku elemendi kohta andmekogumis. Tsüklil ei ole vaja tsüklimuutujat, kuna talle on sisse ehitatud vaikimisi elemendi järjestuse jälgimine. Niipalju kui andmeid on, ongi see
                                      //mitu korda tsükkel käivitakse.


{ // {} koodiplokk kus tehakse mingi tegevus.
    Console.WriteLine(arvInLoend);// antud juhul kuvatakse välja ajutine //muutujamille sees on loendi elementi
    }