using Project_PSD.Factory;
using Project_PSD.Model;
using Project_PSD.Repository;
using System.Collections.Generic;

namespace Project_PSD.Handler
{
    public class MemberHandler
    {

        public static MsMember searchMember(int id)
        {
            return MemberRepository.getMember(id);
        }
        public static MsMember searchMember(string email)
        {
            return MemberRepository.getMember(email);
        }

        public static void insertMember(string name, System.DateTime dOB, string gender, string address, string phone, string email, string password)
        {
            MsMember new_Member = MemberFactory.createMember(name, dOB, gender, address, phone, email, password);

            MemberRepository.insertMember(new_Member);
        }

        public static void updateMember(int id, string name, System.DateTime dOB, string gender, string address, string phone, string email, string password)
        {
            MsMember new_Member = MemberFactory.createMember(name, dOB, gender, address, phone, email, password);

            MemberRepository.updateMember(id, new_Member);
        }

        public static List<MsMember> getAllMember()
        {
            return MemberRepository.getAllMember();
        }

        public static void deleteMember(int MemberId)
        {
            MemberRepository.deleteMember(MemberId);
        }
    }
}