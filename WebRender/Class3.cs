using System;
using System.Collections.Generic;
using System.Text;

namespace WebRender
{
    class ParagraphTag : Tag
    {
        private String text;

        public ParagraphTag(String text) => this.text = text;

        public string getText() => this.text;
    }
}
