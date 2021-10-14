using Project_PSD.Handler;
using Project_PSD.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_PSD.Controller
{
    public class MemberController
    {

        public static MsMember searchMember(int id)
        {
            return MemberHandler.searchMember(id);
        }

        public static MsMember searchMember(string email)
        {
            return MemberHandler.searchMember(email);
        }

        public static void insertMember(string name, System.DateTime dOB, string gender, string address, string phone, string email, string password)
        {
            MemberHandler.insertMember(name, dOB, gender, address, phone, email, password);
        }

        public static void updateMember(int id, string name, System.DateTime dOB, string gender, string address, string phone, string email, string password)
        {
            MemberHandler.updateMember(id, name, dOB, gender, address, phone, email, password);
        }

        public static string isMemberIdAvaible(string id)
        {
            int TempId;
            if (int.TryParse(id, out TempId) == false)
                return "error";
            TempId = int.Parse(id);

            MsMember member = searchMember(TempId);
            if (member == null)
                return "error";
            return "";
        }

        public static string MemberNameChecker(string name)
        {
            if (name.Length == 0)
            {
                return "Member name must be filled";
            }
            else
            if (name.Length < 3 && name.Length > 20)
            {
                return "Minimal length is 3 characters and 20 characters is the maximal";
            }
            else
            if(!name.All(char.IsLetter)){
                return "Member name must be Letters";
            }
            return "";
        }

        public static string MemberAgeChecker(System.DateTime dob)
        {
            int age = System.DateTime.Today.Year - dob.Year;

            if (age < 17 || dob == null)
                return "Member must be over 17";
            return "";
        }

        public static string MemberAddressChecker(string address)
        {
            if (!(address.Contains("Street") || address.Contains("street")))
                return "Member address must contains 'street'";
            return "";
        }


        public static string MemberPasswordChecker(string password)
        {
            if (password.Length < 3 && password.Length > 20)
            {
                return "Minimal length is 3 characters and 20 characters is the maximal";
            }
            return "";
        }

        public static string MemberEmailChecker(string email)
        {
            if (!email.Contains("@"))
            {
                return "Email must contain @";
            }
            MsMember EmailExist = searchMember(email);
            if (EmailExist != null)
            {
                return "Email is taken";
            }
            return "";
        }

        public static List<MsMember> getAllMember()
        {
            return MemberHandler.getAllMember();
        }

        public static void deleteMember(int MemberId)
        {
            MemberHandler.deleteMember(MemberId);
        }
    }
}