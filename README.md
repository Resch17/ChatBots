# ChatBots

## A C# Exercise

## Phase 1

1. Fork this repo and clone your forked repo down to your computer.
1. Run the application. Try out each chatbot to see what it does.
1. Read through the code. Write comments to describe what each class and method do.
   * Save the `DuckDuckGoBot` for last. It is very complex. Make sure you [timebox](https://www.agilealliance.org/glossary/timebox) your exploration of this class to no more than 30 minutes for now. You can always come back to it later.

## Phase 2

Add a chatbot that shouts at the user. It should repeat what the user says to it, but in upper case with an `!` at the end.

> **NOTE:** If the message the user types ends with punctuation (`.`, `?` or `!`) that punctuation should be replaced.

## Phase 3

Add a chatbot that will remember everything the user has said and output it each time the user says something new.

> **For Example:** If the user's previous three messages have been `Moe`, `Larry`, `Curly` and the user enters `Shemp`, the chatbot should respond with:  
> `Moe`  
> `Larry`  
> `Curly`  
> `Shemp`  

## Phase 4

Add a chatbot that add numbers. The chatbot should expect the user to enter a series of numbers separated by one or more spaces and return the result of adding the numbers together.

> **For Example:** If the user enters `1 2 3` the chatbot should respond with `6`.

> **NOTE:** Make sure to handle errors in a way that doesn't crash the program, will inform the user as to what's happening and will not end the chat.

## PHase 5

Modify the chatbot from **Phase 4** to perform `subtraction`, `multiplication` and `division`.

The chatbot should expect the user import to start with the particular math operation and then be followed by a series of numbers.

> **For Example:**

```text
> subtract 20 1 2
MathBot: 17
```

## Phase 6

Update the code in the `Program` class to allow the user to choose another chat bot after they have finished chatting. The user should be able to select a new bot or to choose to end the program.

## Phase 7

Create a chatbot that will use ADO<span>.</span>NET to search the PoKi database. The user should be able to input a search term and the bot should return a list of poems that contain that term.