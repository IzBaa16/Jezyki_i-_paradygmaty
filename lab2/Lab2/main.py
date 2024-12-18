def multiplication(matrix_one, matrix_two):
    matrix_one = parse_matrix(matrix_one)
    matrix_two = parse_matrix(matrix_two)

    if len(matrix_one[0]) != len(matrix_two):
        return "Podane macierze są złe do mnożenia"
    result = [[sum(matrix_one[i][k] * matrix_two[k][j] for k in range(len(matrix_two))) for j in range(len(matrix_two[0]))] for i in range(len(matrix_one))]
    return result

def transpose(matrix):
    matrix = parse_matrix(matrix)
    result = [[matrix[j][i] for j in range(len(matrix))] for i in range(len(matrix[0]))]
    return result

# Przykładowe macierze
A = "[[1, 2], [3, 4]]"
B = "[[5, 6], [7, 8]]"

# Sprawdzenie
print("Dodawanie A + B:", addition(A, B))
print("Mnożenie A * B:", multiplication(A, B))
print("Transpozycja A:", transpose(A))


# Zad 3

data = [42, "Paradygmaty", (1, 2), 3.14, "Późno", (1, 2, 3, 4), "Już", 420, [1, 2], 999]

print("Zad 3")
max_num = None
numbers = list(filter(lambda x: isinstance(x, (int, float)), data))
if len(numbers) > 0:
    max_number = max(numbers)

print("Największa liczba:", max_num)

longest_string = None
strings = list(filter(lambda x: isinstance(x, str), data))
if len(strings) > 0:
    longest_string = max(strings, key=len)

print("Najdłuższy napis:", longest_string)

largest_tuple = None
tuples = list(filter(lambda x: isinstance(x, tuple), data))
if len(tuples) > 0:
    largest_tuple = max(tuples, key=len)

print("Krotka o największej liczbie elementów:", largest_tuple)


# ZAD 4
from functools import reduce

def parse_matrix(matrix_str):
    return eval(matrix_str, {"__builtins__": None}, {})

def operation_on_matrix(matrix_a, matrix_b, operation):
    if not (len(matrix_a) == len(matrix_b) and len(matrix_a[0]) == len(matrix_b[0])):
        raise ValueError("Macierze muszą mieć te same wymiary do wykonania operacji.")

    result = []

    for i in range(len(matrix_a)):
        row = []
        for j in range(len(matrix_a[0])):
            element_result = eval(f"{matrix_a[i][j]} {operation} {matrix_b[i][j]}")
            row.append(element_result)
        result.append(row)

    return result

def combine_matrices(matrices, operation): # Musiałem rozpisać już na 2 funkcję. Za dużo się działo w jednej
    parsed_matrices = [parse_matrix(matrix) for matrix in matrices]

    result_matrix = reduce(lambda x, y: operation_on_matrix(x, y, operation), parsed_matrices)
    return result_matrix


A = "[[1, 2], [3, 4]]"
B = "[[5, 6], [7, 8]]"
C = "[[2, 2], [2, 2]]"
matrices = [A, B, C]

operation = "+"  # Można wpisać tutaj +-*/

# Wywołanie funkcji
result_matrix = combine_matrices(matrices, operation)

print("Zad 4: Wynikowa macierz po operacji:", result_matrix)