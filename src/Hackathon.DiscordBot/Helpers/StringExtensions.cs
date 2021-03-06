﻿using System;
using System.Linq;

namespace Hackathon.DiscordBot.Helpers
{
    public static class StringExtensions
    {
        public static string CapitalizeFirstLetter(this string input)
        {
            return input switch
            {
                null => throw new ArgumentNullException(nameof(input)),
                ""   => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
                _    => input.First().ToString().ToUpper() + input.Substring(1)
            };
        }
    }
}
