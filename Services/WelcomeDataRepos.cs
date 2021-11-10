using DocumentFormat.OpenXml.Wordprocessing;
using NewPortfolioUpdate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NewPortfolioUpdate.Services
{
    public class WelcomeDataRepos : IHomePageDataService
    {
        List<WelcomeModel> displayList = new List<WelcomeModel>();// moving this outside of the function makes it global so each function can read.
       
        StringBuilder sb = new StringBuilder();
        public int Delete(WelcomeModel entry)
        {
            throw new NotImplementedException();
        }

                
        public List<WelcomeModel> GetAllData()
        {
            WelcomeModel t = new WelcomeModel();var s = t.id;
                var firstWord = s;
            if (displayList.Count == 0)
            { 
              
                displayList.Add(new WelcomeModel
                {
                    id = "about",
                    CardImage="/media/AboutMe.png",
                    Title = "About me",
                    LineOne = "I am a Software Developer with a background of Game and Application development.I originally trained using the C-Sharp language and then moved on to learn more about html5, Css, Sql, Bootstrap, and Lua.",
                    LineTwo = "I am result orientated and seeking commercial experience to add to what I already learned in production in college and University. I am looking to develop my skills and become an accomplished full-stack developer. ",
                    LineThree=""
                    
                });;
                displayList.Add(new WelcomeModel
                {
                    id = "development",
                    CardImage = "/media/dev.png",
                    Title = "Development ",
                    LineOne = "My education in computer games development is where I learned the fundamentals of computer science. From binary and computer history through to building forms and fully playable computer games. Using and Implementing Audio software for both soundtracks and voiceovers I learned to edit and create audio for use within the products I made.Other Software such as Auto - Cad,Blender, Adobe PhotoShop, Gimp, Adobe illustrator, and Adobe Animate, would be for creating other new assets such as in game objects, splash screens and sprites.",
                    LineTwo = "Technical processes I developed wer the use of development log, scheduling with Gantt charts, recording progress for the development journal.Planning with diagrams such as Activity - diagrams,UML,and Use Case to help plan using the project specifications.Story boards would also be another method used for planning and pitching new concepts.",
                    LineThree = "From there onwards I researched more programming methods and software.I became proficient in Unity and used this game engine to learn and practice algorithms for Artificial Intelligence methods in pathfinding with my main focus being on Utility AI.In addition I learned some Lua for creating modified game patches for existing games such as GTA5 which often used MySql, so it was a natural progression to move on and learn more about Sql databases and web application software.This brings me to the present where developing in ASP.net(mvc) combines all of these things and gives me new goals for the future.",
                });
                displayList.Add(new WelcomeModel
                {
                    id = "future",
                    CardImage = "/media/future.png",
                    Title = "Future",
                   LineOne= "My goal for the near future is to have the opportunity to work in the web and software development industry and work hard at developing a career. My Ideal employer will challenge me to learn industry methods and develop my skills. I strive to make my employer and colleagues succeed and want to be a part of a fantastic company.",
                    LineTwo = "",
                    LineThree = ""

                });
                displayList.Add(new WelcomeModel
                {
                    id="oopProduct",
                    CardImage = "/media/Production.png",
                    Title ="Production",
                    LineOne= "Working from a client brief I was part of a team that created the game named Under Construction.This was a game designed to help educate students on the importance of waste management within the construction industry.This product was done over the course of a year working alongside four artists and two other programmers.",
                    LineTwo= "The video below shows the finished product in a presentation trailer format.",
                    LineThree = " Note: The ownership of this game is reserved by Glasgow Caledonian University.",
                
                    Video= "/media/finalProduct.mp4"
                }) ;
                displayList.Add(new WelcomeModel
                {
                    id = "Utility",
                    CardImage = "/media/utility.png",
                    Title = "Utility Ai",
                    LineOne = "Utility Ai is a very useful concept as it is an Algorithm that has a list of priorities and will organise them to whichever has the highest utility value at that given moment. So the value of any given utility may change depending on its needs which allows an agent to change its current goal to a more valued goal.",
                    LineTwo = "I created an example AI Agent that has a set of instructions it must carry out before it can move on to the next task. For this example the Agent (ball) must have its health above a certain threshold then collect a shield and ammunition. At that point it can move forward and fire the ammunition. However if these values drop below the threshold it will return to refill them but it will prioritise health over all things as that is the main value that allows it to carry on. ",
                    LineThree = "This Method of AI is used in some Solar Power Plants to keep things running optimally at all times, and has many implications for future applications.  ",
                    Game=""
                });
                displayList.Add(new WelcomeModel
                {
                    id = "Shop",
                    CardImage = "/Media/Shop.png",
                    Title = "Shopping List",
                    LineOne = "Browse and Alter",
                    LineTwo = "The shopping List",
                    LineThree = "Database here!",
                   button=""

                });

                displayList.Add(new WelcomeModel
                {
                    islogo = "",
                    idTwo ="html5",
                    logo = "/media/html.png"
                });
                displayList.Add(new WelcomeModel
                {
                    islogo = "",
                    idTwo = "css",
                    logo = "/media/css.png"
                });
                displayList.Add(new WelcomeModel
                {
                    islogo = "",
                    idTwo = "bootstrap",
                    logo = "/media/bootstrap.png"
                });
                displayList.Add(new WelcomeModel
                {
                    islogo = "",
                    idTwo = "asp.net",
                    logo = "/media/aspnet.png"
                });
                displayList.Add(new WelcomeModel
                {
                    islogo = "",
                    idTwo = "sql;",
                    logo = "/media/sql.png"
                });
                displayList.Add(new WelcomeModel
                {
                    islogo="",
                    idTwo = "c#;",
                    logo = "/media/c-sharp.png"
                });

            }
            return displayList;
        }

   

        public List<WelcomeModel> GetDataById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(WelcomeModel entry)
        {
            throw new NotImplementedException();
        }

        public List<WelcomeModel> SearchData(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(WelcomeModel entry)
        {
            throw new NotImplementedException();
        }
    }
}
