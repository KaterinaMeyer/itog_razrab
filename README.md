# itog_razrab
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Программа начинается с вывода сообщения пользователю и считывания введенных данных. Затем происходит итерация по элементам массива и проверка длины строки. Если строка удовлетворяет условию, она добавляется в новый массив. Наконец, новый массив выводится на экран.
В программе использован метод Array.FindAll, который позволяет нам фильтровать массив с помощью лямбда-выражения. Мы передаем в этот метод лямбда-выражение str => str.Length <= 3, которое определяет условие для отбора строк длиной меньше или равной 3 символам.