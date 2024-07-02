# Observer Pattern in C#

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
