# LeBMiniCh10Magic8BallEndpoint
Brandon Le

10/27/22

Mini Challenge 10 - Magic 8 Ball Endpoint

Web API project that will generate random answers just like a magic 8 ball to "answer" the question that the user is thinking in their head or asking aloud. There are 8 different responses in total. If the user enters in something other than AMA at the end of the URL then there will be an error code to prompt them to fix it and it also provides the proper URL for them to click. There's also an instructions page at the very beginning with URL ending in /minich10/ that also provides a link for people to click if they don't understand. Simply have to press send to refresh a new answer.

# Directions:
1. Open the file in visual studio code.
2. Run the debug either by clicking on the "run and debug" icon on the left side and then the green play button, or by using the F5 command.
3. Next you want to go to your debug console located on the bottom by your terminal.
4. Then look for the "Now listening on:" and there should be a local host URL that you can copy.
5. Take that URL and you can either paste it into a web browser, or by using an application called Postman, you can hit the plus sign at the top of Postman and paste the URL there.
6. After you paste the localhost URL either into a browser or postman, add /MiniCh9 at the end and press send. For example: https://localhost:7062/MiniCh10 and this will lead you to an instructions page to help guide you through the application! *See end of directions for what the Instructions page will look like.*
7. After you paste the localhost URL either into a web browser or Postman, add /Magic8Ball to the end. It should look something like this: https://localhost:7062/MiniCh10/Magic8Ball
8. At this point you're almost done! Just add a /AMA (caps or no caps should not matter) at the end of the URL and press send! For example my URL would look like this: https://localhost:7062/MiniCh10/Magic8Ball/AMA.
9. If you're having trouble don't forget to check your local host to make sure you're using the right number and ensure that you ran the debug before attempting to use the URL in your web browser or Postman.

*Directions step 6 - What the instructions page will look like when you enter https://localhost:7062/MiniCh10 into Postman or a web browser*

Hello Hello! Welcome to my Magic 8 Ball! You can ask me ANYTHING your heart desires!

Think of what you'd like to ask then type in

https://localhost:7062/minich10/magic8ball/AMA

or just click the link and hit send.


# Peer Review: Samuel Laguna
The project ran good. The inputs work how they should. And the terminal spits out the corect info. It even tells you if the entry is invalid. This code is all good.
