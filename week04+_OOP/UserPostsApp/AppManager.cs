﻿using System;
using UserPostsLibrary;

namespace UserPostsApp
{
    class AppManager
    {
        static void Main(string[] args)
        {
            User user01 = new User("User01");
            User user02 = new User("User02");
            User user03 = new User("User03");
            Post post01 = new Post(user01, "this is user01 first post");
            Post post02 = new Post(user02, "this is user02 first post");
            Post post04 = new Post(user02, "this is user02 second post");
            Post post03 = new Post(user03, "this is user03 first post");

            CommonBoard board = new CommonBoard();
            board.InsertPost(post01);
            board.InsertPost(post02);
            board.InsertPost(post04);
            board.InsertPost(post03);

            board.DisplayAllPosts();
            Console.WriteLine();
            board.DisplayAllPostsChronologically();
            Console.WriteLine();
            board.DisplayPostUsingIComparable();


            board.CreateAccount(user01);
            board.CreateAccount(user02);
            string message01 = " New message From user01 with account";
            string message02 = " New message From user02 with account ";
            string message03 = " New message From user03 with account(1) ";
            string message04 = " New message From user03 with account(2) ";
            board.PostMessage(user01, message01);
            board.PostMessage(user02, message02);
            board.PostMessage(user03, message03);
            board.PostMessage(user03, message04);
            board.PrintAccounts();
            board.DisplayPostUsingIComparable();

            Console.ReadKey();
        }

    }
}
