# Observer Pattern in C# using IObservable and IObserver Interfaces

This repository contains a demonstration of the Observer Pattern implemented in C#. The Observer Pattern is a design pattern where an object, called the subject, maintains a list of its dependents, called observers, and notifies them of state changes, usually by calling one of their methods.

## Table of Contents

## Introduction

The project demonstrates a simple implementation of the Observer Pattern using C#. It includes:
- An `ICelebrity` interface to represent the subject.
- A `Celebrity` class that implements `ICelebrity`.
- A `CelebrityNotifier` class that implements `IObservable<T>`.
- A `CelebrityObserver` class that implements `IObserver<T>`.

Observers are notified whenever the `Flag` property of a `Celebrity` object changes.

## Getting Started

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 3.1 or later)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/stevsharp/ObserverPattern.git

Classes
ICelebrity
An interface that represents a celebrity with a Name and a Flag property.

Celebrity
A class that implements the ICelebrity interface and notifies observers when the Flag property changes.

CelebrityNotifier
A class that implements IObservable<CelebrityFlagChangedEventArgs> and manages a list of observers. It notifies them of any changes.

CelebrityObserver
A class that implements IObserver<CelebrityFlagChangedEventArgs> and defines how to handle notifications from the CelebrityNotifier.

### Contributing
Contributions are welcome! Please fork this repository, create a feature branch, make your changes, and submit a pull request. For major changes, please open an issue first to discuss what you would like to change.

### Fork the repository
Create your feature branch (git checkout -b feature/AmazingFeature)
Commit your changes (git commit -m 'Add some AmazingFeature')
Push to the branch (git push origin feature/AmazingFeature)
Open a pull request
License
This project is licensed under the MIT License - see the LICENSE file for details.
