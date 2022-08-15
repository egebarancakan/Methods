internal class Program
{
    private static void Main(string[] args)
    {
        int a=2;
        int b=3;
        Console.WriteLine(a+b);
        int sonuc=topla(a,b);
        Console.WriteLine(sonuc);
        Metotlar ornek=new Metotlar();
        ornek.ekranaYaz(Convert.ToString(sonuc));
        int sonuc2=ornek.arttirVeTopla(ref a,ref b);
        ornek.ekranaYaz(Convert.ToString(sonuc2));
    }

    public static int topla(int x, int y)
    {
        return (x+y);
    }
}

class Metotlar
{
    public void ekranaYaz(string veri)
    {
        Console.WriteLine(veri);
    }

    public int arttirVeTopla(ref int deger1,ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return (deger1+deger2);
    }
}