
while (true)
{
    try
    {
        Run();
    }
    catch (Exception exception)
    {
        Console.WriteLine(exception);

    }
}


static void Run()
{
    int menu = Shop.GetInt("" +
        "1)Add Guitar\n" +
        "2)Show Guitar Inventory\n" +
        "3)Buy Guitar\n" +
        "4)Factor\n" +
       "5)Remove Guitar\n");
    switch (menu)
    {

        case 1:
            {
                int GuitarStyles = Shop.GetInt("which one?\n" +
                    "1)Classic Guitar\n" +
                    "2)Acoustic Guitar\n" +
                    "3)Electric Guitar\n" +
                    "4)Bass Guitar");
                switch (GuitarStyles)
                {
                    case 1:
                        {
                            string brand = Shop.GetString("brand");
                            string model = Shop.GetString("model");
                            double price = Shop.GetDouble("price");
                            int count = Shop.GetInt("count");
                            Shop.AddClassic(brand, model, price, count);

                            break;

                        }
                    case 2:
                        {
                            string brand = Shop.GetString("brand");
                            string model = Shop.GetString("model");
                            double price = Shop.GetDouble("price");
                            int count = Shop.GetInt("count");
                            Shop.AddAcoustic(brand, model, price, count);
                            break;
                        }
                    case 3:
                        {
                            string brand = Shop.GetString("brand");
                            string model = Shop.GetString("model");
                            double price = Shop.GetDouble("price");
                            int count = Shop.GetInt("count");
                            Shop.AddElectric(brand, model, price, count);
                            break;
                        }
                    case 4:
                        {
                            string brand = Shop.GetString("brand");
                            string model = Shop.GetString("model");
                            double price = Shop.GetDouble("price");
                            int count = Shop.GetInt("count");
                            Shop.AddBass(brand, model, price, count);
                            break;
                        }

                }
                break;
            }
        case 2:
            {
                Shop.ShowGuitarList();
                break;
            }
        case 3:
            {
                string brand = Shop.GetString("brand");
                string model = Shop.GetString("model");

                Shop.Buy(brand, model);

                break;

            }
        case 4:
            {
                Shop.ShowTotal();
                break;
            }


        case 5:
            {
                string model = Shop.GetString("model");

                Shop.RemoveGuitar(model);

                break;
            }

    }

}