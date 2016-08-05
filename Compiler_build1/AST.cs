using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Compiler_build1
{
    public class AST
    {
        protected Token token;
        protected List<AST> children;

        public AST() {; }
        public AST(Token t) { token = t; }
        public AST(int tokenType) { this.token = new Token(tokenType); }

        public int getNodeType() { return token.type; }

        public void addChild(AST t)
        {
            if (children == null)
            {
                children = new List<AST>();
            }
            children.Add(t);
        }
        public bool isNil() { return token == null; }
        /*public string toString() { return token.text; }
        public string toStringTree()
        {
            if (children == null || children.Count() == 0)
            {
                return this.toString();
            }
            string local = "";
            if (!isNil())
            {
                local += "(";
                local = this.toString() + local;
                local += " ";
            }
            for (int i = 0; children != null && i < children.Count(); i++)
            {
                AST t = children[i];
                if (i > 0)
                {
                    local += " ";
                }
                local = local + t.toStringTree();
            }
            if (!isNil())
            {
                local += ")";
            }
            return local;
        }*/
    }
}