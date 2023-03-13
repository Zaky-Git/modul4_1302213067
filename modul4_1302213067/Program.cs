// See https://aka.ms/new-console-template for more information

class KodeBuah
{
    string[] namaBuah = { "Apel", "Aprikot","Alpukat","Pisang",
        "Paprika","Blackberry","Ceri","Kelapa","Jagung","Kurma","Durian","Anggur","Melon","Semangka"};

    string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };

    public string getKodeBuah_1302213067(string x)
    {
        for(int i = 0; i < namaBuah.Length; i++)
        {
            if (x == namaBuah[i])
            {
                return kodeBuah[i];
            }

        }
        return "tidak ada";
    }
}

class PosisiKarakterGame { 

        enum posisiState{
        Jongkok,
        Berdiri,
        Terbang,
        Tengkurap}
        public void startState()
    {
        posisiState state = posisiState.Berdiri;
        string[] stringPosisi = { "Jongkok", "Berdiri", "Terbang","Tengkurap" };
        while (true)
        {
            Console.WriteLine("State sekarang : " + stringPosisi[(int)state]);
            Console.Write("Masukkan Tombol : ");
            string tombol = Console.ReadLine();
            switch (state)
            {
                case posisiState.Berdiri:
                    if (tombol == "W")
                    {
                        state = posisiState.Terbang;
                    } else if (tombol == "S")
                    {
                        state = posisiState.Jongkok;
                    } else
                    {
                        state = posisiState.Berdiri;
                    }
                    break;
                case posisiState.Terbang:
                    if (tombol == "S")
                    {
                        Console.WriteLine("posisi standby");
                        state = posisiState.Berdiri;
                    } else if (tombol == "X")
                    {
                        state = posisiState.Jongkok;
                    } else
                    {
                        state = posisiState.Terbang;
                    }
                    break;
                case posisiState.Jongkok:
                    if (tombol == "S")
                    {
                        Console.WriteLine("posisi istirahat");
                        state = posisiState.Tengkurap;
                    } else if (tombol == "W")
                    {
                        Console.WriteLine("posisi standby");
                        state = posisiState.Berdiri;
                    } else
                    {
                        state = posisiState.Jongkok;
                    }
                    break;
                case posisiState.Tengkurap:
                {
                    if (tombol == "W")
                    {
                        state = posisiState.Jongkok;
                    } else
                    {
                        Console.WriteLine("posisi istirahat");
                        state = posisiState.Tengkurap;
                    }
                    break;
                }

            }

        }
    }



}

class main
{
    static void Main(string[] args)
    {

 
        KodeBuah kode = new KodeBuah();


        while (true)
        {

            Console.Write("Masukkan Nama Buah : ");
            string input = Console.ReadLine();

            Console.WriteLine("Kode Buah : " + kode.getKodeBuah_1302213067(input));
            Console.WriteLine("");

            if (input == "0")
            {
                break;
            }

            PosisiKarakterGame start = new PosisiKarakterGame();

            start.startState();
        }


    }
}