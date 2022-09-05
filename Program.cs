using DeveloperTest;
var message = new List<string> { $"Welcome to the timewarp of programs!", "Applications like this were used in in the 1980s.", "I can’t wait for User Interfaces to be invented.", "Then I can do much more complicated things" };

while (true)
{
    var input = Console.ReadLine();
    var commandAsString = input.Split()[0].ToString().ToUpper();

    // Extract command
    Enum.TryParse<Command>(commandAsString, out var command);

    if (command == Command.R)
    {
        // We are removing the command and trailing space
        input = input.Remove(0, 1).TrimStart();
    }
    else
    {
        // We are removing the command and trailing space
        input = input.Remove(0, 1).TrimStart();
    }

    if (command == Command.Q) break;

    new Handle().HandleInput(command, input, message);
}
