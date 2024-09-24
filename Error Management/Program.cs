try
{
    Console.WriteLine("Bir sayı giriniz.");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Girmiş olduğunuz sayi: " + number);

}
catch (Exception ex)
{
    Console.WriteLine("Hata: " + ex.Message.ToString());
    throw;
}
finally
{
    Console.WriteLine("İşlem tamamlandı.");
}



try
{
    int a = int.Parse(null);
}
catch (ArgumentNullException ex)
{
    Console.WriteLine("Boş değer girdiniz");
    Console.WriteLine(ex);
}