using NTier.BLL.Service.CharakterAction;
using NTier.BLL.Service.CharakterCreate;
using NTier.BLL.Service.Instance;
using NTier.DAL.Context;
using NTier.DAL.Datas;
using NTier.DAL.Entities;

namespace MMORPG
{
    class Program
    {

        public static void Main(string[] args)
        {

            InstanceBaseClass _instanceBaseClass = new InstanceBaseClass();


            Console.WriteLine("WELCOME");
            Console.Write("Enter Character Name:");
            string inComingCharacterName = Console.ReadLine();
            Console.WriteLine("-----------------------------");

            foreach (var race in RaceData.GetRaces())
            {
                Console.WriteLine($"{race.ID} || {race.Name}");
            }
            Console.WriteLine("Choose your Race:");
            string inComingRace = Console.ReadLine();
            switch (inComingRace)
            {
                case "1":
                    Console.WriteLine("Your Race is HUMAN...");
                    break;
                case "2":
                    Console.WriteLine("Your Race is NightELF...");
                    break;
                case "3":
                    Console.WriteLine("Your Race is DWARF...");
                    break;
                case "4":
                    Console.WriteLine("Your Race is ORC...");
                    break;
                case "5":
                    Console.WriteLine("Your Race is UNDEAD...");
                    break;

            }
            Console.WriteLine("-----------------------------");

            foreach (var job in JobData.GetJobs())
            {
                Console.WriteLine($"{job.ID} || {job.Name}");
            }
            Console.WriteLine("Choose Your Job:");
            string inComingJob = Console.ReadLine();
            switch (inComingJob)
            {
                case "1":
                    Console.WriteLine("Your Job is WARRIOR...");
                    break;
                case "2":
                    Console.WriteLine("Your Job is PALADIN...");
                    break;
                case "3":
                    Console.WriteLine("Your Job is ROGUE...");
                    break;
                case "4":
                    Console.WriteLine("Your Job is MAGE...");
                    break;

            }
            Console.WriteLine("-----------------------------");

            foreach (var cloth in ClothData.GetCloths())
            {
                Console.WriteLine($"{cloth.ID} || {cloth.Name}");
            }
            Console.WriteLine("Choose Your Cloth:");
            string inComingCloth = Console.ReadLine();
            switch (inComingCloth)
            {
                case "1":
                    Console.WriteLine("Your Cloth is STEEL CLOTH...");
                    break;
                case "2":
                    Console.WriteLine("Your Cloth is IRON CLOTH...");
                    break;
                case "3":
                    Console.WriteLine("Your Cloth is GOLD CLOTH...");
                    break;
                case "4":
                    Console.WriteLine("Your Cloth is FABRIC CLOTH...");
                    break;
                case "5":
                    Console.WriteLine("Your Cloth is SILK CLOTH...");
                    break;

            }
            Console.WriteLine("-----------------------------");

            foreach (var weapon in WeaponData.GetWeapons())
            {
                Console.WriteLine($"{weapon.ID} || {weapon.Name}");
            }
            Console.WriteLine("Choose Your Weapon:");
            string inComingWeapon = Console.ReadLine();
            switch (inComingWeapon)
            {
                case "1":
                    Console.WriteLine("Your Weapon is ONE HANDED SWORD...");
                    break;
                case "2":
                    Console.WriteLine("Your Weapon is DOUBLE HANDED SWORD...");
                    break;
                case "3":
                    Console.WriteLine("Your Weapon is AXE...");
                    break;
                case "4":
                    Console.WriteLine("Your Weapon is KNIFE...");
                    break;
                case "5":
                    Console.WriteLine("Your Weapon is STAFF...");
                    break;

            }

            Console.WriteLine($"Created Charecter Information ||| NAME: {inComingCharacterName} || RACE: {inComingRace} || JOB: {inComingJob} || CLOTH: {inComingCloth} || WEAPON: {inComingWeapon}");

           

        }
    }

}

//--Irk
//    --Human
//    --NightElf
//    --Dwarf
//    --Orc
//    --Undead
//--Sınıf
//    --Warrior
//    --Paladin
//    --Rogue
//    --Mage

//--Silahlar
//    --Iki adet Kılıç
//		--Çift Elli Kılıç
//		--Balta
//		--Bıçak
//		--Asa
//	--Kıyafetler
//		--Çelik
//		--Demir
//		--Altın
//		--Kumaş
//		--İpek
//	--Player


//---------------------------------------------
////Uygulama çalıştığında bir oyuncu oluşturulsun bilgiler kullanıcıdan alınsın. Alınan bilgilerle beraber oyuncu bir karakter oluşturacak. Her bir karakterin aşağıdaki eylemleri bulunacak.
//	--Saldır
//	--Korun
//	--Yürü
//	--Dinlen



////Oluşturulan karakter Irkı, Silahı, sınıfı, kıyafeti belirlendikten sonra kullanıcı Program.cs içerisinde o karakterin eylemlerini çalıştırabilmeli.

//	warrior.Saldir();
//warrior.Korun();

////SOLID prensiplerini dahil ederek projeyi geliştirin.

////Projeyi NTier katmanlı mimari olarak geliştirin. Oluşturulan karakterler veritabanına kaydedilsin.