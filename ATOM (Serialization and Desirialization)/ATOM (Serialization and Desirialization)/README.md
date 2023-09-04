# Atom Data Persistence Exercise

## Overview

This exercise focuses on persisting data by writing text to a file and utilizing JSON serialization and deserialization. The primary goal is to create an application that manages Atom objects with specific attributes such as name, symbol, proton, neutron, and weight.

## Atom Class

### Properties

- **Name**: Represents the name of the atom.
- **Symbol**: A two-letter string representing the atom's symbol.
- **Proton**: The number of protons in the atom's nucleus.
- **Neutron**: The number of neutrons in the atom's nucleus.
- **Weight**: The atomic weight of the atom.

### Constructors

- **Atom()**: Default constructor for serialization purposes.
- **Atom(string name, int proton, int neutron, double weight, string symbol)**: Initializes atom properties with the provided values.

### Methods

- **Parse(string objectData)**: A public method that takes a string and returns an Atom object. It parses the input string into its constituent parts and creates an Atom instance.
- **ToString()**: Overrides the `ToString` method to return a string representation of the Atom object.
- **CreateAtoms()**: A public class method that returns a list of Atom objects, providing a collection of Atom instances to work with.

## Implementation Details

- **Fields**: There are no fields in the Atom class.
- **Properties**: All properties have public getters and setters to facilitate serialization.
- **Constructor**: There are two constructors, a default one, and a user-defined constructor.
  - `Atom()`: Default constructor for serialization.
  - `Atom(string name, int proton, int neutron, double weight, string symbol)`: Constructor that initializes Atom properties.
- **Parse Method**: Parses a string into an Atom object by splitting the string into its constituent parts and initializing the Atom's fields.
- **ToString Method**: Overrides the `ToString` method to provide a string representation of the Atom.
- **CreateAtoms Method**: A public class method that returns a list of Atom objects for working with the data.

## Usage

You can use the Atom class to create, parse, and work with Atom objects. Here's an example of how to use it:

```csharp
// Creating an Atom object
Atom hydrogen = new Atom("Hydrogen", 1, 0, 1.008, "H");

// Parsing a string into an Atom object
string atomData = "Oxygen,O,8,8.159,O";
Atom oxygen = Atom.Parse(atomData);

// Converting an Atom object to a string
string hydrogenInfo = hydrogen.ToString();

// Creating a list of Atom objects
List<Atom> atoms = Atom.CreateAtoms();
