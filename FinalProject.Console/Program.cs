Console.WriteLine("1. gün verileri oluşturuldu.");

string[] brands = {"BMW", "Mercedes","Audi"};
string[] models = {"m5","Benz", "A3" };
double[] dailyPrice = {2500,3658,4500};

for (int i = 0; i <brands.Length; i++)
{
    Console.WriteLine($"Marka Adı : {brands[i]}, Model Adı : {models[i]}, Günlük  Fiyatı : {dailyPrice[i]}  TL");
}


Console.WriteLine("Marka ve değerleri girildi.");