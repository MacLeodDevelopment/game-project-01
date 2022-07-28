# Assignment 01

## Aims:

* Gain confidence working in Blazor and adding new content to the client app.
  * Understand the basics of how dependency injection works in Blazor.
* Start thinking about how the application might work and what it will need to do. What operations it might need to do to allow us to play a game?
* Add some basic functionality to get us on the way to a walking skeleton (with a stretch to actually get one working!). 

## Expected Outcomes:

* An initial basic UI app which talks to the API.
* An initial basic API which can create a new game. 
* Stretch: A walking skeleton which allows us to start and finish a game with either a victory or a defeat. 

## Tasks

Take the Blazor app and create/modify the existing so that we have the following:

### Client - Home Screen

The home screen should contain:

* A title and a description.
* A Version Number component (see below).
* A button which takes us to a new route (`/new-game`) and loads a Game Options component (see below).

### Client - Version Number Component

This should be a Blazor Component (i.e. not a razor page) on the home page which shows:

* The version number of the client app (this will require a service object to inject into the component to encapsulate the version logic). There should be corresponding tests for this service. 
* The version number of the API (this can use the same service object unless you think it should use a different one? Have a think about that. It's doing the same job but it'll have to do it in a different way). 

### Client - Game Options Component

* Add a Game Options component which allows us to start a new game. This will need to:
  * Perform a create operation in the API. How might we do this? 

### Client - Other Items To Do

* Get rid of the boilerplate components that got generated when the app was created, e.g. the counter component. 
* Add a pretty-ish style. Have a look for something suitably nerdy and dungeon-like. 

API - Things to think about:

* What operations might we need? Create or start new game? What else? 
	
* We want to invoke these operations via ReST, but the logic for them should not live in the controllers. How might we structure the application to allow this? Where will the logic live?
	
* If we want to create a "walking skeleton" how might we do it? It will need to allow us to start and finish a game with an outcome.
  * If this was a more business-related application, e.g. something which accepted data or commands and did something else, what might you need to do to create a walking skeleton? 

* Add to the Miro board any ideas you can think of. 

* Make sure you think about the API as the application itself. i.e. the UI is totally optional. You should be able to play the game by talking to the API just using ReST. 

* At this stage don't worry about how the game plays or anything else like that. We'll come to that later.

* If it makes sense to draw some squiggly boxes to represent what's happening and where the data is flowing, do it!