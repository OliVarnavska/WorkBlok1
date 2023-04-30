# Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## **Например**

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

## ***Напишем программу решения задачи:***

1. Сначала пишем запрос пользователю ввести количество элементов массива
2. Вторым шагом присваем первый массив будет состоять из колличества элементов введенных пользователем
3. второй массив (для записи результата) будет равен по длине перому массиву
4. Затем записываем метод заполнения массива пользователем 
5. Затем пишем метод вывода массива на экран
6. Пишем третий массив нахождения результата. В данном масиве определяем:
  + если длинна элемемента первого массива равна или меньше трех;
  + тогда записываем этот элемент во второй массив;
  + повторяем дейсвия до тех пор, пока не переберем все элементы первого массива;
  + если элементов длинной меньше или равной 3 нет, тогда выводим результат, что таких элементов нет.
7. С помощью вызова метода заполняем первый массив
8. С помощью вызова метода выводим первый массив на экран 
9. Выводим результат вызовом метода нахождения результата

![Ура! Ура! Ура](https://www.gtrk-vyatka.ru/uploads/posts/2022-05/1651745085_fireworks-g58f83d1bb_1920.jpg)





