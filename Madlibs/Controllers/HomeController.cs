using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;
using System.Collections.Generic;
using System;


namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/story")]

        public ActionResult Story(string inputsNoun, string inputsVerb, string inputsAdj, string inputsAdv)
        { 
            Words myWords = new Words();
            myWords.Noun = inputsNoun;
            myWords.Verb = inputsVerb;
            myWords.Adjective = inputsAdj;
            myWords.Adverb = inputsAdv;
            string[] id = { inputsNoun, inputsVerb, inputsAdj, inputsAdv};
            return View(myWords);
        }



    
    }
}