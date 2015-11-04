 using System;  
 using System.Collections.Generic;  
 using System.Linq;
using System.Text;  
 using System.Threading.Tasks;  
    
 namespace AlphaCypher
  
  {  
      public class Vigenere : CypherBase  
      {  
         public Vigenere() : base()
         {  
  
         }

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            int crowding = ResearchLetterByPosition(cypher.ToUpper()[0]) + 1;
            resp = Decode(text.ToUpper(), crowding);
            return resp;
        }

        private string Decode(string v, int crowding)
        {
            throw new NotImplementedException();
        }

        private int ResearchLetterByPosition(char v)
        {
            throw new NotImplementedException();
        }
    }  
  }
