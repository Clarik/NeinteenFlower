using Project_PSD.Model;

namespace Project_PSD.Factory
{
    public class MemberFactory
    {
        public static MsMember createMember
            (string name, System.DateTime dOB, string gender,string address,
            string phone, string email,string password)
        {
            MsMember new_Member = new MsMember();

            new_Member.MemberName = name;
            new_Member.MemberDOB = dOB;
            new_Member.MemberGender = gender;
            new_Member.MemberAddress  = address;
            new_Member.MemberPhone    = phone;
            new_Member.MemberEmail    = email;
            new_Member.MemberPassword = password;

            return new_Member;
        }

    }
}