bool optionSelected = false;

Console.WriteLine("Select an option: help, add, delete, find, edit, list");
do
{
    string? input = Console.ReadLine();
    if (input != null)
    {
        menuOption(input);
    }
} while (optionSelected == false);


void menuOption(string selectedOption)
{

    string[] options = ["help", "add", "delete", "find", "edit", "list"];

    if (Array.Exists(options, option => option.Equals(selectedOption.ToLower().Trim())))
    {
        switch (selectedOption.ToLower().Trim())
        {
            case "help":
                Console.WriteLine("Available options: help, add, delete, find, edit, list.");
                break;

            case "add":
                Console.WriteLine("Add function selected.");
                optionSelected = true;
                break;

            case "delete":
                Console.WriteLine("Delete function selected.");
                optionSelected = true;
                break;

            case "find":
                Console.WriteLine("Find function selected.");
                optionSelected = true;
                break;

            case "edit":
                Console.WriteLine("Edit function selected.");
                optionSelected = true;
                break;

            case "list":
                Console.WriteLine("List function selected.");
                optionSelected = true;
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Invalid option selected. Type 'help' to see the available options.");
        optionSelected = false;
    }
}



