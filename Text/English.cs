namespace OOPAdventure;

public class English : Language
{
    public English()
    {
        ChooseYourName = "Hello, what is your name?";
        DefaultName = "No Name";
        Welcome = "Welcome {0} to your OOP adventure!";
        DefaultRoomName = "Room {0} ({1}, {2})";
        DefaultRoomDescription = " You are in a {0} room with doors to the {1}.";
        ActionError = "You can't do that.";
        Go = "Go";
        GoError = "You can't go that way.";
        WhatToDo = "What do you want to do?";
        Quit = "quit";
        RoomNew = "You entered {0}.";
        RoomOld = "You returned to {0}.";
        And = "and";
        Comma = ",";
        Space = " ";
        NoItem = "You don't have {0}.";
        RoomDescriptions = new List<string>
        {
            "normal",
            "cold",
            "warm",
            "dark",
            "bright",
            "scary",
            "strange",
            "funny"
        };
        Backpack = "Backpack";
        BackpackError = "Your backpack is empty.";
        BackpackDescription = "Your backpack contains: {0}.";
        Chest = "chest";
        UnlockChest = "You unlocked the chest.";
        Key = "key";
        ChestEmpty = "The chest is empty.";
        ChestFound = "You found: {0}";
        Gold = "{0} gold {1}";
        Coin = "coin";
        Coins = Coin + "s";
    }
}