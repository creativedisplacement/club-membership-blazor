using ClubMembership.Data;
using ClubMembership.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ClubMembership.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMembershipService _membershipService;

        public MemberController(IMembershipService membershipService)
        {
            _membershipService = membershipService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _membershipService.GetMembers());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _membershipService.GetMember(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Member member)
        {
            return Ok(await _membershipService.AddMember(member));
        }

        [HttpPut]
        public async Task<IActionResult> Put(Member member)
        {
            return Ok(await _membershipService.UpdateMember(member));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _membershipService.DeleteMember(id);
            return Ok();
        }
    }
}
