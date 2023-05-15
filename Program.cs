using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Number city : ");
        int Numbercity =int.Parse(Console.ReadLine());

        string[] Namecity = new string[Numbercity];
        int[] Contactscity = new int[Numbercity];
        int[] Levelcity = new int[Numbercity];

        for (int i = 0; i < Numbercity; i++){
            Console.WriteLine("Numbercity" + i);
            Console.WriteLine("Numbercity");
            Namecity[i] = Console.ReadLine();
            Console.WriteLine("Numbercity : ");
            while (Contactscity[i] >= i || Contactscity[i] <0 || Contactscity[i] == Contactscity[Contactscity[i]])
            {
                Console.WriteLine("Invlid ID");
                Console.WriteLine("Numbercity : ");
                Contactscity[i] = int.Parse(Console.ReadLine());

            }
        }
        Console.WriteLine("Namecity : ");
        for (int i = 0; i < Numbercity; i++)
        {
            Console.WriteLine ("Numbercity: "+ i +" , Namecity: " + Namecity[i] + " Levelcity: " + Levelcity);

        }
        while (true){
            Console.WriteLine("COVID-19 (Outbreak, Vaccinate, Lock down, Spread, Exit): ");
            string eventinput = Console.ReadLine();

            if (eventinput == "Outbreak" || eventinput == "Vaccinate" || eventinput == "Lock down")
            {
                Console.WriteLine("Numbercity: ");
                int eventcity = int.Parse(Console.ReadLine());
                if (eventinput == "Outbrak"){
                    Levelcity[eventcity] +=2;
                    if (Levelcity[eventcity] > 3)
                    Levelcity[eventcity] = 3;
                    Levelcity[Contactscity[eventcity]] += 1;
                    if (Levelcity[Contactscity[eventcity]] >3)
                    Levelcity[Contactscity[eventcity]] =3;
                }
                else if (eventinput == "Vaccinate");
            }
        }
    }
}
