namespace DeveloperTest;
public static class ExtensionMethods
{
    public static List<string> Swap(this List<string> message, int lineToSwap, int newLine)
    {
        var messageToMove = message[lineToSwap];
        var messageToReplace = message[newLine];
        message[lineToSwap] = messageToReplace;
        message[newLine] = messageToMove;
        return message;
    }
}