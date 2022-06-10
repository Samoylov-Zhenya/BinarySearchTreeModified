## BinarySearchTreeModified

Это модифицированное бинарное дерево.

В обычном дереве когда добавляешь два одинаковых элемента дерева создаются две одинаковые ветки, а в этом просто находим такой же элемент и увеличиваем количество.

## Рассмотрим пример:

К нам приходит массив {5,2,4,21,15,42,5,4,4,21,21,21,21}

Обычное дерево создаст столько же элементов 13 выведем в постфиксном виде.
№ Key

№ 0 4

№ 1 4

№ 2 4

№ 3 2

№ 4 5

№ 5 15

№ 6 21

№ 7 21

№ 8 21

№ 9 21

№ 10 42

№ 11 21

№ 12 5

А модифицированный всего 6.

№ Key Count

№ 0 2 1

№ 1 4 3

№ 2 5 2

№ 3 15 1

№ 4 21 5

№ 5 42 1

## Где лучше использовать

Если у вас большие объемы информации где повторяются значения и мало памяти.

Анализ данных:

Список людей с городом рождения и вам нужно найти самый популярный город.

Хранить товар в БД можно быстро найти количество по артикулу.

## Преимущества

Скорость :star: :star: :star: :star: 4/5

Мин сложность алгоритма O(log(1)) макс O(log(N))

Легкий в понимании :star: :star: :star: :star: :star: 5/5

Экономит память :star: :star: :star: :star: 4/5