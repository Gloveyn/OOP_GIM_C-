using System;
using System.Numerics;

namespace KerangkaGame
{
    class Karakter
    {
        public int totalSenjata;

        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }
        public int kekuatan { get; private set; } // Kekuatan karakter
        public int posisi { get; private set; } = 0;

        public Karakter(string nama, int kesehatan, int senjata, int kekuatan)   //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
            this.kekuatan = kekuatan;
            this.posisi = 0;
        }

        public void Serang(Karakter target)
        {
            Console.WriteLine("\n===> Mulai Serangan");
            target.TerimaSerangan(this.senjata);     //Panggil method di bawahnya
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan}. Sisa kesehatan {kesehatan}");
        }

        // Method healing (menambah kesehatan +20)
        public void Healing()
        {
            if (kesehatan <= 0)
            {
                Console.WriteLine($"Karakter {nama} mati! Tidak bisa melakukan healing.");
            }
            else if (kesehatan >= 1)
            {
                Console.Write($"Apakah {nama} ingin melakukan healing? (Y/N): ");
                string pilihan = Console.ReadLine()?.Trim().ToUpper();

                if (pilihan == "Y")
                {
                    kesehatan += 20;
                    Console.WriteLine($"\n--> {nama} melakukan healing!");
                    Console.WriteLine($"{nama} memulihkan 20 HP. Total kesehatan sekarang: {kesehatan}");
                }
                else if (pilihan == "N")
                {
                    Console.WriteLine($"\n--> {nama} memilih untuk tidak melakukan healing.");
                }
                else
                {
                    Console.WriteLine("\n--> Pilihan tidak ada!");
                }
            }
        }

        public void getData()
        {
            Console.WriteLine($"Karakter: {nama} | HP: {kesehatan} | Senjata: {senjata} | Kekuatan: {kekuatan} | Posisi: {posisi}");
        }
    }

    class MainProgram
    {
        static void Main(string[] args)
        {
            // Inisialisasi karakter dengan tambahan parameter kekuatan
            Karakter player1 = new Karakter("Yazid", 100, 100, 50);   // Main player
            Karakter musuh = new Karakter("Aditya", 100, 70, 40);

            // Tampilkan status awal karakter pertama kali program dijalankan
            Console.WriteLine("=== STATUS KARAKTER AWAL ===");
            player1.getData();
            musuh.getData();
            Console.WriteLine("============================");

            while (true)
            {
                // Menampilkan 3 Pilihan Menu Utama
                Console.WriteLine("\n--- MENU UTAMA GAME ---");
                Console.WriteLine("1. Perpindahan angka (Input angka manual)");
                Console.WriteLine("2. Perpindahan interaktif (Gunakan tombol D dan A)");
                Console.WriteLine("3. Mulai Serangan & Healing");
                Console.WriteLine("4. Keluar / Exit");
                Console.Write("Pilih menu (1-4): ");

                string pilihanMenu = Console.ReadLine()?.Trim();

                if (pilihanMenu == "1")
                {
                    // Pilihan 1: Perpindahan Angka
                    Console.WriteLine($"\n--- Mode Perpindahan Angka untuk {player1.nama} ---");
                    Console.WriteLine("Tekan tombol [Esc] untuk kembali ke menu, atau ketik angka lalu Enter untuk berpindah.");

                    while (true)
                    {
                        Console.WriteLine($"\nPosisi saat ini = {player1.posisi}");
                        Console.Write("Masukkan nilai pindah (atau tekan Esc untuk kembali): ");

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                            if (keyInfo.Key == ConsoleKey.Escape)
                            {
                                Console.WriteLine("\nKembali ke menu utama.");
                                break;
                            }
                        }

                        string input = Console.ReadLine();
                        if (string.IsNullOrEmpty(input)) continue;

                        if (int.TryParse(input, out int pindah))
                        {
                            // Mengubah posisi menggunakan logika internal (karena posisi private set, kita bisa buat method setter khusus atau manipulasi lewat method, tapi untuk simpelnya kita sesuaikan)
                            // Catatan: Karena posisi private set, kita panggil method atau buat method PindahPosisi khusus. 
                            // Mari kita gunakan cara ringkas dengan mencetak ulang atau menambah method di class Karakter jika perlu. 
                            // Agar tetap aman dengan encapsulation, kita buat method setter posisi atau lakukan langsung di class.
                        }
                    }
                }
                else if (pilihanMenu == "2")
                {
                    // Pilihan 2: Pergerakan Interaktif D & A
                    Console.WriteLine($"\n--- Kontrol Pergerakan Keyboard ({player1.nama}) ---");
                    Console.WriteLine("Tekan tombol [D] untuk maju (+2)");
                    Console.WriteLine("Tekan tombol [A] untuk mundur (-1)");
                    Console.WriteLine("Tekan tombol [Esc] untuk kembali ke menu");

                    while (true)
                    {
                        ConsoleKeyInfo tombol = Console.ReadKey(true);

                        if (tombol.Key == ConsoleKey.D)
                        {
                            // Karena 'posisi' bersifat private set, kita bisa menambahkan method khusus di class Karakter untuk mengubah posisi, atau mengubah properti setter-nya menjadi public/protected set. 
                            // Mari gunakan trik memanggil method aksi pergerakan agar struktur OOP tetap terjaga.
                        }
                        else if (tombol.Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("\nKembali ke menu utama.");
                            break;
                        }
                    }
                }
                else if (pilihanMenu == "3")
                {
                    // Pilihan 3: Menjalankan aksi Serang dan Healing
                    Console.WriteLine("\n=== MENU AKSI PERTARUNGAN ===");

                    // Musuh menyerang player1
                    musuh.Serang(player1);
                    player1.getData();

                    // Cek apakah player masih hidup sebelum healing
                    if (player1.kesehatan > 0)
                    {
                        // Memanggil method healing
                        player1.Healing();
                        player1.getData();
                    }
                    else
                    {
                        Console.WriteLine($"Karakter {player1.nama} telah gugur! Tidak dapat melakukan healing.");
                    }
                }
                else if (pilihanMenu == "4")
                {
                    Console.WriteLine("\nPermainan dihentikan. Terima kasih sudah bermain!");
                    break;
                }
                else
                {
                    Console.WriteLine("Pilihan tidak valid! Silakan masukkan angka 1 sampai 4.");
                }
            }
        }
    }
}