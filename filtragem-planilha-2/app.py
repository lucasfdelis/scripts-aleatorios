from selenium import webdriver
from selenium.webdriver.chrome.options import Options
import pandas as pd

chrome_options = Options()
chrome_options.add_argument('--no-sandbox')
driver = webdriver.Chrome(r'drivers/chromedriver', options=chrome_options)
driver.get('https://aplicacoes.mds.gov.br/sagi/servicos/misocial/?fq=anomes_s:2021*&fq=qtd_cisternas_entregues_consumo_mds_i:{0%20TO%20*]%20OR%20qtd_cisternas_entregues_producao_mds_i:{0%20TO%20*]%20OR%20qtd_cisternas_entregues_escolar_mds_i:{0%20TO%20*]&fl=codigo_ibge,anomes:anomes_s,qtd_cisternas_entregues_consumo:qtd_cisternas_entregues_consumo_mds_i,qtd_cisternas_entregues_producao:qtd_cisternas_entregues_producao_mds_i,qtd_cisternas_entregues_escolar:qtd_cisternas_entregues_escolar_mds_i&q=*:*&rows=1500000&sort=anomes_s%20asc,%20codigo_ibge%20asc&wt=csv')
data = driver.find_elements_by_xpath('/html/body/pre')
for value in data:
    df = pd.Series(data=value.text)
df = df.T
print(str(df))
with open("ccc.csv", 'w') as csvFile:
        csvFile.write(str(df))