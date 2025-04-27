using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace StringProcessingApp
{
    public class StringProcessing
    {
        private string inputString;
        private string outputString;
        private int n;

       
        public string InputString
        {
            get => inputString;
            set
            {
               
                if (!Regex.IsMatch(value, @"^[A-Z]{1,40}$"))
                    throw new ArgumentException("Input must be 1-40 uppercase letters only.");
                inputString = value;
            }
        }

       
        public int N
        {
            get => n;
            set
            {
             
                if (value < -25 || value > 25)
                    throw new ArgumentOutOfRangeException("N must be between -25 and 25.");
                n = value;
            }
        }

        
        public StringProcessing(string s, int n)
        {
            InputString = s;
            N = n;
        }

     
        public void Encode()
        {
            outputString = new string(inputString.Select(c =>
            {
                
                int shifted = ((c - 'A') + n + 26) % 26 + 'A';
                return (char)shifted;
            }).ToArray());
        }

       
        public void Decode()
        {
            outputString = new string(inputString.Select(c =>
            {
               
                int shifted = ((c - 'A') - n + 26) % 26 + 'A';
                return (char)shifted;
            }).ToArray());
        }

        
        public string Print()
        {
            return outputString;
        }

       
        public int[] InputCode() => inputString.Select(c => (int)c).ToArray();

        
        public int[] OutputCode() => outputString.Select(c => (int)c).ToArray();

        
        public string Sort()
        {
            char[] sorted = inputString.ToCharArray();
            Array.Sort(sorted);
            return new string(sorted);
        }

      
        public string HashOutput()
        {
            if (string.IsNullOrEmpty(outputString))
                throw new InvalidOperationException("No encoded string to hash.");

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(outputString));
                return BitConverter.ToString(hashBytes).Replace("-", "");
            }
        }
    }
}
