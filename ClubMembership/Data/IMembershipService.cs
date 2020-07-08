using ClubMembership.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubMembership.Data
{
    public interface IMembershipService
    {
        Task<IEnumerable<Member>> GetMembers();
        Task<Member> GetMember(int memberId);
        Task<Member> AddMember(Member member);
        Task<Member> UpdateMember(Member member);
        Task DeleteMember(int memberId);
    }
}
