using System;
using System.Numerics;
namespace KerangkaGame
{
    class Karakter  //Tidak membuat method baru
    {
        public int totalSenjata, kekuatan;

        public string nama {  get; private set; }
        public int kesehata { get; private set; }
        public string senjata {  get; private set; }
        
        public Karakter(string nama, string kesehatan, string senjata)   //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }
        //public void setData(string namaBaru, string kesehatanBaru, string senjataBaru, int totalSenjataBaru, int kekuatanBaru)
        //{
        //    this.nama = namaBaru;
        //    this.kesehatan = kesehatanBaru;
        //    this.senjata = senjataBaru;
        //    this.totalSenjata = totalSenjataBaru;
        //    this.kekuatan = kekuatanBaru;
        //}

        //public void getData()
        //{
        //    Console.WriteLine(nama);
        //    Console.WriteLine(kesehatan);
        //    Console.WriteLine(senjata);
        //    Console.WriteLine(totalSenjata);
        //    Console.WriteLine(kekuatan);
        //    Console.WriteLine("/");
        //}

        //public void setNama(string namaBaru)  // Membuat method baru
        //{
        //    this.nama = namaBaru;
        //}

        //public void setKesehatan(string kesehatanBaru)
        //{
        //    this.kesehatan = kesehatanBaru;
        //}

        //public void getNama()
        //{
        //    Console.WriteLine(nama);
        //}

        //public void getKesehatan()
        //{
        //    Console.WriteLine(kesehatan);
        //}

        public void getData()
        {
            Console.WriteLine($"Karakter {nama}"); 
        }

        
    }


    class MainProgram
    {
        static void Main(string[] args)
        {

            Karakter player1 = new Karakter("Yazid", "Sehat", "Blade");
            player1.getData();

            
            


            // Code yang belum di refactor
            //    List<Karakter> heroList = new List<Karakter>(); //Array menyimpan HERO
            //    Karakter player1= new Karakter();
            //    player1.setData("Monkey D Luffy", "Medium", "Tangan", 1, 10);
            //    //player1.getData();

            //    Karakter player2 =new Karakter();
            //    player2.setData("Pak Ustadz", "Sehat", "Kapak", 1, 30);
            //    //player2.getData();


            //    // Objek Enemy

            //    Karakter enemy = new Karakter();
            //    enemy.setData("Dooms", "Sehat", "Time Control", 5, 40);
            //    enemy.getData();

            //    heroList.Add(player1);
            //    heroList.Add(player2);

            //    //Menampilkan data Array, menggunakan foreach
            //    foreach(Karakter player in heroList)
            //    {
            //        player.getData();
            //    }

            //player.setNama("Monkey D Luffy");
            //player.getNama();

            //player.setKesehatan("Medium");
            //player.getKesehatan();

            //player.setNama("Pak Ustadz");
            //player.getNama();

            //player.setKesehatan("Sehat Walafiat");
            //player.getKesehatan();



        }



        //static void Main(string[] args) // Tanpa method
        //{
        //    Karakter karakter1 = new Karakter();
        //    //Karakter karakter2 = new Karakter(); //buat objek baru
        //    karakter1.nama = "Giant";

        //    Console.WriteLine(karakter1.nama);

        //    karakter1.nama = "Goblin";

        //    Console.WriteLine(karakter1.nama);  // Di timpa

        //}



    }

}