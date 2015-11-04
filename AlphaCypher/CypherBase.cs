using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace AlphaCypher
{



    public abstract class CypherBase : ICypher
    {

        private List<Char> _vettAlfabeto;
        protected int _spiazzamento;




        protected List<Char> _alphabetList;

        protected int _crowding;


        public CypherBase()
        {
            _alphabetList = new List<char>();





        }

      

        public Task<string> DecodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }

        //public string Encode(string text, string cypher)
        //{


        //    string resp = "";
        //    char[] s = text.ToCharArray();
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        char tmp = s[i];
        //        int pos = ResearchLetterByPosition(tmp);

        //        //   int posCodificata = (pos + spiazzamento) % 26;

        //    }
        //    return resp;
        //    throw new NotImplementedException();
        //}

        public Task<string> EncodeAsync(string text, string cypher)
        {
            throw new NotImplementedException();
        }







        protected virtual void Intiliaze()
        {
            for (int i = 0; i < 26; i++)
            {
                char tmp = (char)(i + 65);
                _alphabetList.Add(tmp);
            }
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

        //
        //ricerca lettera da posizione
        private int ResearchLetterByPosition(char tmp)
        {
            int resp = 0;
            for (int i = 0; i < _alphabetList.Count; i++)
            {
                if (tmp == _alphabetList[i])
                {
                    resp = i;
                }

            }
            return resp;
        }
        //   private int CharacherEncode ()

        //   {



        // }
        public virtual string Decode(string text, string cypher)
        {
            string resp = "";
            char[] s = text.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                char tmp = s[i];
                int pos = ResearchLetterByPosition(tmp);
                int po = Convert.ToInt32(cypher);
                int posCodificata = (pos - po) % 26;
                resp += _vettAlfabeto[posCodificata];
            }
            return resp;

        }

        public virtual string Encode(string text, string cypher)
         {  
            string resp = "";  
           int crowding = ResearchLetterByPosition(cypher.ToUpper()[0]) + 1;  
            resp = Decode(text.ToUpper(), crowding);    
             return resp;  
         }

        public string Encode(string text)
         {  
            string resp = "";  
            resp = Decode(text, _crowding);  
            resp = Encode(text, _crowding);  
             return resp;  
          }

        private string Decode(string text, int _crowding)
        {
            throw new NotImplementedException();
        }

        private string Encode(string text, int _crowding)
        {
            throw new NotImplementedException();
        }

        public string Encode(char text, char cypher)
         {  
              string resp = "";  
           resp = Decode(text.ToString(), cypher.ToString());  
             resp = Encode(text.ToString(), cypher.ToString());  
              return resp;  
          }


}
}
