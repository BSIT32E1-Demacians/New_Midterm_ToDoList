﻿using ToDo.Services;
using ToDo.Repository;
using ToDo.Domain;
using Microsoft.AspNetCore.Mvc;

public class ToDoController : Controller
{
    private readonly IToDoService _toDoService;

    public ToDoController(IToDoService toDoService)
    {
        _toDoService = toDoService;
    }

    public ActionResult Index()
    {
        var todos = _toDoService.GetAll();
        return View(todos);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(ToDo.Domain.ToDo todo)
    {
        if (string.IsNullOrWhiteSpace(todo.Description) || string.IsNullOrWhiteSpace(todo.Category))
        {
            ModelState.AddModelError("", "Fields must not be empty");
            return View(todo);
        }
        _toDoService.Create(todo);
        return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var todo = _toDoService.GetById(id);
        return View(todo);
    }

    [HttpPost]
    public ActionResult Edit(ToDo.Domain.ToDo todo)
    {
        if (string.IsNullOrWhiteSpace(todo.Description) || string.IsNullOrWhiteSpace(todo.Category))
        {
            ModelState.AddModelError("", "Fields must not be empty");
            return View(todo);
        }
        _toDoService.Update(todo);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        _toDoService.Delete(id);
        return RedirectToAction("Index");
    }
}