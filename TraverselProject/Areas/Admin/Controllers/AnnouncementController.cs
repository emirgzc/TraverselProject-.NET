﻿using AutoMapper;
using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using TraverselProject.Areas.Admin.Models;

namespace TraverselProject.Areas.Admin.Controllers
{
	[Area("Admin")]
	[Route("/Admin/[controller]/[action]")]
	[AllowAnonymous]
	public class AnnouncementController : Controller
	{
		private readonly IAnnouncementService _announcementService;
		private readonly IMapper _mapper;

		public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
		{
			_announcementService = announcementService;
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());
			return View(values);
		}
		[HttpGet]
		public IActionResult AddAnnouncement()
		{
			return View();
		}
		[HttpPost]
		public IActionResult AddAnnouncement(AnnouncementAddDto model)
		{
			if (ModelState.IsValid)
			{
				_announcementService.TAdd(new Announcement()
				{
					Title = model.Title,
					Content = model.Content,
					AnnoDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
				});
				return RedirectToAction("Index");
			}
			return View(model);
		}
		[Route("{id}")]
		public IActionResult DeleteAnnouncement(int id)
		{
			var values = _announcementService.TGetByID(id);
			_announcementService.TDelete(values);
			return RedirectToAction("Index");
		}        
        [HttpGet]
        [Route("{id}")]
        public IActionResult UpdateAnnouncement(int id)
		{
			var values = _mapper.Map<AnnouncementUpdateDto>(_announcementService.TGetByID(id));
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateAnnouncement(AnnouncementUpdateDto model)
		{
			if (ModelState.IsValid)
			{
				_announcementService.TUpdate(new Announcement()
				{
					AnnouncementID = model.AnnouncementID,
					Title=model.Title,
					Content = model.Content,
					AnnoDate = Convert.ToDateTime(DateTime.Now.ToShortDateString())
				});
				return RedirectToAction("Index");
			}
			return View(model);
		}
	}
}
