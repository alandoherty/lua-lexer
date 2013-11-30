using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LuaParser
{
    public partial class Main : Form
    {
        private Lexer lexer = null;
        private bool textChanged = false;

        public Main()
        {
            InitializeComponent();
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
        }

        private void parseTimer_Tick(object sender, EventArgs e)
        {
            if (textChanged)
            {
                textChanged = false;

                if (lexer != null) { lexer.Dispose(); }
                lexer = new Lexer(richText.Text);
                lexer.TokenizeAsync(new Action<LexerResult>(delegate(LexerResult r)
                {
                    foreach (Token t in r.Tokens)
                    {
                        //Console.Write(t.Value);
                    }
                    //Console.WriteLine();
                }));
            }
        }
    }
}
