Skills fury = new("Atack", "Fury", "Rare", 6, 3, 0);
Skills stoneShield = new("Defense", "Stone Shield", "Epic", 0, 8, 3);

Spells fireBall = new("Atack", "Fire Ball", "Rare", 8, 0, 0);
Spells arcaneArmor = new("Defense", "Arcane Armor", "Commom", 0, 6, 0);
Spells Healing = new("Suport", "Healing", "Commom", 0, 0, 7);

Items ironSword = new("Atack", "Iron Sword", 82, 5, 0, 0);
Items ironShield = new("Defense", "Iron Shield", 78, 0, 5, 0);
Items ironArmor = new("Defense", "Iron Armor", 100, 0, 7, 0);
Items healingPotion = new("Suport", "Healing Potion", 115, 0, 0, 6);

Character john = new("John", "Human", "Paladin", 1);
Character milla = new("Milla", "Elf", "Mage", 2);
Character rick = new("Rick", "Dwarf", "Warrior", 3);

EliteTeam snowWolves = new("Snow Wolves", "Nordic", 1, "Damage");
    
john.AddItem(ironSword); 
john.AddItem(ironShield); 
john.AddItem(ironArmor);

milla.AddSpell(fireBall);
milla.AddSpell(arcaneArmor);
milla.AddSpell(Healing);

rick.AddSkill(fury);

snowWolves.AddChar(john);
snowWolves.AddChar(milla);
snowWolves.AddChar(rick);

snowWolves.DescribeTeam();

john.DescribeCharSheet();
milla.DescribeCharSheet();
rick.DescribeCharSheet();