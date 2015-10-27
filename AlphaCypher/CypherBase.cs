using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{


        public abstract class CypherBase : ICypher
    {


        protected List<Char> _alphabetList;
        protected int _crowding;

        public CypherBase()
        {
            _alphabetList = new List<char>();

        }

        public string Decode(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public string Encode(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        public Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }







        // metodo codifica
        //public virtual string encode(string testo,string cypher)
        //{

        //    string ris = "";

        //    int crowding = ResearchLetterPosition(cypher.ToUpper()[0]) + 1;
        //    ris = Decode(testo.ToUpper(), crowding);
        //    int crowding = ResearchLetterPosition(cypher.ToUpper()[0]);
        //    ris = encode(testo.ToUpper(), crowding);
        //    return ris;




        //}

        //metodo di decodifica 
        //public string Encode ()
        //{

        //    string ris = "";

        //    ris = Decode(testo, _crowding);
        //    ris = encode(testo, _crowding);
        //    return resp;


        //}
        //public string Encode(char text, char cypher)
        // {  
        //  string risp = "";  
        //    ris = Decode(text.ToString(), cypher.ToString());  
        //    ris = Encode(text.ToString(), cypher.ToString());  
        //     return ris;  
        // }


    }
}
