﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkers
{
    public interface IBoard
    {
        IPiece Occupant(int position);
        IEnumerable<int> Pieces(Color color);
        void Move(IPiece piece, int destination);
        void RemoveCapturedPieces();
        void Promote(IPiece piece);
    }
    public enum Color { Black, White }
    public enum Status { Captured, Active }
    public interface IPiece
    {
        IEnumerable<int> NormalMoves(IBoard board);
        IEnumerable<int> CapturingMoves(IBoard board);
        Status Status { get; }
        Color Color { get; }
        int Position { get; }
        void Move(int destination);
    }
    public interface IPlayer
    {
        string Name { get; }
        (int,int) GetMove();
    }
    public interface IReferee
    {
        IPlayer Winner();
        bool IsDraw();
        void Play();
    }
    public class IllegalMoveException : ApplicationException { }

    public class Board : IBoard
    {
        Piece[] white, black;
        private Piece[] PiecesWithPositions(Color c, params int[] positions)
        {
           return positions.Select(v => new Piece(c,v)).ToArray(); 
        }
        public Board()
        {
            white = PiecesWithPositions(Color.Black, 1,2,3,4,5,6,7,8,9,10,11,12);
            black = PiecesWithPositions(Color.White,21,22,23,24,25,26,27,28,29,30,31,32);
        }

        public IEnumerable<int> Pieces(Color color)
        {
            if (color == Color.White){
                return white.Select(x => x.Position);
            }
            return black.Select(x => x.Position);
        }
        public void Move(IPiece piece, int destination)
        {
            throw new NotImplementedException();
        }

        public IPiece Occupant(int position)
        {
            throw new NotImplementedException();
        }

        public void Promote(IPiece piece)
        {
            throw new NotImplementedException();
        }

        public void RemoveCapturedPieces()
        {
            throw new NotImplementedException();
        }
    }

    public class Piece : IPiece
    {
        public Piece(Color c, int pos)
        {
            Status = Status.Active;
            Position = pos;
            Color = c;
        }
        public virtual Status Status { get; set; }
        public virtual Color Color { get; private set; }
        public virtual int Position { get; private set; }
        //public virtual Status Status => throw new NotImplementedException();

        //public virtual Color Color => throw new NotImplementedException();

        //public virtual int Position => throw new NotImplementedException();

        public virtual IEnumerable<int> CapturingMoves(IBoard board)
        {
            throw new NotImplementedException();
        }

        public virtual void Move(int destination)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<int> NormalMoves(IBoard board)
        {
            throw new NotImplementedException();
        }
    }
    public class King : Piece
    {
        public King(Color c, int p) : base(c, p){}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");    
        }
    }
}
