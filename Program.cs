System.Console.WriteLine("Siz va Kescha yoshlari farqi:\n");

System.Console.Write("Kescha ni yoshini kiriting: ");
int keschaAge = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Sizni yoshingiz: ");
int personAge = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"O'rtadagi faqar: {Math.Abs(keschaAge - personAge)} yosh :)");

