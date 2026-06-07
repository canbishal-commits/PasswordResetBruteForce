# Password Reset Brute Force Attack

Course Assignment

## Version 0.1

- Created WinForms project
- Created folder structure
- Added service classes
- Created initial GUI

## Version 0.2

### Implemented

- Password generation
- SHA256 hashing
- Static salt
- Password display
- Hash displaygit 

## Version 0.3

### Implemented

- Password validation class
- Brute force combination generator
- Recursive generation logic
- Combination lengths from 1 to 6
- Generator testing completed

## Version 0.4

### Implemented

- Single-thread brute force attack
- Password recovery functionality
- Found password output
- Elapsed time measurement
- AttackManager service

## Version 0.5

### Implemented

* Converted brute force attack to asynchronous execution using Task.Run
* Added Start Attack and Stop Attack functionality
* Implemented CancellationTokenSource for attack cancellation
* Prevented GUI freezing during brute force execution
* Added multi-threaded brute force attack using multiple Tasks
* Divided search space among threads using character prefixes
* Implemented immediate thread termination after password discovery
* Added current password attempt display
* Added progress bar and progress tracking
* Added single-thread vs multi-thread performance comparison
* Added execution time comparison and winner display
* Improved password search reliability and thread synchronization
* Updated password generation to 4–5 characters
* Updated brute force generator to search lengths 1–6
* Finalized UML diagram
* Completed testing and project documentation

### Final Features

* Password generation
* SHA256 hashing with static salt
* Password validation
* Brute force password recovery
* Single-thread attack
* Multi-thread attack
* Start/Stop controls
* Progress indicator
* Current attempt display
* Elapsed time display
* Found password output
* Performance comparison
* UML class diagram
* Windows Forms graphical interface
