# UtilityAI
Trying create AI from Unity UtilityAI

Test for AI Agate:
Instruction

Learn two AI Framework/Concept, and check some of its implementation in Unity
> Behaviour Tree
> Utility AI
Create simple AI based on needs and activity
> Agent have needs: Hunger, Bladder, Boredom
> Agent will do action in 3 different spot based on what it needs
    Eating to lower Hunger
    Toilet to lower Bladder
    PlayGame to lower Boredom
> The needs meter will lower rapidly when doing Action in corresponding spot
> Hunger and Boredom will increase slowly as time passed
> Action in Eating spot will increase Bladder rapidly
Implementation Requirement
> Agent movement and pathfinding implemented using Unity NavMesh system
> There must be obstacles between 3 spot to make more complex pathfinding (using NavMeshObstacle)
> Agent state is shown in UI using NGUI (needs meter for Hunger, Bladder, Boredom)
> Implementation of decision making AI doesn't have specific limitation, use any of AI framework and/or library as needed
> Use MVC paradigm as much as possible in implementation
useful URL:
https://unity3d.com/learn/tutorials/topics/navigation
https://github.com/Bartvanderkruys/utility-ai
https://github.com/codecapers/Fluent-Behaviour-Tree
http://www.what-could-possibly-go-wrong.com/fluent-behavior-trees-for-ai-and-game-logic/
https://www.toptal.com/unity-unity3d/unity-with-mvc-how-to-level-up-your-game-development
