using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VL.Data.Model;

namespace VL.Tests.Helpers
{
    /// <summary>
    /// Data initializer for unit tests
    /// </summary>
    public class DataInitializer
    {
        #region Asset
        /// <summary>
        /// Dummy Assets
        /// </summary>
        /// <returns>List of Static Assets</returns>
        public static List<Asset> GetAllAssets()
        {
            var assets = new List<Asset>
            {
                new Asset() { ID = 1, Name = "Hovercraft Board Model 999", CreatedByUserID = "reed.richards", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 2, Name = "Apple iPad Air", CreatedByUserID = "billy.batson", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "clark.kent", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 3, Name = "Galaxy NotePad", CreatedByUserID = "barry.allen", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "bruce.wayne", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 4, Name = "Underwater Air Bucket", CreatedByUserID = "stanley.beamish", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "peter.parker", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 5, Name = "Acme PowerWasher 9000xl", CreatedByUserID = "dick.grayson", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "tony.starks", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 6, Name = "Super Mamba Jamba Jumbilia Processor", CreatedByUserID = "logan.howlett", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "steve.rogers", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 7, Name = "Magic Wand", CreatedByUserID = "scott.summers", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "britt.reid", ModifiedDate = new DateTime(2016, 1, 1)  },
                new Asset() { ID = 8, Name = "Invisibility Cloak", CreatedByUserID = "kit.walker", CreateDate = new DateTime(2016, 1, 1), ModifiedByUserID = "bruce.banner", ModifiedDate = new DateTime(2016, 1, 1)  }
            };
            return assets;
        }

