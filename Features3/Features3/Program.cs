// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class User
{
    public int ID { get; set; }
    public string Username { get; set; }
    public List<User> Followers { get; set; }
    public User(int id, string username)
    {
        ID = id;
        Username = username;
        Followers = new List<User>();
    }

    public void Follow(User user)
    {
        if (!Followers.Contains(user))
        {
            Followers.Add(user);
            user.FollowBack(this);
        }
    }

    public void FollowBack(User user)
    {
        if (!Followers.Contains(user))
        {
            Followers.Add(user);
        }
    }

    public void PrintFollowers()
    {
        Console.WriteLine($"Followers of {Username}:");
        foreach (var follower in Followers)
        {
            Console.WriteLine(follower.Username);
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create users
        User user1 = new User(1, "Jc");
        User user2 = new User(2, "Jemen");
        User user3 = new User(3, "Dhuke");

        // User1 follows User2
        user1.Follow(user2);

        // User2 follows User3
        user2.Follow(user3);

        // User3 follows User1
        user3.Follow(user1);

        // Print followers of each user
        user1.PrintFollowers();
        user2.PrintFollowers();
        user3.PrintFollowers();
    }
}
