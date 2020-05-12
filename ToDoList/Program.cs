using System;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList{
  public class Program{
  
    public static void StartGame(){
      Console.WriteLine("Welcome to the To Do List");
      Console.WriteLine("Would you like to add an item to your list or view your list? (Add/View/back)");
      string userInput = Console.ReadLine();
      userInput.ToLower();
      if(userInput == "view"){
        List<Item> newList = Item.GetAll();
        if(newList.Count > 0){
          foreach(Item item in newList){
          Console.WriteLine(item.Description);
          }
          StartGame();
        }else{
          Console.WriteLine("Todolist is empty list");
        }
        
      }else if(userInput == "add"){
        Console.WriteLine("Please enter the description for the new item.");
        string description = Console.ReadLine();
        Item newItem = new Item(description);
        StartGame();
      }else{
        Console.WriteLine("Good Bye");
      }
    }
    public static void Main(){
      StartGame();
    } 
  }
}