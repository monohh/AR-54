using UnityEngine;
using System.Collections;

namespace AR_54.Common.Test
{
    public class EchoChamber
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        /// <summary>
        /// Trivial method to verify correct test suite functionality.
        /// Returns the input string in all uppercase.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ShoutLoudly(string input)
        {
            return input.ToUpper();
        }
    }
}
