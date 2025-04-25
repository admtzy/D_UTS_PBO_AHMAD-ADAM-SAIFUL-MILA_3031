//namaa: ahmad adam saiful mila
//nimm: 242410103031
using System;
class program
{
    static void Main()
    {
        Perpustakaan perpustakaan = new Perpustakaan();
        perpustakaan.Nama = "perpustakaan well well";
        perpustakaan.Alamat = "Jl. jawir no 2";

        while (true)
        {
            Console.WriteLine("\nselamat datang di perpustakaan");
            Console.WriteLine("1 Tambah Buku");
            Console.WriteLine("2 Cari Buku");
            Console.WriteLine("3 Ubah Buku");
            Console.WriteLine("4 Hapus Buku");
            return;
        }
    }
}

public class Buku
{
    public int ID { get; set; }
    public string Judul { get; set; }
    public string Penulis { get; set; }
    public int TahunTerbit { get; set; }
    public string Status { get; set; }

}



public class Perpustakaan
{
    public string Nama { get; set; }
    public string Alamat { get; set; }
}
public class tambah : Buku
{
    public void menambah(string judul, string penulis, int tahun_terbit)
    {
      Buku tambahbuku= new Buku();
      tambahbuku.Judul = judul;
      tambahbuku.Penulis = penulis;
      tambahbuku.TahunTerbit = tahun_terbit;
      tambahbuku.Status = "Tersedia";
  
    }

}



