// Butun kodlari parcalayarak buglara daha hizli cozum bulmak ve kod tekrarlarini onlemek icin kullaniriz.



int a = 2 ; 
int b = 3 ; 
Console.WriteLine(a+b);
int sonuc = Topla(a,b);

Metotlar ornek = new Metotlar();
ornek.EkranaYazdir(Convert.ToString(sonuc));
ornek.EkranaYazdir(Convert.ToString(ref a, ref b));


static int Topla(int deger1, int deger2) //CoolbyValue
{
    return deger1 + deger2;
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public int ArttirveTopla(int deger1 , int deger2 )
    {
        deger1 +=1;
        deger2 +=1;  
        return deger1 + deger2;

    }

}








