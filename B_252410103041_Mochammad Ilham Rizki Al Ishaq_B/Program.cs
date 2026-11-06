class agen
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public agen(string IdAgen, string NamaAgen, int StokAgen)
    {
        idAgen = IdAgen;
        namaAgen = NamaAgen;
        stokAgen = StokAgen;
    }

    public void TampilInfo()
    {
        Console.WriteLine($"ID    : {idAgen}");
        Console.WriteLine($"Nama  : {namaAgen}");
        Console.WriteLine($"Stok  : {stokAgen}");

    }




}
abstract class ProdukGalon
{
    private string idProduk;
    private string namaProduk;
    private int stokGudang;

    public string IdProduk
    {
        get { return idProduk; }
        set { idProduk = value; }
    }
    public string NamaProduk
    {
        get { return namaProduk; }
        set { namaProduk = value; }
    }
    public int StokGudang
    {
        get { return stokGudang; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Katanya di soal tidak boleh negatif");
            }
            else stokGudang = value;
        }
    }



    public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
    {
        IdProduk = idProduk;
        NamaProduk = namaProduk;
        StokGudang = stokGudang;
    }

    int a = 0;

    public int KurangiStok(int a)
    {
        return StokGudang - a;


        Console.WriteLine($"Jumlah galon setelah dikurang = {StokGudang}");
    }

    public void info()
    {
        Console.WriteLine($"ID = {IdProduk}");
        Console.WriteLine($"nama = {NamaProduk}");
        Console.WriteLine($"stok = {StokGudang}");
        Console.WriteLine($"jenis air galon berkeran langsung dengan harga Rp12.000 per galon. galon jenis ini memiliki jenis keran yang berbeda beda");

    }

    int jumlah = 0;
    int hasil = 0;

    public abstract int HitungBiaya(int jumlah);


}



class GalonAkua : ProdukGalon
{
    public GalonAkua(string idProduk, string namaProduk, int stokGudang) : base(idProduk, namaProduk, stokGudang)
    {

    }
    public int KurangiStok(int a)
    {
        return StokGudang - a;

    }

    int jumlah = 0;
    int hasil = 0;
    public override int HitungBiaya(int jumlah)
    {
        int hasil = jumlah * 12000;
        return hasil;

    }

    public void info()
    {
        Console.WriteLine($"ID = {IdProduk}");
        Console.WriteLine($"nama = {NamaProduk}");
        Console.WriteLine($"stok = {StokGudang}");
        Console.WriteLine($" jenis air galon bermerek resmi dengan harga Rp20.000 per galon.");

    }
}


class GalonBerkeran : ProdukGalon
{
    public GalonBerkeran(string IdProduk, string NamaProduk, int StokGudang) : base(IdProduk, NamaProduk, StokGudang)
    {

    }
    public int KurangiStok(int a)
    {
        return StokGudang - a;

    }

    int jumlah = 0;
    int hasil = 0;
    public override int HitungBiaya(int jumlah)
    {
        int hasil = jumlah * 20000;
        return hasil;

    }

    public void info()
    {
        Console.WriteLine($"ID = {IdProduk}");
        Console.WriteLine($"nama = {NamaProduk}");
        Console.WriteLine($"stok = {StokGudang}");
        Console.WriteLine($"jenis air galon berkeran langsung dengan harga Rp12.000 per galon. galon jenis ini memiliki jenis keran yang berbeda beda");

    }


}

interface DapatDiDistribusikan
{


}






class SindikatGalon
{
    public string idAgen;
    public string namaAgen;
    public int stokAgen;

    public SindikatGalon(string IdAgen, string NamaAgen, int StokAgen)
    {
        idAgen = IdAgen;
        namaAgen = NamaAgen;
        stokAgen = StokAgen;
    }

    public void TampilInfo()
    {
        Console.WriteLine($"ID    : {idAgen}");
        Console.WriteLine($"Nama  : {namaAgen}");
        Console.WriteLine($"Stok  : {stokAgen}");

    }



}



















class Program
{
    public static void Main()
    {
        agen p = new agen("3", "Ilham", 4376535);
        agen o = new agen("6", "Rizki", 873652);
        o.TampilInfo();
    

        p.TampilInfo();
        Console.WriteLine();
        o.TampilInfo();
        Console.WriteLine();

        ProdukGalon h = new GalonAkua("23", "swes", 42);
        ProdukGalon l = new GalonBerkeran("1", "hdth", 34);
        l.info();
        h.info();

    }
}