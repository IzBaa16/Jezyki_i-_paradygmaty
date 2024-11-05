# def podzielPaczki(wagi, max_waga):
#     for waga in wagi:
#         if waga> max_waga:
#             raise ValueError(f"Paczka o wadze {waga} przekracza max dozwoloną wagę kursu ({max_waga})")
#
#     wagi_sorted = sorted(wagi, reverse= True)
#     kursy = []
#
#     for waga in wagi_sorted:
#         dodano = False
#         for kurs in kursy:
#             if sum(kurs) + waga <= max_waga:
#                 kurs.append(waga)
#                 dodano = True
#                 break
#
#         if not dodano:
#             kursy.append([waga])
#
#     return len(kursy), kursy
#
#
# wagi = [20, 5, 8, 15, 10, 10, 7]
# max_waga = 25
#
#
# #print(podzielPaczki(wagi, max_waga))
#
#
# liczba_kursow, kursy = podzielPaczki(wagi, max_waga)
# for i, kurs in enumerate (kursy, 1):
#     print(f"Kurs {i}: {kurs} - suma wagi: {sum(kurs)} kg")


#zad 2
def bfsTask(graph, start, end):
graph = {
    '1' : ['2', '3', '5'],
    '2' : ['1', '4'],
    '3' : ['1', '5', '6'],
    '4' : ['2', '7'],
    '5' : ['1', '3', '7'],
    '6' : ['3', '8'],
    '7' : ['4', '5', '8'],
    '8' : ['6', '7'],
}

print(bfsTask(graph, '1', '7'))