
# Sprite-Control - C# Backend Server with State Machine

## Overview

`sprite-control` is a C# backend server designed to manage an avatar's actions, ultimate abilities (ulti), and scene states through a state machine. The server is built to facilitate dynamic control over avatars, enabling them to transition between various states while controlling key aspects like abilities and interactions within the scene.

The state machine enables smooth transitions and management of avatar states, such as idle, movement, attacks, and ultimate abilities. It also manages the scene, ensuring that interactions are handled appropriately.

## Features

- **Avatar State Management**: Control and transition through various avatar states (e.g., idle, moving, attacking, etc.).
- **Ultimate Ability (Ulti) Control**: Manage the state and activation of the avatar's ultimate ability.
- **Scene Control**: Manage scene transitions, ensuring avatars behave correctly depending on the current scene.
- **State Machine**: A robust state machine to govern avatar behavior, state transitions, and ability activation.

## Prerequisites

- .NET 6.0 (or higher)
- C# programming knowledge
- Visual Studio (recommended for development)
- A basic understanding of state machines

## Installation

### Clone the Repository

```bash
git clone https://github.com/chevp/sprite-control.git
cd sprite-control
```

### Build the Project

1. Open the `sprite-control` solution in Visual Studio or any compatible C# IDE.
2. Restore dependencies and build the solution.

```bash
dotnet restore
dotnet build
```

### Run the Server

You can run the server with the following command:

```bash
dotnet run
```

This will start the backend server, initializing the state machine and setting up avatar control.

## Usage

### Avatar Control

The state machine allows you to control an avatar's states. Below are the key states and transitions:

- **Idle State**: The avatar is stationary and idle.
- **Move State**: The avatar can move around the scene.
- **Attack State**: The avatar can perform an attack.
- **Ultimate State (Ulti)**: The avatar can use its ultimate ability. Once activated, the state transitions to "Cooldown" after execution.

To change an avatar's state, you can interact with the API to trigger state transitions, for example:

```csharp
AvatarStateMachine.ChangeState(AvatarState.Moving);
```

### Scene Control

Scenes can be changed dynamically based on avatar actions or other factors. Use the following API call to change scenes:

```csharp
SceneManager.ChangeScene("NewScene");
```

### Ultimate Ability (Ulti)

The ultimate ability has a cooldown and can be triggered using the following command:

```csharp
AvatarStateMachine.UseUlti();
```

Once used, the state machine handles the cooldown and ensures that the avatar cannot use the ulti again until it's available.

## Architecture

The system uses a state machine pattern for managing the avatar's state. The core components include:

- **AvatarStateMachine**: A class that handles transitions between different avatar states.
- **State Enum**: An enumeration that defines various avatar states.
- **UltiManager**: A class responsible for managing the ulti ability, including activation and cooldown.
- **SceneManager**: A class responsible for managing scene transitions.

### Example of the State Machine

```csharp
public class AvatarStateMachine
{
    private IAvatarState currentState;

    public void ChangeState(IAvatarState newState)
    {
        currentState?.Exit();
        currentState = newState;
        currentState?.Enter();
    }

    public void UseUlti()
    {
        if (currentState is IUltiState ultiState)
        {
            ultiState.ActivateUlti();
        }
    }
}
```

## Contributing

Contributions are welcome! If you'd like to contribute to the `sprite-control` project, please fork the repository and submit a pull request with your changes.

To contribute:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Commit your changes (`git commit -am 'Add new feature'`).
4. Push to the branch (`git push origin feature-name`).
5. Create a new Pull Request.

## License

`sprite-control` is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

