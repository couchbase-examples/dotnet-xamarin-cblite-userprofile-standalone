using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProfileDemo.UITests
{
    internal static class TestHelper
    {
        public static string USERNAMEFIELD = "eUsername";
        public static string PASSWORDFIELD = "ePassword";
        public static string NAMEFIELD = "eFullName";
        public static string ADDRESSFIELD = "eAddress";
        public static string EMAILFIELD = "eEmailAddress";
        public static string SIGNINBUTTON = "btnSignIn";
        public static string SIGNOUTBUTTON = "btnSignOut";
        public static string SAVEBUTTON = "btnSave";
        public static string OKBUTTONANDROID = "OK";
        public static string PROFILEHEADER = "Your Profile";
    }

    internal static class TestData
    {
        public static string TESTUSER1 = "demo@example.com";
        public static string TESTUSER2 = "demo2@example.com";
        public static string TESTPASSWORD = "password";
        public static string TESTADDRESS = "123 Nowhere Street";
        public static string TESTNAME = "John Doe";

    }
}
