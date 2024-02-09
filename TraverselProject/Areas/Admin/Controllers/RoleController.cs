using DocumentFormat.OpenXml.Office2010.Excel;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraverselProject.Areas.Admin.Models;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("Admin/Role")]
	public class RoleController : Controller
	{
		private readonly RoleManager<AppRole> _roleManager;
		private readonly UserManager<AppUser> _userManager;

		public RoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
		{
			_roleManager = roleManager;
			_userManager = userManager;
		}

		[Route("Index")]
		public IActionResult Index()
		{
			var values = _roleManager.Roles.ToList();
			return View(values);
		}
		[Route("AddRole")]
		[HttpGet]
		public IActionResult AddRole()
		{
			return View();
		}
		[Route("AddRole")]
		[HttpPost]
		public async Task<IActionResult> AddRole(AddRoleModel model)
		{
			AppRole role = new AppRole()
			{
				Name = model.RoleName
			};
			var result = await _roleManager.CreateAsync(role);
			if (result.Succeeded)
			{
				return RedirectToAction("Index");
			}
			else
			{
				return View();
			}
		}
		[Route("DeleteRole/{id}")]
		public async Task<IActionResult> DeleteRole(int id)
		{
			var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			await _roleManager.DeleteAsync(value);
			return RedirectToAction("Index");
		}
		[Route("UpdateRole/{id}")]
		[HttpGet]
		public IActionResult UpdateRole(int id)
		{
			var value = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
			UpdateRoleModel updateRoleModel = new UpdateRoleModel
			{
				RoleID = value.Id,
				RoleName = value.Name
			};
			return View(updateRoleModel);
		}
		[Route("UpdateRole/{id}")]
		[HttpPost]
		public async Task<IActionResult> UpdateRole(UpdateRoleModel model)
		{
			var value = _roleManager.Roles.FirstOrDefault(x => x.Id == model.RoleID);
			value.Name = model.RoleName;
			await _roleManager.UpdateAsync(value);
			return RedirectToAction("Index");
		}
		[Route("UserList")]
		public IActionResult UserList()
		{
			var values = _userManager.Users.ToList();
			return View(values);
		}
		[Route("AssignRole/{id}")]
		[HttpGet]
		public async Task<IActionResult> AssignRole(int id)
		{
			var user = _userManager.Users.FirstOrDefault(x => x.Id == id);
			TempData["Userid"] = user.Id;
			var roles = _roleManager.Roles.ToList();
			var userRoles = await _userManager.GetRolesAsync(user);
			List<RoleAssignModel> roleAssignModels = new List<RoleAssignModel>();
			foreach (var item in roles)
			{
				RoleAssignModel model = new RoleAssignModel();
				model.RoleId = item.Id;
				model.RoleName = item.Name;
				model.RoleExist = userRoles.Contains(item.Name);
				roleAssignModels.Add(model);
			}
			return View(roleAssignModels);
		}
		[Route("AssignRole/{id}")]
		[HttpPost]
		public async Task<IActionResult> AssignRole(List<RoleAssignModel> models)
		{
			var userid = (int)TempData["Userid"];
			var user = _userManager.Users.FirstOrDefault(x=>x.Id==userid);
			foreach (var item in models)
			{
				if (item.RoleExist)
				{
					await _userManager.AddToRoleAsync(user, item.RoleName);
				}
				else
				{
					await _userManager.RemoveFromRoleAsync(user, item.RoleName);
				}
			}
			return RedirectToAction("UserList");
		}
	}
}
