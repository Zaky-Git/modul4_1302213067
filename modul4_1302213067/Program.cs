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

class main
{
    static void Main(string[] args)
    {

 
        KodeBuah kode = new KodeBuah();


        while (true)
        {

            Console.WriteLine("Masukkan Nama Buah : ");
            string input = Console.ReadLine();

            Console.WriteLine("Kode Buah : " + kode.getKodeBuah_1302213067(input));
            Console.WriteLine("");

            if (input == "0")
            {
                break;
            }
        }


    }
}