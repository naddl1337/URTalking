using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UR_Talking.Levenstein;

namespace UR_Talking
{

    //http://www.codeproject.com/Articles/36106/Chatbot-Tutorial
    public class CreateAnswer
    {
        private List<String> savedConversation = new List<String>();

        public string speak(string[] key)
        {

            ConnectToMySQL connect = new ConnectToMySQL();
            string searchInTable = "orte";
            string question = "Wo ist die Mensa?";
            string elise_speak = testAlgorithmLevenstein(connect, searchInTable, question);

          //  string elise_speak = KeyWords.buzz(key);
            return elise_speak;
        }

        public string testAlgorithmLevenstein(ConnectToMySQL connect, string searchInTable, string question_user)
        {   
            ExecuteLevenstein l = new ExecuteLevenstein();
            List<string>[] res = connect.Select(searchInTable);
            List<string> question_db = res[1];
            List<string> answers_db = res[2];
            string answer_match = answers_db[0];
            int helper = l.useLevenstein(question_user, question_db[0]);

            for (int i = 0; i < answers_db.Count; i++)
            {
                if (helper > l.useLevenstein(question_user, question_db[i]))
                {
                    helper = l.useLevenstein(question_user, question_db[i]);
                    answer_match = answers_db[i];
                }
            }
            return answer_match;
        }

        public String useContext()
        {
            //TODO: search in savedConversation
            return "";
        }





    }
}