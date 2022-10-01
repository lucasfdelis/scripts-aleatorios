from bs4 import BeautifulSoup
import requests


l={}
u=list()
url="https://www.proxynova.com/proxy-server-list/country-br/"
respo = requests.get(url).text
soup = BeautifulSoup(respo,'html.parser')
allproxy = soup.find_all("tr")
for proxy in allproxy:
 foo = proxy.find_all("td")
 try: 
  #  print('')
  #  l["ip"]=foo[0].text.replace("\n","").replace("document.write(","").replace(")","").replace("\’","").replace(";","")
   l["ip"]=str(foo[0].find('abbr')('script')).replace('<script>document.write(','').replace(');</script>','').replace("['",'').replace("']",'')
 except Exception as e:
   print(e)
   l["ip"]=None
 try:
  l["port"]=foo[1].text.replace("\n","").replace(" ","")
 except:
  l["port"]=None
 try:
  l["country"]=foo[5].text.replace("\n","").replace(" ","")
 except:
  l["country"]=None
 if(l["port"] is not None):
  u.append(l)
 
 l={}
print(u)