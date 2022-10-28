//Elizar Garcia
//10-27-22
//MiniChReverseIt
//This is a console project that will reverse a word or numbers that is entered by the user
//Peer Review: Pedro Castaneda - I like the simplicity and cleanliness of your code. I like that the output has a creature character! Great work.




using Microsoft.AspNetCore.Mvc;

namespace GarciaEReverseitEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class ReverseController : ControllerBase
{
[HttpGet]
    [Route("Reverse/{input}")]

    public string reverse(string input)
    {
        string rev = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            rev = rev + input[i];
        }
        return $" {input} <[^-^]>  {rev}";
    }
   


}