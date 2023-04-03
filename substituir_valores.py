#Substituir os valores x de uma coluna baseados em outro valor de outra coluna

import pandas as pd

#Desconsiderando a primeira linha com o skiprows
df = pd.read_csv('tabela.csv', sep=',',encoding='ISO-8859-1', skiprows=1)

#Substituindo os x a partir dos valores da coluna Result
df=df.apply(lambda x:x.replace('x',int(x['Result'])),axis=1)

#Gerando o arquivo de saída
df.to_excel('resultado.xlsx', index=False)


#https://www.youtube.com/watch?v=xvFZjo5PgG0