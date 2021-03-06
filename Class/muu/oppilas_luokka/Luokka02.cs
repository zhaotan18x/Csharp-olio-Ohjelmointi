Tässä ohjelmassa käy kuin Opettaja ja Oppilas luokka, tai kuin methodi/moduuli. On oma opettajamoduuli ja oppilasmoduuli,
joista kaikkilla on string nimi ja tulostaa metodin eli nimet ja jäsenet.

Luokiteltuna jokaisesta 2 opettaja, oppilas ja moduulia.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opettaja 
            List<Ope> ope = new List<Ope>();        
            ope.Add(new Ope() { OpeName = "Fysiikka",       OpeId = 1 });
            ope.Add(new Ope() { OpeName = "Matematiikka",   OpeId = 2 });
            ope.Add(new Ope() { OpeName = "Celcius",        OpeId = 3 });

            //Oppilas lista
            List<Oppilas> oppilas = new List<Oppilas>();
            oppilas.Add(new Oppilas() { OppilasName = "Derivaatta", OppilasId = 1 });
            oppilas.Add(new Oppilas() { OppilasName = "Kulmakerroin", OppilasId = 2 });
   
            //ID on pelkä sarjanumero / mones henkilö

            /*console.writeline määrittyy mitkä tulevat tulostuksessa ensimmäisenä
             * esim tässä foreach(Ope aOpe in ope) tulostuu ensimmäisenä
             * mutta jos foreach(Oppilas aOppilas in oppilas) käänteisessä vaan
             * toi console.writeline() listan järjestys tulostus
             */
            Console.WriteLine();
            foreach (Ope aOpe in ope)
            {
                Console.WriteLine(aOpe);
            }

            Console.WriteLine();
            foreach (Oppilas aOppilas in oppilas)
            {
                Console.WriteLine(aOppilas);
            }

            Console.WriteLine("\nOpettajia & Lehtoria: {0}", ope.Count);
            Console.WriteLine("Oppilaita: {0}", oppilas.Count);
            /*tulostuu vain oma luokkan listan x määrä, mitä listassa lukee
             * että opettajien määrä, eli yhteenssä             
             */

            ope.TrimExcess();
            Console.WriteLine("\nOpettajia()");
            Console.WriteLine("Henkilöstö: {0}", ope.Count);
            //yhteenveto, että uusi rivi, jossa tunnistaa oman määrän mitäkin on yhteensä

            oppilas.TrimExcess();
            Console.WriteLine("\nWanted:()");
            Console.WriteLine("Oppilaita on: {0}", oppilas.Count);


        }
    }
}


luokka opettaja cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Ope : IEquatable<Ope>
{
    public string OpeName
    {
        get;
        set;
    }

    public int OpeId
    {
        get;
        set;
    }

    public override string ToString()
    {
        Console.WriteLine("Opettaja:");
        return "ID: " + OpeId + "   Name:   " + OpeName;
        //ID, mones luku ja näin ja + opettajien nimi
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Ope objAsOpe = obj as Ope;

        if (objAsOpe == null)
            return false;
        else return Equals(objAsOpe);

    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public bool Equals(Ope other)
    {
        if (other == null) return false;
        return (this.OpeId.Equals(other.OpeId));
    }
}


luokka oppilas cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*IEquatable:: rajapintaan tulevat vertailuksi peläkän Equals-metodin
 * pohjatoteutuksen perusteella, mikä pahmmillaan tarkoittaa pelkän
 * objektista generoidun tarkistearvon vertailua. Jossain tilanteissa
 * tämä saattaa olla haluttu toimintamalli, toisissa taas tärkemäpää
 * olisi tietää vastaako objekti sisäiseltä
 * tilaaltaan vertailtava objektia.
 
     */

public class Oppilas : IEquatable<Oppilas>
{
    public string OppilasName
    {
        get;
        set;
    }
    public int OppilasId
    {
        get;
        set;
    }

    public override string ToString()
    {
        Console.WriteLine("Oppilas:");
        return "ID: " + OppilasId + "   Name: " + OppilasName;
        //ID, mones luku ja näin ja + oppilaan nimi
        
    }

    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        Oppilas objOppilas = obj as Oppilas;
        if (objOppilas == null) return false;
        else return Equals(objOppilas);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public bool Equals(Oppilas Other)
    {
        if (Other == null) return false;
        return (this.OppilasId.Equals(Other.OppilasId));
    }
}
