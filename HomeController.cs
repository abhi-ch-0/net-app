using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/")]
public class HomeController {
    [HttpGet]
    public string Get() {
        return "Hello World!";
    }
}