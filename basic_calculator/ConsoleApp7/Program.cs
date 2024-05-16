
   double a, b,sonuc=0;
    char islem;

    a = Convert.ToInt64(Console.ReadLine());
    b = Convert.ToInt64 (Console.ReadLine());
    islem = Convert.ToChar(Console.ReadLine());

    switch(islem)
    { 
        case '+':
            sonuc = a + b;
            break;
        case '-':
            sonuc = a - b;
            break;
        case '*':
            sonuc = a * b;
            break;
        case '/':
            sonuc = a / b;
            break;
        default:
            Console.WriteLine("HATA");
            return;
    }
    Console.WriteLine(sonuc);