        public static List<AssetType> GetAllAssetTypes()
        {
            var assetTypes = new List<AssetType>
            {
                new AssetType() { ID = 1, Code = "LAP", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016,1,1) },
                new AssetType() { ID = 2, Code = "PHONE", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016,1,1) },
                new AssetType() { ID = 3, Code = "TAB", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016,1,1) }
            };
            return assetTypes;
        }

        #endregion

        #region Badge
        public static List<Badge> GetAllBadges()
        {
            var badges = new List<Badge>()
            {
                new Badge() { ID = 1, Number = "AB1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Badge() { ID = 2, Number = "BC1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Badge() { ID = 3, Number = "CD1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Badge() { ID = 4, Number = "EF1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Badge() { ID = 5, Number = "FG1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Badge() { ID = 6, Number = "GH1234", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return badges;
        }

        public static List<BadgeType> GetAllBadgeTypes()
        {
            var badgeTypes = new List<BadgeType>()
            {
                new BadgeType() { ID = 1, Code = "STICKY", Name = "Sticker Badge", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifedDate = new DateTime(2016, 1, 1) },
                new BadgeType() { ID = 2, Code = "KEYCARD", Name = "Key Card Badge", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifedDate = new DateTime(2016, 1, 1) },
            };
            return badgeTypes;
        }



        #endregion

        #region Campus
        /// <summary>
        /// Dummy Campuses
        /// </summary>
        /// <returns>List of Static Assets</returns>
        public static List<Campus> GetAllCampuses()
        {
            var campuses = new List<Campus>
            {
                new Campus() { ID = 2, Code = "GCC", Name = "Gold Camp", Address = "3101 Gold Camp Drive", Address2 = "Testing Address1", City = "Rancho Cordova", ZipCode = "95670", IsActive = true, CreatedByUserID = "-1", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "-1", ModifiedDate = new DateTime(2016, 1, 1) },
                new Campus() { ID = 4, Code = "HQ", Name = "J Street Building", Address = "1325 J Street", Address2 = "Suite 1600", City = "Sacramento", ZipCode = "95814", IsActive = true, CreatedByUserID = "-1", CreatedDate =  new DateTime(2016, 1, 1), ModifiedByUserID = "", ModifiedDate = new DateTime(2016, 1, 1) },
                new Campus() { ID = 5, Code = "PG1", Name = "Prospect Green 1", Address = "10860 Gold Center Drive", Address2 = null, City = "Rancho Cordova", ZipCode = "95670", IsActive = true, CreatedByUserID = "-1", CreatedDate =  new DateTime(2016, 1, 1), ModifiedByUserID = "", ModifiedDate = new DateTime(2016, 1, 1) },
                new Campus() { ID = 6, Code = "PG3", Name = "Prospect Green 3", Address = "10911 White Rock Road", Address2 = null, City = "Rancho Cordova", ZipCode = "95670", IsActive = true, CreatedByUserID = "-1", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "", ModifiedDate = new DateTime(2016, 1, 1) },
                new Campus() { ID = 7, Code = "CROY", Name = "Croydon Warehouse", Address = "10173 Croydon Way", Address2 = null, City = "Sacramento", ZipCode = "95827", IsActive = true, CreatedByUserID = "-1", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "", ModifiedDate = new DateTime(2016, 1, 1) },
                new Campus() { ID = 8, Code = "VACA", Name = "Vacaville DataCenter", Address = "123 Main Streets", Address2 = null, City = "Vacaville", ZipCode = "55555", IsActive = true, CreatedByUserID = "-1", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return campuses;
        }
        #endregion

        #region Company
        public static List<Company> GetAllCompanies()
        {
            var companies = new List<Company>
            {
                new Company() { ID = 1, Name = "Microsoft", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 2, Name = "Oracle", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 3, Name = "Facebook", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 4, Name = "Yahoo", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 5, Name = "Instagram", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 6, Name = "LinkedIn", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 7, Name = "Yelp", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Company() { ID = 8, Name = "Cisco", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return companies;
        }
        #endregion

        #region Contact
        public static List<Contact> GetAllContacts()
        {
            var contacts = new List<Contact>()
            {
                new Contact() { ID = 1, ContactUserID = "chris.kummer", Phone = "5557778888", Mobile = "4782659254", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Contact() { ID = 2, ContactUserID = "henry.rodriguez", Phone = "3336669999", Mobile = "5942564853", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Contact() { ID = 3, ContactUserID = "ipekelis", Phone = "8885552222", Mobile = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Contact() { ID = 4, ContactUserID = "mickey.mouse", Phone = "7775559999", Mobile = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Contact() { ID = 5, ContactUserID = "tony.stark", Phone = "5268452562", Mobile = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Contact() { ID = 6, ContactUserID = "bruce.wayne", Phone = "5295269854", Mobile = "6852678519", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return contacts;
        }

        #endregion

        #region Location
        public static List<Location> GetAllLocations()
        {
            var locations = new List<Location>()
            {
                new Location() {ID = 1, Name = "Bat Cave", Floor = 0, Room = null, Phone = "5558887456", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Location() {ID = 2, Name = "Fortress Of Solitude", Floor = 0, Room = null, Phone = "5236985247", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Location() {ID = 3, Name = "Legion Of Doom", Floor = 0, Room = null, Phone = "7894561230", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Location() {ID = 4, Name = "Hall of Justice", Floor = 0, Room = null, Phone = "1234567890", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Location() {ID = 5, Name = "Atlantis", Floor = 0, Room = null, Phone = "4561477854", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Location() {ID = 6, Name = "Arconix", Floor = 0, Room = null, Phone = "5894153840", IsActive = true, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return locations;
        }
        #endregion

        #region Log
        public static List<Log> GetAllLogs()
        {
            var logs = new List<Log>()
            {
                new Log() {ID = 1, StartDate = new DateTime(2016, 1, 1), EndDate = new DateTime(2016, 1, 1), Reason = "Perform Underwater Basket Weaving", SpecialInstructions = "Need Huge Pool", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 2, StartDate = new DateTime(2016, 1, 2), EndDate = new DateTime(2016, 1, 2), Reason = "Fixing Fire Sprinklers", SpecialInstructions = "Need some tools", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 3, StartDate = new DateTime(2016, 1, 3), EndDate = new DateTime(2016, 1, 3), Reason = "Meeting wit POTUS", SpecialInstructions = "Get Jellybeans", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 4, StartDate = new DateTime(2016, 1, 4), EndDate = new DateTime(2016, 1, 4), Reason = "Meeting with Ghandi to discuss World Peace", SpecialInstructions = "Put out Recycle bin", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 5, StartDate = new DateTime(2016, 1, 5), EndDate = new DateTime(2016, 1, 5), Reason = "Solving Global Warming", SpecialInstructions = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 6, StartDate = new DateTime(2016, 1, 6), EndDate = new DateTime(2016, 1, 6), Reason = "To save humanity from mankind", SpecialInstructions = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 7, StartDate = new DateTime(2016, 1, 7), EndDate = new DateTime(2016, 1, 7), Reason = "Discuss financing for Pluto Project", SpecialInstructions = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) },
                new Log() {ID = 8, StartDate = new DateTime(2016, 1, 8), EndDate = new DateTime(2016, 1, 8), Reason = "Manning a person to the center of the earth", SpecialInstructions = "", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 1) }
            };
            return logs;

        }
        #endregion

        #region Station
        public static List<Station> GetAllStations()
        {
            var stations = new List<Station>()
            {
                new Station() { ID = 1, Code = "AAA", Name = "Blue Lagoon", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 2, Code = "BBB", Name = "Rainbow Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 3, Code = "CCC", Name = "Raider Nation Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 4, Code = "DDD", Name = "Niner Faithful Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 5, Code = "EEE", Name = "Cowboy Cowgirls Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 6, Code = "FFF", Name = "Bluish Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true },
                new Station() { ID = 7, Code = "GGG", Name = "Galvatron Station", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8), IsActive =  true }
            };
            return stations;

        }
        #endregion

        #region Visit
        public static List<Visit> GetAllVisits()
        {
            var visits = new List<Visit>()
            {
                new Visit() { ID = 1, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  },
                new Visit() { ID = 2, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  },
                new Visit() { ID = 3, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  },
                new Visit() { ID = 4, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  },
                new Visit() { ID = 5, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  },
                new Visit() { ID = 6, ScheduledCheckInTime = new DateTime(2016, 1, 8), ScheduledCheckOutTime = new DateTime(2016, 1, 8), ActualCheckInTime = null, ActualCheckOutTime = null, CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 8), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016, 1, 8)  }
            };
            return visits;
        }
        #endregion

        ///// <summary>
        ///// Dummy tokens
        ///// </summary>
        ///// <returns></returns>
        //public static List<Token> GetAllTokens()
        //{
        //    var tokens = new List<Token>
        //                       {
        //                           new Token()
        //                               {
        //                                   AuthToken = "9f907bdf-f6de-425d-be5b-b4852eb77761",
        //                                   ExpiresOn = DateTime.Now.AddHours(2),
        //                                   IssuedOn = DateTime.Now,
        //                                   UserId = 1
        //                               },
        //                           new Token()
        //                               {
        //                                   AuthToken = "9f907bdf-f6de-425d-be5b-b4852eb77762",
        //                                   ExpiresOn = DateTime.Now.AddHours(1),
        //                                   IssuedOn = DateTime.Now,
        //                                   UserId = 2
        //                               }
        //                       };

        //    return tokens;
        //}

        ///// <summary>
        ///// Dummy users
        ///// </summary>
        ///// <returns></returns>
        //public static List<User> GetAllUsers()
        //{
        //    var users = new List<User>
        //                       {
        //                           new User()
        //                               {
        //                                   UserName = "akhil",
        //                                   Password = "akhil",
        //                                   Name = "Akhil Mittal",
        //                               },
        //                           new User()
        //                               {
        //                                   UserName = "arsh",
        //                                   Password = "arsh",
        //                                   Name = "Arsh Mittal",
        //                               },
        //                           new User()
        //                               {
        //                                   UserName = "divit",
        //                                   Password = "divit",
        //                                   Name = "Divit Agarwal",
        //                               }
        //                       };

        //    return users;
        //}

    }
}
