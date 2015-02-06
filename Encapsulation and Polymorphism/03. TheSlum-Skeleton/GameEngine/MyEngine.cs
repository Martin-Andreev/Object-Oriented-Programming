namespace TheSlum.GameEngine
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;
    using TheSlum.Characters;
    using TheSlum.Items;

    class MyEngine : Engine
    {
        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    this.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            Team team;
            Character character;

            switch (inputParams[5].ToLower())
            {
                case "red":
                    team = Team.Red;
                    break;
                case "blue":
                    team = Team.Blue;
                    break;
                default:
                    throw new Exception("Wrong team color!");
            }

            switch (inputParams[1].ToLower())
            {
                case "warrior":
                    character = new Warrior(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                        200, 100, team, 2, 150);
                    this.characterList.Add(character);
                    break;

                case "mage":
                    character = new Mage(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                        150, 50, team, 5, 300);
                    this.characterList.Add(character);
                    break;

                case "healer":
                    character = new Healer(inputParams[2], int.Parse(inputParams[3]), int.Parse(inputParams[4]),
                        75, 50, team, 6, 60);
                    this.characterList.Add(character);
                    break;
                default:
                    break;
            }
        }

        protected new void AddItem(string[] inputParams)
        {
            Item item;

            switch (inputParams[2].ToLower())
            {
                case "axe":
                    item = new Axe(inputParams[3]);
                    break;
                case "shield":
                    item = new Shield(inputParams[3]);
                    break;
                case "injection":
                    item = new Injection(inputParams[3]);
                    break;
                case "pill":
                    item = new Pill(inputParams[3]);
                    break;
                default:
                    throw new Exception("Invalid item name");
            }

            var charachter = this.characterList.First(c => c.Id == inputParams[1]);
            charachter.AddToInventory(item);
        }
    }
}
