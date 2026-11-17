Необходимый ассет — https://assetstore.unity.com/packages/tools/physics/kinematic-character-controller-99131

Ассет, нужный если версия юнити ниже 6.6 — https://assetstore.unity.com/packages/tools/utilities/serialized-dictionary-243052

Для использования нужно:
1. создать пустую сцену с ExampleCharacter'ом из сцены CharacterPlayground
2. в ExampleCharacterController изменить строчку, где создаётся словарь StateData
3. изменить настройки ExampleCharacterController (добавить элементы для словаря и т.д.)
4. создать пустой объект, накинуть на него Input Manager и Player Input
5. создать InputMap и настроить в нём действия (Move это 3д вектор. Всё остальное — Button'ы)
6. в InputManager'е дать соответствующим действиям такие же имена как в InputMap, и перекинуть в него Play Input
7. перекинуть в Player Input созданный недавно InputMap
