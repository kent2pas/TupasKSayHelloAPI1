//Kent Tupas
//10/25/2022
//Say Hello in API
//Peer Review:Isaiah Ferguson - Program works great! no errors.
using Microsoft.AspNetCore.Mvc;

namespace TupasKSayHelloAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
 [HttpGet]
 [Route("Hello/{name}")]

 public string Hello(string name)
 {
    return $"Hello {name} \nHope you have a great day!!!";
 }

}

