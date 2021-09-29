"""
Algoritmo para gerar a ordem de chegada de pilotos na temporada de 2021 da Formula 1.
"""

from itertools import permutations

lista_pilotos = [
    'Verstappen',
    'Hamilton',
    'Bottas',
    'Norris',
    'Perez',
    'Leclerc',
    'Sainz',
    'Ricciardo',
    'Gasly',
    'Alonso',
    'Ocon',
    'Vettel',
    'Stroll',
    'Tsunoda',
    'Russell',
    'Latifi',
    'Raikkonen',
    'Giovinazzi'
]

n_pos = int(input("Insira o número de posições a ser geradas: "))

lista = [', '.join(x) for x in permutations(lista_pilotos, n_pos)]

arquivo = open("lista.txt","w")
for pos in lista:
    arquivo.write(f'{pos}\n')
arquivo.close()