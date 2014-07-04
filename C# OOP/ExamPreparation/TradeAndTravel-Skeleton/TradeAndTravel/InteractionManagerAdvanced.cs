using System;
using System.Linq;


namespace TradeAndTravel
{
    class InteractionManagerAdvanced : InteractionManager
    {
        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    return base.CreateLocation(locationTypeString, locationName);
            }
            return location;           
        }

        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    return base.CreateItem(itemTypeString, itemNameString, itemLocation, item);
            }

            return item;           
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft" :
                    HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;               
                default:
                    base.HandlePersonCommand(commandWords, actor);
                    break;
            }
        }

        private void HandleCraftInteraction(Person actor, string itemType, string itemName)
        {
            switch (itemType)
            {
                case "weapon" :
                    CraftWeapon(actor, itemName);
                    break;
                case "armor":
                    CraftArmor(actor, itemName);
                    break;
                default:
                    break;
            }
        }

        private void CraftWeapon(Person actor, string itemName)
        {
            bool hasIron = false;
            bool hasWood = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Iron)
                {
                    hasIron = true;
                }

                if (item.ItemType == ItemType.Wood)
                {
                    hasWood = true;
                }
            }

            if (hasIron && hasWood)
            {
                Weapon weapon = new Weapon(itemName);
                this.AddToPerson(actor, weapon);
            }
        }

        private void CraftArmor(Person actor, string itemName)
        {
            bool hasIron = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Iron)
                {
                    hasIron = true;
                }
            }

            if (hasIron)
            {
                Armor armor = new Armor(itemName);
                this.AddToPerson(actor, armor);
            }          
        }

        
        private void HandleGatherInteraction(Person actor, string itemName)
        {
            switch (actor.Location.LocationType)
            {
                case LocationType.Forest :
                    GetItemFromForest(actor, itemName);
                    break;
                case LocationType.Mine:
                    GetItemFromMine(actor, itemName);
                    break;
                default:
                    break;
            }
        }

        private void GetItemFromForest(Person actor, string itemName)
        {
            bool hasWeapon = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Weapon)
                {
                    hasWeapon = true;
                }
            }

            if (hasWeapon)
            {
                Wood wood = new Wood(itemName);
                this.AddToPerson(actor, wood);
            }
        }

        private void GetItemFromMine(Person actor, string itemName)
        {
            bool hasArmor = false;
            foreach (var item in actor.ListInventory())
            {
                if (item.ItemType == ItemType.Armor)
                {
                    hasArmor = true;
                }
            }

            if (hasArmor)
            {
                Iron iron = new Iron(itemName);
                this.AddToPerson(actor, iron);
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                default:
                    return base.CreatePerson(personTypeString, personNameString, personLocation);
            }
            return person;
        }
    }
}
