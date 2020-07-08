using ClubMembership.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ClubMembership.Data
{
    public class MembershipService : IMembershipService
    {
        private readonly ApplicationDbContext _context;

        public MembershipService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Member>> GetMembers() => await _context.Members.ToListAsync();

        public async Task<Member> GetMember(int memberId) =>
            await _context.Members.FirstOrDefaultAsync(m => m.Id == memberId);

        public async Task<Member> AddMember(Member member)
        {
            _context.Add(member);
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task<Member> UpdateMember(Member member)
        {
            _context.Entry(member).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return member;
        }

        public async Task DeleteMember(int memberId)
        {
            var member = new Member { Id = memberId };
            _context.Remove(member);
            await _context.SaveChangesAsync();
        }
    }
}