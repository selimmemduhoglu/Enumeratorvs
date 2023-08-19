class calisan
{
    string isim;
    int maas;
    public calisan(string isim, int maas)
    {
        this.isim = isim;
        this.maas = maas;
    }
    public string ToString()
    {
        return "calisan isim : " + isim + " maasi : " + maas;
    }
}

class Program
{
    static void Main(string[] args)
    {
        calisan[] sirket = new calisan[5];

        sirket[0] = new calisan("ali", 100);
        sirket[1] = new calisan("veli", 200);
        sirket[2] = new calisan("ahmet", 300);
        sirket[3] = new calisan("selim", 400);
        sirket[4] = new calisan("muhammed", 400);
        sirket[5] = new calisan("mahmut", 400);

    }
    
}