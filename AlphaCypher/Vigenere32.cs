using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaCypher
{
    public class Vigenere32 : Vigenere
    {
        public Vigenere32() : base()
        {

        }

        private const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

        //protected override void InizializzaAlfabeto()
        //{
        //    _vettAlfabeto = alfabeto.ToCharArray().ToList();
        //}

        public override string Encode(string text, string cypher)
        {
            string resp = "";
            var parolaInByte = Encoding.Unicode.GetBytes(text);
            object Base32Encoding = null;
            //text = Base32Encoding.Encode(parolaInByte);
            resp = base.Encode(text, cypher);
            return resp;
        }

        public override string Decode(string text, string cypher)
        {
            string resp = "";
            var parolaInByte = Encoding.Unicode.GetBytes(text);
            object Base32Encoding = null;
           // text = Base32Encoding.Encode(parolaInByte);
            resp = base.Encode(text, cypher);
            return resp;
        }

        
    }
}
 
