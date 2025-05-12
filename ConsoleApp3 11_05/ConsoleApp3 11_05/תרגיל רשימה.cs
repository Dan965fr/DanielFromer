//using System;
//using System.Collections.Generic;

//Random random = new Random();

//int numberOfHouses = random.Next(10, 21);
//List<int> houses = new List<int>();

//for (int i = 1; i <= numberOfHouses; i++)
//{
//    houses.Add(i);
//}

//Console.WriteLine($"creat {numberOfHouses} houses.");

//Console.Write("  how many houses to destroy? ");
//int toDestroy = int.Parse(Console.ReadLine());

//string[] weapons = { "Rocket", "Drone", "Tank" };

//int? firstDestroyedHouse = null;
//string firstWeaponUsed = null;

//for (int i = 0; i < toDestroy && houses.Count > 0; i++)
//{
//    int houseIndex = random.Next(houses.Count);
//    int houseNumber = houses[houseIndex];
//    string weapon = weapons[random.Next(weapons.Length)];

//    // שמירת מידע על הבית הראשון שהושמד
//    if (firstDestroyedHouse == null)
//    {
//        firstDestroyedHouse = houseNumber;
//        firstWeaponUsed = weapon;
//    }

//    Console.WriteLine($"{weapon} used to destroy house {houseNumber}");

//    houses.RemoveAt(houseIndex);
//}

//if (firstDestroyedHouse != null)
//{
//    Console.WriteLine($"\nThe first house was destroy: {firstDestroyedHouse} with weapon: {firstWeaponUsed}");
//}

//Console.WriteLine("\nThe remaining houses:");
//foreach (var h in houses)
//{
//    Console.Write(h + " ");
//}
//Console.WriteLine();

//1
//List<string> names5 = new List<string> {"yossi","daniel","moshe","shaul","tzvi"};
//names5.Add("kobi");
//names5.Add("yeuda");
//names5.Remove("daniel");
//for (int i = 0;i < names5.Count; i++)
//{
//    Console.WriteLine($"{i}:{names5[i]}");
//}

//2
//Dictionary<string,int> items = new Dictionary<string,int>();
//items["orange"] = 25;
//items["apple"] = 52;
//items["banana"] = 41;
//items["orange"] = 20;

//foreach(var item in items)
//{
// Console.WriteLine($"{item.Key}:{item.Value}"); 
//}

//3
var users = new List<Dictionary<string, string>>();
var user1 = new Dictionary<string, string>();
user1["name"] = "Daniel";
user1["email"] = "daniel.1@gmail.com";
user1["status"] = "active";

var user2 = new Dictionary<string, string>();
user1["name"] = "yossi";
user1["email"] = "yossi.1@gmail.com";
user1["status"] = "in active";

users.Add(user1);
users.Add(user2);
Console.WriteLine("users emails:");
foreach (var user in users)
{
    Console.WriteLine(user["email"]);
}
;
