using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

             Console.WriteLine("Data produk");
                    Console.WriteLine();
                    tampilKaryawan();
        }

        static void TambahProduk()
        {
            Console.Clear();

            Console.WriteLine("Tambah Data Karyawan");
                    Console.WriteLine();
                    Console.Write("produk : ");
                    int jk = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                
                    {
                        Console.Write("Kode produk");
                        string nik = Console.ReadLine();
                        Console.Write("Nama produk");
                        string nama = Console.ReadLine();
                        Console.Write("Harga beli = ");
                        string nama = Console.ReadLine();
                        Console.Write("Harga jual = ");
                        int gb = int.Parse(Console.ReadLine());
                        string jenis = "produk";

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            console.writeline();
                console.write("pilih data yang ingin dihapus[1-");
                console.write(jumlah_array);
                console.write("] : ");
                int index_nik = int.parse(console.readline());
                index_nik = index_nik - 1
                listKaryawan.RemoveAt(index_nik);
                Console.WriteLine();
                Console.WriteLine("Data produk berhasil di hapus ");
                Console.WriteLine();
                Console.WriteLine("\nTekan Enter Untuk Kembali ke Menu");

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();

            int no urut = 0;
            console.writeline("dataproduk");
            foreach (produk produk in daftar produk)
            {
                noUrut++;
                console.writeline("{0}.kode produk:{1},Nama produk:{2},Harga beli:{3},Harga jual:{4}",nourut,produk.kodeproduk,produk.kodeproduk,produk.hargabeli,produk.hargajual);       
            }
            if(noUrut < 1)
            {
                console.writeline("Data produk kosong");
            }
            console.writeline("\nTekan enter untuk kembali ke menu aplikasi" );
            console.readkey();
        }
    }
}
