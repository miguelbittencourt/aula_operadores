float media;

Console.WriteLine("Entre com a media: ");
media = float.Parse(Console.ReadLine());

Console.WriteLine("-Checagem else if");
if (media >= 7)
    Console.WriteLine("Aluno aprovado!");
else if (media < 7 && media >= 5)
    Console.WriteLine("Aluno em recuperação!");
else Console.WriteLine("Aluno reprovado!");

Console.WriteLine("-Checagem ternário");
Console.WriteLine(media >= 7 ? "Aprovado" : "Reprovado");