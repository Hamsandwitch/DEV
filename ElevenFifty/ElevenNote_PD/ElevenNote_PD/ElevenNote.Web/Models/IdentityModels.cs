﻿//using System.Data.Entity;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;

//namespace ElevenNote.Web.Models
//{
//    // You can add profile data for the user by adding more properties to your ElevenNoteUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
//    public class ElevenNoteUser : IdentityUser
//    {
//        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ElevenNoteUser> manager)
//        {
//            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
//            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
//            // Add custom user claims here
//            return userIdentity;
//        }
//    }

//    public class ApplicationDbContext : IdentityDbContext<ElevenNoteUser>
//    {
//        public ApplicationDbContext()
//            : base("DefaultConnection", throwIfV1Schema: false)
//        {
//        }

//        public static ApplicationDbContext Create()
//        {
//            return new ApplicationDbContext();
//        }
//    }
//}