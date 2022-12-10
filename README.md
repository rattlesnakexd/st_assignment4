# st_assignment4

Testing and Test Automation in Game Development using Unity Test Framework:

## Motivation:

A crucial component of game creation is testing. Manual testing is frequently the simple solution. However, manual testing might be quite monotonous. For any game development team, test automation is a very effective tool because of this.

## Introduction:

One of the most crucial tools for quality control is the Unity Test Framework (UTF), which is used to execute automated tests on platforms that are supported by unity as well as in the Editor. Additionally, it is open to all Unity users. Users of Unity may test their code on target platforms including Standalone, Android, and iOS as well as in Edit Mode and Play Mode thanks to the Unity Test Framework. A Unity integration of the open-source NUnit unit testing framework is used by UTF .Net languages.

## What is Unity Engine?

Unity is frequently described as a potent gaming engine that aids in the creation of video games, animations, and virtual reality applications. Even movie animations can now be created on Unity, which originally served just as a framework for the development of video games. Since entering the Internet and the gaming industries, Unity has established numerous standards for its rivals.

## Key Features:

Unity's unique attributes are what give it its strength and popularity. Each of those is explained in more detail in the section on Unity testing that follows.

### Game development for cross platforms:

Cross-platform development is popular among those who are working on it, whether it be in game creation, mobile app testing, or both. The concept of "coding once and running on various platforms" helps developers and testers save time, money, and labor-intensive, manual effort.
When developers write one code for everyone, Unity does bring up a few issues.

1. Keyboards and Touch
2. Mouse click and Touch.
3. PC and mobile sensors
4. CPU management

### Multiple platform support:

Unity has opened the road into numerous industries that require animation, graphics, gaming, etc., as was discussed in the preceding sections. Unity is a better place to start if you're a beginner because of its widespread acceptance. It would aid in the creation of a wide range of apps and the exploration of numerous career opportunities because its knowledge could be applied to the various platforms that Unity supports.

## Test Runner API:

Unity Test Runner API is very important when it comes to testing in Unity. It enables you to retrieve a list of tests without actually running them that will run in Edit Mode, Play Mode, or both. Several register/unregister callbacks are available for hooking onto at the beginning and end of each test as well as at other levels during the testing cycle, i.e., on the whole test assembly, on each individual test fixture, and on each test class and test. We are given details about the test route that is about to be executed at the beginning of each test and we can see the test results after it is over. A new customisation option allows you to run the UTF on target devices in addition to in Play Mode in the Unity Editor. This is executed prior to building the Player; you can alter the Player construction choices here, such as specifying the build locations and altering the test run parameters.

![alt text](https://github.com/rattlesnakexd/st_assignment4/blob/main/img1.png?raw=true)

## Splitting Build and Run:

Unity Test Framework also gives us the option to split build and run processes while testing. When you wish to run tests on a target device that is not connected to your local workstation, such as if it is in the cloud, splitting the build and run processes is helpful. A little modification is required in the test player to do so. You must first modify the test Player build procedure in order to do this. Disable AutoRun so that the Player won't launch and perform the tests once you create it. Instead of saving it by default to the system's temporary folder, save it to a known place. Here is a simple example.

Build:

![alt text](https://github.com/rattlesnakexd/st_assignment4/blob/main/img2.png?raw=true)

Run:

![alt text](https://github.com/rattlesnakexd/st_assignment4/blob/main/img3.png?raw=true)

## Integrating Unity test framework with LambdaTest:

A cross-browser testing platform called LambdaTest is accessible online. It makes it easier to test web and mobile applications manually and automatically. The support for real devices, well-known languages, and frameworks for simple testing are the key advantages of using LambdaTest for your Unity testing. We don't have to spend a lot of money on expensive systems or devices because we can finish Unity testing rapidly without doing so. Mobile games created using Unity are no different. The tester can combine the capabilities of UTF (Unity test framework) with LambdaTest's devices with the help of the Unity test framework in order to release a mobile application that is free of bugs.

## Example:

The testing that we did was on a simple open-source unity game. The game comprised of a player and an army of skeletons who attack the player. In result of the attack, the health of the player is reduced. We tested this case to check whether the the damage is causing any reduction in the health.

The test file can be accessed from the following path: Unity Test Example -> Assets -> Scenes -> Tests
