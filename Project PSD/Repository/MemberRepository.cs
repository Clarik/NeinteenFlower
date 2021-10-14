using Project_PSD.Model;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Project_PSD.Repository
{
    public class MemberRepository
    {
        public static void insertMember(MsMember Member)
        {
            DatabaseEntities db = new DatabaseEntities();

            db.MsMembers.Add(Member);
            db.SaveChanges();
        }

        public static List<MsMember> getAllMember()
        {
            DatabaseEntities db = new DatabaseEntities();
            return db.MsMembers.ToList();
        }

        public static MsMember getMember(int id)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsMember Member = db.MsMembers.Find(id);

            return Member;
        }

        public static MsMember getMember(string email)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsMember Member = db.MsMembers.Where(x => x.MemberEmail == email).FirstOrDefault();

            return Member;
        }

        public static void deleteMember(int MemberId)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsMember Member = db.MsMembers.Find(MemberId);

            db.MsMembers.Remove(Member);

            db.SaveChanges();
        }

        public static void updateMember(int id, MsMember update)
        {
            DatabaseEntities db = new DatabaseEntities();

            MsMember Member = db.MsMembers.Find(id);

            Member.MemberName = update.MemberName;
            Member.MemberDOB = update.MemberDOB;
            Member.MemberGender = update.MemberGender;
            Member.MemberAddress = update.MemberAddress;
            Member.MemberPhone = update.MemberPhone;
            Member.MemberEmail = update.MemberEmail;
            Member.MemberPassword = update.MemberPassword;


            db.SaveChanges();
        }

    }
}