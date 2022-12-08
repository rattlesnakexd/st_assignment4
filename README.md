# st_assignment4

Testing and Test Automation in Game Development using Unity Test Framework:

## Motivation:

A crucial component of game creation is testing. Manual testing is frequently the simple solution. However, manual testing might be quite monotonous. For any game development team, test automation is a very effective tool because of this.

## Introduction:

One of the most crucial tools for quality control is the Unity Test Framework (UTF), which is used to execute automated tests on platforms that are supported by unity as well as in the Editor. Additionally, it is open to all Unity users. Users of Unity may test their code on target platforms including Standalone, Android, and iOS as well as in Edit Mode and Play Mode thanks to the Unity Test Framework. A Unity integration of the open-source NUnit unit testing framework is used by UTF .Net languages.

## Test Runner API:

Unity Test Runner API is very important when it comes to testing in Unity. It enables you to retrieve a list of tests without actually running them that will run in Edit Mode, Play Mode, or both. Several register/unregister callbacks are available for hooking onto at the beginning and end of each test as well as at other levels during the testing cycle, i.e., on the whole test assembly, on each individual test fixture, and on each test class and test. We are given details about the test route that is about to be executed at the beginning of each test and we can see the test results after it is over. A new customisation option allows you to run the UTF on target devices in addition to in Play Mode in the Unity Editor. This is executed prior to building the Player; you can alter the Player construction choices here, such as specifying the build locations and altering the test run parameters.

![alt text](https://github.com/rattlesnakexd/st_assignment4/blob/main/img1.png?raw=true)

## Splitting Built and Run:

Unity Test Framework also gives us the option to split build and run processes while testing. When you wish to run tests on a target device that is not connected to your local workstation, such as if it is in the cloud, splitting the build and run processes is helpful. A little modification is required in the test player to do so. You must first modify the test Player build procedure in order to do this. Disable AutoRun so that the Player won't launch and perform the tests once you create it. Instead of saving it by default to the system's temporary folder, save it to a known place.

![alt text](https://github.com/rattlesnakexd/st_assignment4/blob/main/img2.png?raw=true)
