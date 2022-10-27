//Brandon Le
//10-27-22
//Mini Challenge 10 - Magic 8 Ball
//Web API project that will generate random answers just like a magic 8 ball to "answer" the question that the user is thinking in their head or asking aloud. There are 8 different responses in total. If the user enters in something other than AMA at the end of the URL then there will be an error code to prompt them to fix it and it also provides the proper URL for them to click. There's also an instructions page at the very beginning with URL ending in /minich10/ that also provides a link for people to click if they don't understand. Simply have to press send to refresh a new answer.
//peer review: Samuel Laguna: The project ran good. The inputs work how they should. And the terminal spits out the corect info. It even tells you if the entry is invalid. This code is all good.

using Microsoft.AspNetCore.Mvc;

namespace LeBMiniCh10Magic8BallEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniCh10Controller : ControllerBase
{
    public string Instructions()
    {
        return "Hello Hello! Welcome to my Magic 8 Ball! You can ask me ANYTHING your heart desires!\n\n Think of what you'd like to ask then type in\n https://localhost:7062/minich10/magic8ball/AMA\n or just click the link and hit send.";
    }

    [HttpGet]
    [Route("Magic8Ball/{askMe}")]
    public string Magic8Ball(string askMe)
    {
        string [] replies = {"You should ask Ken that.", "Did you try asking the TA's?", "I'm not so sure about that one...", "Why would you ask that???", "That's a DEFINITE yes :)", "I'm not sure can you ask something else?", "I know they say there's no dumb questions but...", "Sorry to say this, but better luck next time."};

        if(askMe == "AMA" || askMe == "Ama" || askMe == "AMa" || askMe == "AmA" || askMe == "aMa" || askMe == "aMA" || askMe == "ama")
        {
            Random r = new Random();
            int randomInt = r.Next(0, 7); 
            return $"{replies[randomInt]}\n\n Was this the answer you were looking for?\n Hit send to try again :)";
        }
        else
        {
            return "Invalid entry! Please type in AMA or go to this URL:\n https://localhost:7062/minich10/magic8ball/AMA ";
        }
    }
}
