using System;
using WallF.BaseNEncodings.Util;

namespace WallF.BaseNEncodings
{
   
    public partial class Base64Encoding : BaseEncoding
    {
        
        public const string STANDARD_ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
        
        public const char STANDARD_PADDING = '=';
       
        public const string DEFAULT_NAME = "Standard Base64 Encoding";

        private readonly char[] alphabet;
        private readonly char padding;
        private readonly string encodingName;

        
        public Base64Encoding() : this(STANDARD_ALPHABET.ToCharArray(), STANDARD_PADDING, DEFAULT_NAME, false) { }

        
        /// <param name="alphabet">Alphabet for current encoding.</param>
        /// <param name="padding">Padding character for current encoding.</param>
        /// <exception cref="ArgumentNullException">alphabet is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">size of alphabet is not 64</exception>
        /// <exception cref="ArgumentException">alphabet contains duplicated items</exception>
        public Base64Encoding(char[] alphabet, char padding) : this(alphabet, padding, "Customized Base64 Encoding", true) { }

       
        /// <param name="alphabet">Alphabet for current encoding.</param>
        /// <param name="padding">Padding character for current encoding.</param>
        /// <param name="encodingName">Name for current encoding.</param>
        /// /// <exception cref="ArgumentNullException">alphabet or encoodingName is null</exception>
        /// <exception cref="ArgumentOutOfRangeException">size of alphabet is not 64</exception>
        /// <exception cref="ArgumentException">alphabet contains duplicated items, or padding already existed in alphabet</exception>
        public Base64Encoding(char[] alphabet, char padding, string encodingName) : this(alphabet, padding, encodingName, true) { }

        internal Base64Encoding(char[] alphabet, char padding, string encodingName, bool verify)
        {
            if (verify)
            {
                if (alphabet == null)
                    throw new ArgumentNullException("alphabet", "alphabet is null");
                if (encodingName == null)
                    throw new ArgumentNullException("encodingName", "encodingName is null");
                if (alphabet.Length != 64)
                    throw new ArgumentOutOfRangeException("alphabet", "size of alphabet is not 64");
                if (ArrayFunctions.IsArrayDuplicate(alphabet))
                    throw new ArgumentException("alphabet", "alphabet contains duplicated items");
                if (ArrayFunctions.IsArrayContains(alphabet, padding))
                    throw new ArgumentException("padding", "padding already existed in alphabet");
            }
            this.alphabet = (char[])alphabet.Clone();
            this.padding = padding;
            this.encodingName = encodingName;
            this.InitAlgorithm(this.alphabet, this.padding);
        }

      
        public override string EncodingName
        {
            get { return encodingName; }
        }

        
        public override char[] Alphabet
        {
            get { return (char[])alphabet.Clone(); }
        }

      
        public override bool IsPaddingRequired
        {
            get { return true; }
        }

       
        public override char PaddingCharacter
        {
            get { return padding; }
        }

    }
}