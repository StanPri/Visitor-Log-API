﻿using System;
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
        #region Assets
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
                new AssetType() { ID = 1, Code = "PHONE", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016,1,1) },
                new AssetType() { ID = 1, Code = "TAB", CreatedByUserID = "_admin", CreatedDate = new DateTime(2016, 1, 1), ModifiedByUserID = "_admin", ModifiedDate = new DateTime(2016,1,1) }
            };
            return assetTypes;
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
