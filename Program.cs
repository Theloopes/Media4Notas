Console.WriteLine("-- Média --");
Console.WriteLine("");
Console.WriteLine("Digite sua primeira nota");
double notaum = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua segunda nota");
double notadois = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua terceira nota");
double notatres = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite sua quarta nota");
double notaquatro = Convert.ToDouble(Console.ReadLine()!);

double media;

if(notaum<0 | notaum>10 | notadois<0 | notadois>10 | notatres<0 | notatres>10 | notaquatro<0 | notaquatro>10){
    Console.WriteLine("Digite somente notas de 0 a 10");
}
else 
{
    media = (notaum + notadois + notatres + notaquatro) / 4;
 if (media < 5){
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Reprovado");
 }
 else if( media > 6){
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Aprovado");
 }
 else{
    Console.WriteLine($"Sua media é = {media:N1}    Resultado: Em Recuperação");
 }
}