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
        /// <summary>
        /// Dummy products
        /// </summary>
        /// <returns></returns>
        public static List<VisitorLog> GetAllVisitorLogs()
        {
            var visitorlogs = new List<VisitorLog>
            {
                new VisitorLog() {VisitID = 1, VisitorLogNo = "05V2026", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 2, VisitorLogNo = "05V2078", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCOTest", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 3, VisitorLogNo = "05V2080", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 4, VisitorLogNo = "05V2081", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 5, VisitorLogNo = "05V2082", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 6, VisitorLogNo = "05V2083", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 7, VisitorLogNo = "05V2084", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 8, VisitorLogNo = "05V2085", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 9, VisitorLogNo = "05V2086", FY = "2005/06", StatusId = 2, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  },
                new VisitorLog() {VisitID = 10, VisitorLogNo = "05V2087", FY = "2005/06", StatusId = 3, Amendment = 3, AmendDateTime = Convert.ToDateTime("2008-01-15 10:49:00"), StartDateTime = Convert.ToDateTime("2008-01-26 07:00:00"), EndDate = Convert.ToDateTime("2008-01-26 00:00:00"), OnGoing = false, Company = "COSCO", CampusID = 1, OtherRoomInfo = "RECEPTION", OtherAccessAreaInfo = "Fire Pump RM", PrimaryContactId = 615, SecondaryContactId = 249, Reason = "SPRINKLER SYSTEM MAINTENANCE", SpecialInstruction = "", SubmittedById = 565, DistributedById = 357, CreatedById = 53, CreatedDate = Convert.ToDateTime("2006-07-05 08:32:00.000"), ModifiedById = 565, ModifiedDate = Convert.ToDateTime("2008-01-15 10:49:10.000")  }
            };
            return visitorlogs;
        }

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
