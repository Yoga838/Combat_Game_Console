namespace game_perang_ala_ala
{
    internal class Program
    {
        // tempat program berjalan
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Welcome In War Game ===========");
            Console.WriteLine("============= Made by Y(ogah) =============");
            Console.WriteLine("");
            Console.WriteLine("pilih ROlE Anda");
            Console.WriteLine("Ketik 1 untuk menjadi pembasmi kejahatan ketik 2 untuk menjadi penjahat");
            string userchoice = Console.ReadLine();
            if (userchoice == "1")
            {
                Console.WriteLine("silahkan pilih karakter anda ");
                Console.WriteLine("1. sniper boy (Hp : 100 Att : 60)");
                Console.WriteLine("2. bredet boy (hp : 100 att : 40)");
                string PickHero = Console.ReadLine();
                if (PickHero == "1")
                {
                    GamePlay.SniperBoy start = new GamePlay.SniperBoy();
                    start.sniperan();
                }
                else if (PickHero == "2")
                {
                    GamePlay.BredetMan start = new GamePlay.BredetMan();
                    start.Bredetan();
                }
            }
            else if (userchoice == "2")
            {
                Console.WriteLine("mohon maaf gan mode ini cuma ada God Demon");
                GamePlay.GodDemon start = new GamePlay.GodDemon();
                start.DemonWars();
            }
        }
    }
    // setting gameplay setiap karakter
    public class GamePlay
    {
        //setting gameplay untuk karakter sniper untuk data tentang sniper kita memanggil dari class player namun saya menggunakan pewarisan 
        // sehingga dapat mempermudah dalam pemanggilan data datanya. begitu juga dengan karakter lainnya
        public class SniperBoy : player.sniper
        {
            enemy musuh = new enemy();
            public void sniperan()
            {
                while (true)
                {
                    if (musuh.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("==================================");
                        Console.WriteLine("selamat anda memangkan pertarungan");
                        Console.WriteLine("==================================");
                        Console.ReadLine();
                        break;
                    }
                    else if (this.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("============================");
                        Console.WriteLine("halah cupu sama bot ae kalah");
                        Console.WriteLine("============================");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("=====================================================================================");
                        Console.WriteLine(" ");
                        Console.WriteLine("player menyerang");
                        Console.WriteLine(" ");
                        Console.WriteLine("ketik 'a' untuk normal Att ketik 's' untuk menggunakan abilities ketik 'H' untuk Heal");
                        Console.WriteLine(" ");
                        string choice = Console.ReadLine();


                        if (choice == "a")
                        {
                            musuh.Hp -= this.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            this.Hp -= musuh.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "s")
                        {
                            Console.WriteLine(" ");
                            this.Use_Abilities();
                            Console.WriteLine("player has use the abilities");
                            musuh.Hp -= this.Att;
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            Console.WriteLine(" ");
                            this.Hp -= musuh.Att;
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "h")
                        {
                            Console.WriteLine(" ");
                            this.Hp += 20;
                            Console.WriteLine("player telah melakukan healing dan mendapatkan pemulihan hp sebesar 20");
                        }
                        else if (musuh.Hp == 200)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Musuh melakukan Awakening dan meningkatkan serangan");
                            musuh.Hp += 500;
                            musuh.Att += 50;
                        }
                    }
                }
            }
        }
        public class BredetMan : player.bredet
        {
            enemy musuh = new enemy();
            public void Bredetan()
            {
                while (true)
                {
                    if (musuh.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("==================================");
                        Console.WriteLine("selamat anda memangkan pertarungan");
                        Console.WriteLine("==================================");
                        Console.ReadLine();
                        break;
                    }
                    else if (this.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("============================");
                        Console.WriteLine("halah cupu sama bot ae kalah");
                        Console.WriteLine("============================");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("=====================================================================================");
                        Console.WriteLine(" ");
                        Console.WriteLine("player menyerang");
                        Console.WriteLine(" ");
                        Console.WriteLine("ketik 'a' untuk normal Att ketik 's' untuk menggunakan abilities ketik 'H' untuk Heal");
                        Console.WriteLine(" ");
                        string choice = Console.ReadLine();


                        if (choice == "a")
                        {
                            musuh.Hp -= this.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            this.Hp -= musuh.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "s")
                        {
                            Console.WriteLine(" ");
                            this.Use_Abilities();
                            Console.WriteLine("player has use the abilities");
                            musuh.Hp -= this.Att;
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            Console.WriteLine(" ");
                            this.Hp -= musuh.Att;
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "h")
                        {
                            Console.WriteLine(" ");
                            this.Hp += 20;
                            Console.WriteLine("player telah melakukan healing dan mendapatkan pemulihan hp sebesar 20");
                        }
                        else if (musuh.Hp == 200)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Musuh melakukan Awakening dan meningkatkan serangan");
                            musuh.Hp += 500;
                            musuh.Att += 50;
                        }
                    }
                }
            }
        }
        public class GodDemon : player.God_Demon
        {
            enemy2 musuh = new enemy2();
            public void DemonWars()
            {
                while (true)
                {
                    if (musuh.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("==================================");
                        Console.WriteLine("selamat anda memangkan pertarungan");
                        Console.WriteLine("==================================");
                        Console.ReadLine();
                        break;
                    }
                    else if (this.Hp <= 0)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("============================");
                        Console.WriteLine("halah cupu sama bot ae kalah");
                        Console.WriteLine("============================");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("=====================================================================================");
                        Console.WriteLine(" ");
                        Console.WriteLine("player menyerang");
                        Console.WriteLine(" ");
                        Console.WriteLine("ketik 'a' untuk normal Att ketik 's' untuk menggunakan abilities ketik 'H' untuk Heal");
                        Console.WriteLine(" ");
                        string choice = Console.ReadLine();


                        if (choice == "a")
                        {
                            musuh.Hp -= this.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            this.Hp -= musuh.Att;
                            Console.WriteLine(" ");
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "s")
                        {
                            Console.WriteLine(" ");
                            this.Use_Abilities();
                            Console.WriteLine("Membangkitkan Susano'o");
                            musuh.Hp -= this.Att;
                            Console.WriteLine("anda memberikan damage sebesar " + this.Att + " sehingga nyawa musuh " + musuh.Hp);
                            Console.WriteLine(" ");
                            Console.WriteLine("giliran musuh membalas");
                            Console.WriteLine(" ");
                            this.Hp -= musuh.Att;
                            Console.WriteLine("musuh memberikan damage sebesar " + musuh.Att + " sehingga nyawa anda " + this.Hp);
                        }
                        else if (choice == "h")
                        {
                            Console.WriteLine(" ");
                            this.Hp += 20;
                            Console.WriteLine("player telah melakukan healing dan mendapatkan pemulihan hp sebesar 20");
                        }
                        else if (musuh.Hp == 200)
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Musuh melakukan Awakening dan meningkatkan serangan");
                            musuh.Hp += 700;
                            musuh.Att += 40;
                        }
                    }
                }
            }
        }
    }


    // class player digunakan untuk menyimpan data data tentang player dan abilities yang dimilikinya 
    public class player
    {
        public class sniper
        {
            protected int Hp = 100;
            protected int Att = 60;
            protected string Abilites = "Silent Kill (senjata bermata dua)";
            public void Use_Abilities()
            {
                this.Att = 100;
            }
        }
        public class bredet
        {
            protected int Hp = 100;
            protected int Att = 40;
            string Abilites = "burst attack + heal";
            public void Use_Abilities()
            {
                this.Att += 30;
                this.Hp += 20;
            }
        }
        public class God_Demon
        {
            protected int Hp = 200;
            protected int Att = 50;
            string Abilites = "susano'o(melancarkan serangan brutal)";
            public void Use_Abilities()
            {
                this.Att += 100;
            }
        }
    }
    //untuk class enemy sendiri digunakan sebagai cetak biru dari musuh yang akan dilawan 
    public class enemy
    {
        public int Hp = 500;
        public int Att = 30;
    }
    public class enemy2
    {
        public int Hp = 400;
        public int Att = 50;
    }
}
