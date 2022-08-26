# Reference Trainings

This repository contains materials (slides, scripts, demo app, and other code samples) used for various workshops, tutorials, and training sessions around the themes of TDD, containers, Docker and software engineering.

# Table Of Contents

- [Using the GitHub Repository](#using-the-github-repository)
- [Test Driven Development](#test-driven-development)   

# Using the GitHub Repository

To get started based on this repository, you need to get a copy locally. You have three options: fork, clone, or download. Most of the time, you probably just want to download.

You should **download the repository**, unblock the zip file, and extract it to a new folder if you just want to play with the project or you wish to use it as the starting point for an application.

You should **fork this repository** only if you plan on submitting a pull request. Or if you'd like to keep a copy of a snapshot of the repository in your own GitHub account.

You should **clone this repository** if you're one of the contributors and you have commit access to it. Otherwise you probably want one of the other options.
 
# Test Driven Development

### What is TDD?

> Test-driven development (TDD) is an evolutionary approach to development
which combines test-first development, where you write a test before you write
just enough production code to fulfil that test, and refactoring. In other words,
it’s one way to think through your requirements
or design before you write your functional code.

## How?

The *first* thing you need to *understand*
is that writing code following TDD (*discipline*)
is a (*slightly*) different approach from simply
diving into solving the problem (*without a test*).

When reading about TDD you will usually see the expression:
"***Red, Green, Refactor***":

![TDD Cycle: Red, Green, Refactor](https://cdn-media-1.freecodecamp.org/images/6k9ojiN7VEFUUNKroUU62gZVf2pzzPnC5IbV)

What this means is that TDD follows a **3-step process**:

1. ***Write a Failing Test*** - Understand the (user)
requirements/story well enough to write a test for what you expect.
(_the test should **fail** initially - hence it being "Red"_)

2. ***Make the (failing) Test Pass*** - Write (*only*) the code you need
to make the (*failing*) test pass, while ensuring your existing/previous tests
all still pass (*no regressions*).

3. ***Refactor the code you wrote*** - Take the time to tidy up the code
*you* wrote to make it simpler
(*for your future self or colleagues to understand*)
before you need to ship the current feature.
