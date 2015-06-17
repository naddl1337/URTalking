using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UR_Talking
{
    public class KeyWords
    {
        private static Dictionary<string, string> buzzWords= new Dictionary<string, string>();
        private static Dictionary<string, string> persons = new Dictionary<string, string>();
        private static Dictionary<string, string> places = new Dictionary<string, string>();
        private static string notFound = "Hmm das kann ich dir jetzt leider grad ausm Stehgreif nicht sagen :/. Ich vermerke mir das in meiner Datenbank. Frag mich bitte morgen nochmal"; 

        internal static void init()
        {
            buzzWords.Add("wer","persons");
            buzzWords.Add("wo", "places");
            persons.Add("du", "Ich bin elise, dein immer freundlicher Chatbot :)");
            places.Add("kugel", "Longitude: 2,14556/ Latitude: 3,541256");
            places.Add("piratenhöle", "Ach da bist du ja noch weiiiit weit weg");
            places.Add("du", "Ich wohne in den den unendlichen Weiten des WWW");
        }

        static int i = 0;

        internal static string buzz(string[] key)
        {
             try
            {
            if (i < key.Length) { 
            if (buzzWords.ContainsKey(key[i]))
            switch (key[i])
            {
                case "wer":
                    i++;
                    return Persons(key);
                    break;
                case "wo":
                    i++;
                    return Places(key);
                    break;
                default:
                    break;
            }
            i++;
            return buzz(key);
            }
            }

             catch (Exception e)
             {
                 Console.WriteLine("receive empty String ", e.Source);
                 return "?";
             }
            i = 0;
            return notFound;
        }


        internal static string Persons(string[] key)
        {
            for (int j = 0; j < key.Length; j++)
            {
                if (persons.ContainsKey(key[j])) { 
                    i = 0;
                    return persons[key[j]];
                }
            }

            return "Hmm das kann ich dir jetzt leider grad ausm Stehgreif nicht sagen :/. Ich vermerke mir das in meiner Datenbank. Frag mich bitte morgen nochmal"; 
        }
        internal static string Places(string[] key)
        {
            for (int j = 0; j < key.Length; j++)
            {
                if (places.ContainsKey(key[j])) { 
                    i = 0;
                    return places[key[j]];
                }
            }
            return "Hmm das kann ich dir jetzt leider grad ausm Stehgreif nicht sagen :/. Ich vermerke mir das in meiner Datenbank. Frag mich bitte morgen nochmal"; 
        }


    }
}