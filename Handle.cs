namespace DeveloperTest;

public class Handle
{
    public List<string> HandleInput(Command command, string input, List<string> message, int position = 0)
    {
        switch (command)
        {
            case Command.L:
                DisplayMessage(message);
                return message;
            case Command.A:
                return AddToMessage(message, input);
            case Command.I:
                return InsertInToMessage(message, input);
            case Command.D:
                return DeleteFromMessage(message, input);
            case Command.R:
                return SwapInMessage(message, input);
            case Command.E:
                return EditMessage(message, input);
            default:
                return message;
        }
    }

    private List<string> EditMessage(List<string> message, string input)
    {
        var position = ExtractPositionFromInput(input);
        message[ConvertToLineNumberFromIndex(position)] = input.Remove(0, 1).TrimStart();
        return message;
    }

    private List<string> SwapInMessage(List<string> message, string input)
    {
        var inputAsArray = input.Split();
        int.TryParse(inputAsArray[0], out var initialIndex);
        int.TryParse(inputAsArray[1], out var newIndex);
        message.Swap(ConvertToLineNumberFromIndex(initialIndex), ConvertToLineNumberFromIndex(newIndex));
        return message;
    }

    private List<string> DeleteFromMessage(List<string> message, string input)
    {
        var position = ExtractPositionFromInput(input);
        message.RemoveAt(ConvertToLineNumberFromIndex(position));
        return message;
    }

    private List<string> InsertInToMessage(List<string> message, string input)
    {
        var position = ExtractPositionFromInput(input);
        input = input.Remove(0, 1).TrimStart();
        message.Insert(ConvertToLineNumberFromIndex(position), input);
        return message;
    }

    private List<string> AddToMessage(List<string> message, string input)
    {
        message.Add(input);
        return message;
    }

    private int ConvertToLineNumberFromIndex(int position) => position - 1; // taking into consideration index is at position.

    private int ExtractPositionFromInput(string input)
    {
        int.TryParse(input.Split()[0], out var position);
        return position;
    }


    private void DisplayMessage(List<string> message)
    {
        foreach (var line in message) Console.WriteLine($"\"{line}\"");
    }
}
