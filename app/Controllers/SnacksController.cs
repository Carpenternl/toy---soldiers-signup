using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using app.Models;
namespace app.Contollers;

[Route("[Controller]")]
[ApiController]
public class SnacksController:ControllerBase{
    public SnacksController(JsonFileService fileService){
        this.FileService = fileService;
    }
    public JsonFileService FileService {get;}

    [HttpGet]
    public IEnumerable<Snack> Get(){
       return  FileService.GetSnacks();
    }
}