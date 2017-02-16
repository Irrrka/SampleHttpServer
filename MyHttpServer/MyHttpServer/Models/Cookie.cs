using System;
using System.Collections.Generic;
using System.Linq;

namespace MyHttpServer.Models
{
    public class Cookie
    {
        private string name;
        private string value;

        public Cookie()
            : this(null, null)
        {}

        public Cookie(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }

        public string Name { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{ this.Name}={this.Value}";
        }
    }
}
