﻿using System;
using System.Collections.Generic;

namespace Compiler_build1
{
    public class ExprNode : AST
    {
        public int evalType;
        public ExprNode(Token t) : base(t) {; } 
    }
    public class IntNode : ExprNode
    {
        public IntNode(Token t) : base(t) { this.evalType = (int)tok_names.Int; }
    }
    public class CharNode : ExprNode
    {
        public CharNode(Token t) : base(t) { this.evalType = (int)tok_names.Char; }
    }
    public class IdNode : ExprNode
    {
        public IdNode(Token t) : base(t) { this.evalType = (int)tok_names.Id; }
    }
    public class AssignNode : ExprNode
    {
        public AssignNode(Token t) : base(t) { this.evalType = (int)tok_names.Assign; }
    }
    public class WhileNode : ExprNode
    {
        public WhileNode(Token t) : base(t) { this.evalType = (int)tok_names.While; }
    }
    /*public class ReturnNode:ExprNode
    {
        public ReturnNode(Token t) : base(t) { this.evalType = (int)tok_names.Return; }
    }*/
    public class IfStmt : ExprNode
    {
        public IfStmt(Token t) : base(t) { this.evalType = (int)tok_names.If; }
    }
    public class ElseStmt : ExprNode
    {
        public ElseStmt(Token t) : base(t) { this.evalType = (int)tok_names.Else; }
    }
    public class BlockNode : ExprNode
    {
        public BlockNode(Token t) : base(t) { this.evalType = (int)tok_names.Block; }
    }
    public class FuncNode : ExprNode
    {
        public FuncNode(Token t) : base(t) { this.evalType = (int)}
    }
    public class CodeGen
    {
        protected Token token;
        protected List<AST> children;

        public CodeGen() {; }        

        public void addChild(AST t)
        {
            if (children == null)
            {
                children = new List<AST>();
            }
            children.Add(t);
        }
    }
    public class OperatNode : ExprNode
    {
        public OperatNode (Token t,int type) : base(t) { this.evalType = type; }
    }
}
