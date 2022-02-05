using OpenAI;

var ai = new OpenAIClient(Engine.Davinci);

while (true)
{
    Console.Write("Input: ");
    var input = Console.ReadLine();

    if (input == null) { break; }

    var result = await ai.CompletionEndpoint.CreateCompletionAsync(input, max_tokens: 64);

    var textResult = result.Completions.First().Text;

    Console.WriteLine($"The result is {textResult}");
}
