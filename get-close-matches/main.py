import difflib as dl

lista_profissoes = ['Médico','Dona de casa','Enfermeira','Policial','Motorista']
lista_profissoes_2 = ['motorista particular','motorista de caminhao','medico','medico ','dona de casa','policial civil','policial militar','policia federal','policia']
lista_formatada = []

for name in lista_profissoes_2:
    profissao = dl.get_close_matches(name, lista_profissoes,cutoff=0.5)
    print(profissao)
