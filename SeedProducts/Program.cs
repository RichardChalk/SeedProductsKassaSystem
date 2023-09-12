namespace SeedProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nu kallar vi på metoden som seeda några produkter
            WriteDefaultProducts();
        }

        static void WriteDefaultProducts()
        {
            // Denna if sats är viktig!!!
            // Vad händer om jag ta bort den tror ni?
            if (File.Exists("../../../MyProducts.txt")) return;
         
            string text = "11 Jordgubbar 39,90 Styckpris\n" +
                          "22 Nutella 19,90 Styckpris\n" +
                          "33 Citron 4,90 Styckpris\n" +
                          "44 Bananer 9,90 Kilopris\n" +
                          "55 Grädde 15,90 Styckpris\n" +
                          "66 Choklad 9,90 Styckpris\n" +
                          "77 Apelsiner 29,90 Kilopris\n";
            File.WriteAllText("../../../MyProducts.txt", text);

            // Prova!
            // Vad händer om jag ändrar till dena kod?
            // Denna saknas - ../../../
            
            // if (File.Exists("MyProducts.txt")) return;
            // File.WriteAllText("MyProducts.txt", text);
        }
    }
}