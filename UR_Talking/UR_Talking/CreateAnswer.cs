using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UR_Talking
{

    //http://www.codeproject.com/Articles/36106/Chatbot-Tutorial
    public class CreateAnswer
    {
        private List<String> savedConversation = new List<String>();
        
        public string speak(string[] key)
        {
 
              string  elise_speak = KeyWords.buzz(key);
            


            return elise_speak;
        }


        public String useRegEx() {

            return ""; 
        }

        public String useContext() {
            //TODO: search in savedConversation
            return ""; 
        }


        


    }
}