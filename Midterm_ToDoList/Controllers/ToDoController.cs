using Service;
using Repository;
using Domain;
using Microsoft.AspNetCore.Mvc;


public class ToDoController : Controller
{
    private readonly ToDoService _toDoService;

    public ToDoController(ToDoService toDoService)
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
    public ActionResult Create(ToDo todo)
    {
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
    public ActionResult Edit(ToDo todo)
    {
        _toDoService.Update(todo);
        return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
        _toDoService.Delete(id);
        return RedirectToAction("Index");
    }
}