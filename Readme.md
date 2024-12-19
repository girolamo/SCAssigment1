# SCAssignment1

SCAssignment1 is a command-line application written in .NET designed to demonstrate concepts of software engineering and clean coding practices. 
This project was prepared by Michał Grzech as a response to a recruitment assignment.

## Features

- Allows to count the occurrences of each unique word in the files
- Support processing multiple files in paraller fashion
- Error handling for invalid inputs
- The solution is optimized for performance. Perofrmance complexity equals O(N) where N is number of words.

## Prerequisites

- .NET 8 SDK or newer

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/girolamo/SCAssignment1.git
   ```
2. Navigate to the project directory:
   ```bash
   cd SCAssignment1/SCAssignment1
   ```
3. Build the application:
   ```bash
   dotnet build
   ```

## Usage

### *.txt Files preparation
You can add as many .txt files as you want by copying them into the application's main working directory.
You can also modify the existing .txt files.

### Example Input

You can run the program directly from the command line:

#### Run the App

```bash
cd bin/Debug/net8.0
./SCAssignment1
```

**Example session for default content:**
```
1: so
2: do
1: Go
1: I
2: that
2: well
1: thing
1: football
1: you
1: play
```
